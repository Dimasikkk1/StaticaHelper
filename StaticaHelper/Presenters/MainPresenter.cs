using StaticaHelper.Extensions;
using StaticaHelper.Models;
using StaticaHelper.Properties;
using StaticaHelper.Views;

namespace StaticaHelper.Presenters
{
    /// <summary>
    /// Презентер <see cref="IMainView"/> (<see cref="MainForm"/>).
    /// </summary>
    internal class MainPresenter : Presenter<IMainView>, IPresenter
    {
        #region Fields

        private readonly ConnectionInspector _connectionInspector;
        private readonly QueryesHandbook _queryesHandbook;
        private readonly WorkbookSaver _workbookSaver;

        private IEnumerable<Record> _currentRecords = default!;

        #endregion

        #region Properties

        private ConnectionString _connectionString = default!;

        public ConnectionString ConnectionString 
        {
            get => _connectionString;
            set
            {
                _connectionString = value;

                _connectionInspector.ConnectionString = value;
                _queryesHandbook.ConnectionString = value;
            }
        }

        #endregion

        #region Constructors

        public MainPresenter(ApplicationController applicationController, IMainView view) : base(applicationController, view)
        {
            _connectionInspector = new ConnectionInspector();
            _connectionInspector.StateChanged += (s, e) => View.Connection = e;

            _queryesHandbook = new QueryesHandbook();

            _workbookSaver = new WorkbookSaver();

            view.From = DateTime.Now.Date;
            view.To = DateTime.Now.Date.AddDays(1);

            view.LoadForm += OnLoadForm;
            view.CloseForm += OnCloseForm;
            view.ShowSettingsForm += OnShowSettingsForm;
            view.ShowAboutForm += OnShowAboutForm;
            view.UpdateDataTable += OnUpdateDataTable;
            view.DownloadAll += OnDownloadAll;
            view.DownloadSelected += OnDownloadSelected;
            view.GetYesterday += OnGetYesterday;
            view.GetThreeDays += OnGetThreeDays;
            view.GetAll += OnGetAll;

            ConnectionString = ConnectionString.CreateFromSettings(Settings.Default);
        }

        #endregion

        #region Methods

        protected virtual void OnLoadForm(object? sender, EventArgs args)
        {
            View.Location = Settings.Default.MainFormLocation;
            View.Size = Settings.Default.MainFormSize;
            View.Maximized = Settings.Default.MainFormMaximized;
            View.AutoSaveAndOpen = Settings.Default.AutoSaveAndOpen;
        }

        protected virtual void OnCloseForm(object? sender, EventArgs args)
        {
            Settings.Default.MainFormLocation = View.Location;
            Settings.Default.MainFormSize = View.Size;
            Settings.Default.MainFormMaximized = View.Maximized;
            Settings.Default.AutoSaveAndOpen = View.AutoSaveAndOpen;
            Settings.Default.Save();
        }

        private void OnShowSettingsForm(object? sender, EventArgs args)
        {
            ApplicationController.RunDialog<SettingsPresenter>();

            ConnectionString = ConnectionString.CreateFromSettings(Settings.Default);
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "О программе" от <see cref="IMainView"/> (<see cref="MainForm"/>).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnShowAboutForm(object? sender, EventArgs args)
        {
            ApplicationController.RunDialog<AboutPresenter>();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Обновить" от <see cref="IMainView"/> (<see cref="MainForm"/>).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnUpdateDataTable(object? sender, EventArgs args) =>
            Process(async () => UpdateCurrentRecords(await _queryesHandbook.GetRecordsByDateAsync(View.From, View.To)), () => ConnectionString.Completed);

        /// <summary>
        /// Обработчик события нажатия на кнопку "Выгрузить всё" от <see cref="IMainView"/> (<see cref="MainForm"/>).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDownloadAll(object? sender, EventArgs args) => 
            Process(async () => await _workbookSaver.SaveAsync(_currentRecords, _queryesHandbook.LastFrom, _queryesHandbook.LastTo, View.AutoSaveAndOpen), () => true);

        /// <summary>
        /// Обработчик события нажатия на кнопку "Выгрузить выделенное" от <see cref="IMainView"/> (<see cref="MainForm"/>).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDownloadSelected(object? sender, EventArgs args) =>
            Process(async () =>
            {
                var selectedRecords = _currentRecords.GetIndexedItems(View.SelectedRows);

                await _workbookSaver.SaveAsync(selectedRecords, selectedRecords?.FirstOrDefault()?.BruttoDate, selectedRecords?.LastOrDefault()?.TareDate, View.AutoSaveAndOpen);
            }, () => true);

        /// <summary>
        /// Обработчик события нажатия на кнопку "Записи за вчерашний день" от <see cref="IMainView"/> (<see cref="MainForm"/>).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnGetYesterday(object? sender, EventArgs args) =>
            Process(async () => UpdateCurrentRecords(await _queryesHandbook.GetYesterdayRecordsAsync()), () => ConnectionString.Completed);

        /// <summary>
        /// Обработчик события нажатия на кнопку "Записи за 3 дня (пятница, суббота, восксенье)" от <see cref="IMainView"/> (<see cref="MainForm"/>).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnGetThreeDays(object? sender, EventArgs args) =>
            Process(async () => UpdateCurrentRecords(await _queryesHandbook.GetLastThreeDaysRecordsAsync()), () => ConnectionString.Completed);

        /// <summary>
        /// Обработчик события нажатия на кнопку "Записи за всё время" от <see cref="IMainView"/> (<see cref="MainForm"/>).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnGetAll(object? sender, EventArgs args) =>
            Process(async () => UpdateCurrentRecords(await _queryesHandbook.GetAllRecordsAsync()), () => ConnectionString.Completed);

        /// <summary>
        /// Метод-обёртка для включения/выключения <see cref="ProgressBar"/> в <see cref="MainForm"/> во время выполнения какого-либо времязатратного действия.
        /// </summary>
        /// <param name="action">Выполняемый метод.</param>
        private async void Process(Func<Task> action, Func<bool> canExecute)
        {
            if (!canExecute())
                return;

            View.InProgress = true;

            try
            {
                await action();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            View.InProgress = false;
        }

        private async void UpdateCurrentRecords(IEnumerable<Record> records)
        {
            _currentRecords = records;

            View.DataTable = await _currentRecords.ToDataTableAsync();
            View.RecordsCount = _currentRecords.Count();

            View.SetFromAndToDates(_queryesHandbook.LastFrom, _queryesHandbook.LastTo);
        }

        #endregion
    }
}
