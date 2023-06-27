namespace StaticaDbContext.Models
{
    public partial class ParamsIp
    {
        public ParamsIp()
        {
            AutomaticDevices = new HashSet<AutomaticDevice>();
            Cams = new HashSet<Cam>();
            Scales = new HashSet<Scale>();
        }

        public int Id { get; set; }
        public string HostName { get; set; } = null!;
        public int Port { get; set; }
        public int? Callback { get; set; }

        public virtual ICollection<AutomaticDevice> AutomaticDevices { get; set; }
        public virtual ICollection<Cam> Cams { get; set; }
        public virtual ICollection<Scale> Scales { get; set; }
    }
}
