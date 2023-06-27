using StaticaHelper.Properties;

namespace StaticaHelper.Models
{
    internal class ConnectionString
    {
        public string? Host { get; set; }
        public string? Port { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Database { get; set; }

        public bool Completed => !string.IsNullOrEmpty(Host) && !string.IsNullOrEmpty(Port) && !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(Database);

        public override string ToString()
        {
            return $"{nameof(Host)}={Host};{nameof(Port)}={Port};{nameof(Username)}={Username};{nameof(Password)}={Password};{nameof(Database)}={Database}";
        }

        public static ConnectionString CreateFromSettings(Settings settings) => 
            new ConnectionString
            {
                Host = Settings.Default.Host,
                Port = Settings.Default.Port,
                Username = Settings.Default.Username,
                Password = Settings.Default.Password,
                Database = Settings.Default.Database
            };
    }
}
