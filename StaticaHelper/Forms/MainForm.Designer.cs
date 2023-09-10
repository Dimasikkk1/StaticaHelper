namespace StaticaHelper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BruttoDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TareDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BruttoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NettoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buttonSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonQueryYesterday = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonQueryThreeDays = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonQueryAll = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonDownloadAll = new System.Windows.Forms.Button();
            this.buttonDownloadSelected = new System.Windows.Forms.Button();
            this.checkBoxAutoSaveAndOpen = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelFrom = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTo = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelRecordsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelSelectedCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberColumn,
            this.BruttoDateColumn,
            this.TareDateColumn,
            this.CarColumn,
            this.BruttoColumn,
            this.TareColumn,
            this.NettoColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 58);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(831, 228);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.OnSelectionChanged);
            // 
            // NumberColumn
            // 
            this.NumberColumn.DataPropertyName = "Номер документа";
            this.NumberColumn.HeaderText = "Номер документа";
            this.NumberColumn.MinimumWidth = 6;
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.ReadOnly = true;
            this.NumberColumn.Width = 131;
            // 
            // BruttoDateColumn
            // 
            this.BruttoDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BruttoDateColumn.DataPropertyName = "Дата (брутто)";
            this.BruttoDateColumn.HeaderText = "Дата (брутто)";
            this.BruttoDateColumn.MinimumWidth = 6;
            this.BruttoDateColumn.Name = "BruttoDateColumn";
            this.BruttoDateColumn.ReadOnly = true;
            this.BruttoDateColumn.Width = 105;
            // 
            // TareDateColumn
            // 
            this.TareDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TareDateColumn.DataPropertyName = "Дата (тара)";
            this.TareDateColumn.HeaderText = "Дата (тара)";
            this.TareDateColumn.MinimumWidth = 6;
            this.TareDateColumn.Name = "TareDateColumn";
            this.TareDateColumn.ReadOnly = true;
            this.TareDateColumn.Width = 92;
            // 
            // CarColumn
            // 
            this.CarColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CarColumn.DataPropertyName = "ТС";
            this.CarColumn.HeaderText = "ТС";
            this.CarColumn.MinimumWidth = 6;
            this.CarColumn.Name = "CarColumn";
            this.CarColumn.ReadOnly = true;
            this.CarColumn.Width = 46;
            // 
            // BruttoColumn
            // 
            this.BruttoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BruttoColumn.DataPropertyName = "Брутто";
            this.BruttoColumn.HeaderText = "Брутто";
            this.BruttoColumn.MinimumWidth = 6;
            this.BruttoColumn.Name = "BruttoColumn";
            this.BruttoColumn.ReadOnly = true;
            this.BruttoColumn.Width = 69;
            // 
            // TareColumn
            // 
            this.TareColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TareColumn.DataPropertyName = "Тара";
            this.TareColumn.HeaderText = "Тара";
            this.TareColumn.MinimumWidth = 6;
            this.TareColumn.Name = "TareColumn";
            this.TareColumn.ReadOnly = true;
            this.TareColumn.Width = 57;
            // 
            // NettoColumn
            // 
            this.NettoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NettoColumn.DataPropertyName = "Нетто";
            this.NettoColumn.HeaderText = "Нетто";
            this.NettoColumn.MinimumWidth = 6;
            this.NettoColumn.Name = "NettoColumn";
            this.NettoColumn.ReadOnly = true;
            this.NettoColumn.Width = 64;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonSettings,
            this.отчётыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(79, 20);
            this.buttonSettings.Text = "Настройки";
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonQueryYesterday,
            this.buttonQueryThreeDays,
            this.buttonQueryAll});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.отчётыToolStripMenuItem.Text = "Запросы";
            // 
            // buttonQueryYesterday
            // 
            this.buttonQueryYesterday.Name = "buttonQueryYesterday";
            this.buttonQueryYesterday.Size = new System.Drawing.Size(340, 22);
            this.buttonQueryYesterday.Text = "Записи за вчерашний день";
            // 
            // buttonQueryThreeDays
            // 
            this.buttonQueryThreeDays.Name = "buttonQueryThreeDays";
            this.buttonQueryThreeDays.Size = new System.Drawing.Size(340, 22);
            this.buttonQueryThreeDays.Text = "Записи за 3 дня (пятница, суббота, воскресенье)";
            // 
            // buttonQueryAll
            // 
            this.buttonQueryAll.Name = "buttonQueryAll";
            this.buttonQueryAll.Size = new System.Drawing.Size(340, 22);
            this.buttonQueryAll.Text = "Записи за всё время";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonHelp,
            this.buttonAbout});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(281, 22);
            this.buttonHelp.Text = "Инструкция по работе с программой";
            this.buttonHelp.Visible = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(281, 22);
            this.buttonAbout.Text = "О программе";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 314);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePickerFrom);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePickerTo);
            this.flowLayoutPanel1.Controls.Add(this.buttonGet);
            this.flowLayoutPanel1.Controls.Add(this.buttonDownloadAll);
            this.flowLayoutPanel1.Controls.Add(this.buttonDownloadSelected);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAutoSaveAndOpen);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(831, 52);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "С";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(24, 2);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(106, 23);
            this.dateTimePickerFrom.TabIndex = 0;
            this.dateTimePickerFrom.Value = new System.DateTime(2022, 12, 3, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "По";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(165, 2);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(106, 23);
            this.dateTimePickerTo.TabIndex = 1;
            this.dateTimePickerTo.Value = new System.DateTime(2022, 12, 3, 0, 0, 0, 0);
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(277, 2);
            this.buttonGet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(82, 22);
            this.buttonGet.TabIndex = 2;
            this.buttonGet.Text = "Получить";
            this.buttonGet.UseVisualStyleBackColor = true;
            // 
            // buttonDownloadAll
            // 
            this.buttonDownloadAll.Location = new System.Drawing.Point(365, 2);
            this.buttonDownloadAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDownloadAll.Name = "buttonDownloadAll";
            this.buttonDownloadAll.Size = new System.Drawing.Size(111, 22);
            this.buttonDownloadAll.TabIndex = 5;
            this.buttonDownloadAll.Text = "Выгрузить всё";
            this.buttonDownloadAll.UseVisualStyleBackColor = true;
            // 
            // buttonDownloadSelected
            // 
            this.buttonDownloadSelected.Location = new System.Drawing.Point(482, 2);
            this.buttonDownloadSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDownloadSelected.Name = "buttonDownloadSelected";
            this.buttonDownloadSelected.Size = new System.Drawing.Size(173, 22);
            this.buttonDownloadSelected.TabIndex = 6;
            this.buttonDownloadSelected.Text = "Выгрузить выделенное";
            this.buttonDownloadSelected.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoSaveAndOpen
            // 
            this.checkBoxAutoSaveAndOpen.AutoSize = true;
            this.checkBoxAutoSaveAndOpen.Checked = true;
            this.checkBoxAutoSaveAndOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoSaveAndOpen.Location = new System.Drawing.Point(3, 30);
            this.checkBoxAutoSaveAndOpen.Name = "checkBoxAutoSaveAndOpen";
            this.checkBoxAutoSaveAndOpen.Size = new System.Drawing.Size(270, 19);
            this.checkBoxAutoSaveAndOpen.TabIndex = 7;
            this.checkBoxAutoSaveAndOpen.Text = "Автоматически сохранять и открывать Excel";
            this.checkBoxAutoSaveAndOpen.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelConnectionStatus,
            this.progressBar,
            this.toolStripStatusLabel1,
            this.labelFrom,
            this.toolStripStatusLabel2,
            this.labelTo,
            this.labelSeparator,
            this.toolStripStatusLabel3,
            this.labelRecordsCount,
            this.toolStripStatusLabel4,
            this.labelSelectedCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 288);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(837, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.labelConnectionStatus.Image = global::StaticaHelper.Properties.Resources.Antenna;
            this.labelConnectionStatus.Margin = new System.Windows.Forms.Padding(3);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(20, 20);
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(88, 20);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(15, 21);
            this.toolStripStatusLabel1.Text = "С";
            // 
            // labelFrom
            // 
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(61, 21);
            this.labelFrom.Text = "00.00.0000";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(23, 21);
            this.toolStripStatusLabel2.Text = "По";
            // 
            // labelTo
            // 
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(61, 21);
            this.labelTo.Text = "00.00.0000";
            // 
            // labelSeparator
            // 
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(374, 21);
            this.labelSeparator.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(88, 21);
            this.toolStripStatusLabel3.Text = "Всего записей:";
            // 
            // labelRecordsCount
            // 
            this.labelRecordsCount.Name = "labelRecordsCount";
            this.labelRecordsCount.Size = new System.Drawing.Size(13, 21);
            this.labelRecordsCount.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(60, 21);
            this.toolStripStatusLabel4.Text = "Выбрано:";
            // 
            // labelSelectedCount
            // 
            this.labelSelectedCount.Name = "labelSelectedCount";
            this.labelSelectedCount.Size = new System.Drawing.Size(13, 21);
            this.labelSelectedCount.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 338);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaticHelper Утилита для выгрузки отчётов Автомобильных весов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem buttonAbout;
        private DataGridView dataGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Button buttonGet;
        private ToolStripMenuItem buttonSettings;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem отчётыToolStripMenuItem;
        private ToolStripMenuItem buttonQueryYesterday;
        private Button buttonDownloadAll;
        private DataGridViewTextBoxColumn NumberColumn;
        private DataGridViewTextBoxColumn BruttoDateColumn;
        private DataGridViewTextBoxColumn TareDateColumn;
        private DataGridViewTextBoxColumn CarColumn;
        private DataGridViewTextBoxColumn BruttoColumn;
        private DataGridViewTextBoxColumn TareColumn;
        private DataGridViewTextBoxColumn NettoColumn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelRecordsCount;
        private ToolStripProgressBar progressBar;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel labelSelectedCount;
        private Button buttonDownloadSelected;
        private ToolStripStatusLabel labelConnectionStatus;
        private ToolStripMenuItem buttonQueryThreeDays;
        private ToolStripMenuItem buttonQueryAll;
        private CheckBox checkBoxAutoSaveAndOpen;
        private ToolStripStatusLabel labelTo;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel labelFrom;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel labelSeparator;
        private ToolStripMenuItem buttonHelp;
    }
}