using System.Data;
using ApplicationContext = StaticaDbContext.DbContext;

namespace StaticaHelper.Models
{
    internal class ConnectionInspector
    {
        private const int Delay = 5000;

        public ConnectionString ConnectionString { get; set; } = default!;

        public ConnectionInspector()
        {
            var syncContext = SynchronizationContext.Current;

            Task.Run(() =>
            {
                var lastConnectionState = ConnectionState.Connecting;

                while (true)
                {
                    if (ConnectionString == null || !ConnectionString.Completed)
                    {
                        Task.Delay(Delay).Wait();

                        continue;
                    }

                    using var dbContext = new ApplicationContext(ConnectionString.ToString());

                    var canConnect = dbContext.Database.CanConnect();

                    if (canConnect && lastConnectionState == ConnectionState.Executing)
                    {
                        Task.Delay(Delay).Wait();

                        continue;
                    }

                    if (canConnect && lastConnectionState != ConnectionState.Executing)
                    {
                        syncContext?.Post(_ => StateChanged?.Invoke(default, ConnectionState.Executing), default);

                        lastConnectionState = ConnectionState.Executing;

                        Task.Delay(Delay).Wait();

                        continue;
                    }

                    if (!canConnect && lastConnectionState == ConnectionState.Connecting)
                    {
                        syncContext?.Post(_ => StateChanged?.Invoke(default, ConnectionState.Broken), default);

                        lastConnectionState = ConnectionState.Broken;

                        Task.Delay(Delay).Wait();

                        continue;
                    }

                    syncContext?.Post(_ => StateChanged?.Invoke(default, ConnectionState.Connecting), default);

                    lastConnectionState = ConnectionState.Connecting;

                    Task.Delay(Delay).Wait();
                }
            });
        }

        public event EventHandler<ConnectionState>? StateChanged;
    }
}
