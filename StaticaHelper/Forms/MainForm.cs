using ClosedXML.Excel;
using StaticaHelper.Properties;
using StaticaHelper.Views;
using System.Data;
using System.Linq;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using Path = System.IO.Path;

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

        public MainForm() : base()
        {
            InitializeComponent();

            buttonSettings.Click += (s, e) => ShowSettingsForm?.Invoke(this, EventArgs.Empty);
            buttonAbout.Click += (s, e) => ShowAboutForm?.Invoke(this, EventArgs.Empty);
            buttonUpdate.Click += (s, e) => UpdateDataTable?.Invoke(this, EventArgs.Empty);
            buttonDownloadAll.Click += (s, e) => DownloadAll?.Invoke(this, EventArgs.Empty);
            buttonQueryYesterday.Click += (s, e) => GetYesterday?.Invoke(this, EventArgs.Empty);
            buttonQueryThreeDays.Click += (s, e) => GetThreeDays?.Invoke(this, EventArgs.Empty);
            buttonQueryAll.Click += (s, e) => GetAll?.Invoke(this, EventArgs.Empty);
            
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

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var dataGridView = sender as DataGridView ?? throw new NullReferenceException();

            toolStripStatusLabelSelectedCount.Text = dataGridView.SelectedRows.Cast<DataGridViewRow>().Count().ToString();//.Count.ToString();
        }

        public event EventHandler? ShowSettingsForm;
        public event EventHandler? ShowAboutForm;
        public event EventHandler? UpdateDataTable;
        public event EventHandler? DownloadAll;
        public event EventHandler? GetYesterday;
        public event EventHandler? GetThreeDays;
        public event EventHandler? GetAll;
    }
}