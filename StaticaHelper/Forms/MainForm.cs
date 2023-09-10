using StaticaHelper.Properties;
using StaticaHelper.Views;
using System.Data;

namespace StaticaHelper
{
    internal partial class MainForm : BaseForm, IMainView
    {
        private ConnectionState _connection;

        public ConnectionState Connection
        {
            get => _connection;
            set
            {
                if (_connection == value)
                    return;

                _connection = value;

                labelConnectionStatus.Image = _connection switch
                {
                    ConnectionState.Connecting => Resources.Antenna,
                    ConnectionState.Executing => Resources.Pass,
                    _ => Resources.Exclamation,
                };
            }
        }

        private bool _inProgress;
        
        public bool InProgress
        {
            get => _inProgress;
            set
            {
                if (_inProgress == value)
                    return;

                _inProgress = value;

                progressBar.Style = _inProgress ? ProgressBarStyle.Marquee : ProgressBarStyle.Continuous;
            }
        }

        public DataTable DataTable
        {
            get => dataGridView.DataSource as DataTable ?? throw new NotImplementedException();
            set => dataGridView.DataSource = value;
        }

        private int _recordsCount;

        public int RecordsCount
        {
            get => _recordsCount;
            set
            {
                if (_recordsCount == value)
                    return;

                _recordsCount = value;

                labelRecordsCount.Text = _recordsCount.ToString();
            }
        }

        private IEnumerable<int> _selectedRows = default!;

        public IEnumerable<int> SelectedRows
        {
            get => _selectedRows;
            set
            {
                if (_selectedRows == value)
                    return;

                _selectedRows = value;

                SelectedRecordsCount = value.Count();
            }
        }

        private int _selectedRecordsCount;

        public int SelectedRecordsCount
        {
            get => _selectedRecordsCount;
            set
            {
                if (_selectedRecordsCount == value)
                    return;

                _selectedRecordsCount = value;

                labelSelectedCount.Text = _selectedRecordsCount.ToString();
            }
        }

        public DateTime From
        {
            get => dateTimePickerFrom.Value;
            set => dateTimePickerFrom.Value = value;
        }

        public DateTime To
        {
            get => dateTimePickerTo.Value;
            set => dateTimePickerTo.Value = value;
        }

        public bool AutoSaveAndOpen
        {
            get => checkBoxAutoSaveAndOpen.Checked;
            set => checkBoxAutoSaveAndOpen.Checked = value;
        }

        public MainForm() : base()
        {
            InitializeComponent();
            
            buttonSettings.Click += (s, e) => ShowSettingsForm?.Invoke(this, EventArgs.Empty);
            buttonAbout.Click += (s, e) => ShowAboutForm?.Invoke(this, EventArgs.Empty);
            buttonGet.Click += (s, e) => UpdateDataTable?.Invoke(this, EventArgs.Empty);
            buttonDownloadAll.Click += (s, e) => DownloadAll?.Invoke(this, EventArgs.Empty);
            buttonDownloadSelected.Click += (s, e) => DownloadSelected?.Invoke(this, EventArgs.Empty);
            buttonQueryYesterday.Click += (s, e) => GetYesterday?.Invoke(this, EventArgs.Empty);
            buttonQueryThreeDays.Click += (s, e) => GetThreeDays?.Invoke(this, EventArgs.Empty);
            buttonQueryAll.Click += (s, e) => GetAll?.Invoke(this, EventArgs.Empty);

            dataGridView.SelectionChanged += OnSelectionChanged;
            dataGridView.AutoGenerateColumns = false;
        }

        public new void Show() => Application.Run(this);

        //private async void выгрузить«а¬черашнийƒеньToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //progressBar.Style = ProgressBarStyle.Marquee;

        //    //DataTable = await GetDataTableByDataRange(DateTime.Now.Date.AddDays(-1), DateTime.Now.Date);

        //    //var directoryPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, "∆урналы");
        //    //var filePath = Path.Combine(directoryPath, $"∆урнал {DateTime.Now.Date.AddDays(-1).ToShortDateString()}.xlsx");

        //    //await SaveWorkbook(_dataTable, filePath);

        //    //progressBar.Style = ProgressBarStyle.Continuous;

        //    //Process.Start("explorer.exe", directoryPath);
        //}
        public void SetFromAndToDates(DateTime? from, DateTime? to)
        {
            labelFrom.Text = $"{from?.ToLongDateString()} {from?.ToLongTimeString()}";
            labelTo.Text = $"{to?.ToLongDateString()} {to?.ToLongTimeString()}";
        }

        private void OnSelectionChanged(object? sender, EventArgs e)
        {
            var dataGridView = sender as DataGridView ?? throw new NullReferenceException();

            SelectedRows = dataGridView.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(row => row.Index)
                .Order();
        }

        public event EventHandler? ShowSettingsForm;
        public event EventHandler? ShowAboutForm;
        public event EventHandler? UpdateDataTable;
        public event EventHandler? DownloadAll;
        public event EventHandler? DownloadSelected;
        public event EventHandler? GetYesterday;
        public event EventHandler? GetThreeDays;
        public event EventHandler? GetAll;
    }
}