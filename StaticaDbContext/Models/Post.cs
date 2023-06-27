namespace StaticaDbContext.Models
{
    public partial class Post
    {
        public Post()
        {
            AutomaticDeviceStatuses = new HashSet<AutomaticDeviceStatus>();
            AutomaticDevices = new HashSet<AutomaticDevice>();
            Cams = new HashSet<Cam>();
            DigitTableStatuses = new HashSet<DigitTableStatus>();
            DigitTables = new HashSet<DigitTable>();
            PostsAndUsers = new HashSet<PostsAndUser>();
            RecAliases = new HashSet<RecAlias>();
            RecKpps = new HashSet<RecKpp>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool UseCams { get; set; }
        public bool UseDigitTables { get; set; }
        public bool? UseAutodevices { get; set; }
        public bool? UseRecognition { get; set; }
        public bool? UseRecognPictures { get; set; }
        public int? TemplateId { get; set; }
        public int? ConnectedPost { get; set; }
        public bool? UseBarcode { get; set; }
        public int? SensorAutodeviceId { get; set; }
        public bool UseRecognOverview { get; set; }
        public int? RfidId { get; set; }
        public int? RfidBackId { get; set; }
        public bool OnlyFindGood { get; set; }
        public bool DivideRfid { get; set; }
        public int? MsServerPort { get; set; }
        public bool AllowAnyAxlesResults { get; set; }
        public bool? ShowPhotoWidget { get; set; }
        public int? QrId { get; set; }
        public int? QrBackId { get; set; }
        public bool WatchSensorsOnKpp { get; set; }
        public bool KppCams { get; set; }
        public bool CompareKppCamNumsWithCatalogs { get; set; }
        public int KppCamsWaitSec { get; set; }
        public int? SensorKppAutodeviceId { get; set; }
        public int? HttpServerPort { get; set; }
        public bool? UseWeightDot { get; set; }
        public bool? UseWeightDotAuth { get; set; }
        public string? PrinterPath { get; set; }
        public bool? IgnoreDirection { get; set; }
        public bool? UseVadSensors { get; set; }
        public bool? UseSimpleView { get; set; }
        public bool? AskTare { get; set; }
        public bool? AskGood { get; set; }

        public virtual Post? ConnectedPostNavigation { get; set; }
        public virtual Qr? Qr { get; set; }
        public virtual Qr? QrBack { get; set; }
        public virtual Rfid? Rfid { get; set; }
        public virtual Rfid? RfidBack { get; set; }
        public virtual AutomaticDevice? SensorAutodevice { get; set; }
        public virtual AutomaticDevice? SensorKppAutodevice { get; set; }
        public virtual DefValsTemplate? Template { get; set; }
        public virtual Post? InverseConnectedPostNavigation { get; set; }
        public virtual Scale? Scale { get; set; }
        public virtual ICollection<AutomaticDeviceStatus> AutomaticDeviceStatuses { get; set; }
        public virtual ICollection<AutomaticDevice> AutomaticDevices { get; set; }
        public virtual ICollection<Cam> Cams { get; set; }
        public virtual ICollection<DigitTableStatus> DigitTableStatuses { get; set; }
        public virtual ICollection<DigitTable> DigitTables { get; set; }
        public virtual ICollection<PostsAndUser> PostsAndUsers { get; set; }
        public virtual ICollection<RecAlias> RecAliases { get; set; }
        public virtual ICollection<RecKpp> RecKpps { get; set; }
    }
}
