namespace StaticaDbContext.Models
{
    public partial class AutomaticDevice
    {
        public AutomaticDevice()
        {
            AutomaticDeviceStatuses = new HashSet<AutomaticDeviceStatus>();
            Gates = new HashSet<Gate>();
            PostSensorAutodevices = new HashSet<Post>();
            PostSensorKppAutodevices = new HashSet<Post>();
            Sensors = new HashSet<Sensor>();
            TrafficLights = new HashSet<TrafficLight>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? PostId { get; set; }
        public string? Address { get; set; }
        public int? Port { get; set; }
        public int? IpParamsId { get; set; }
        public int ServerNum { get; set; }
        public int Retries { get; set; }
        public int ConTimeout { get; set; }
        public bool CheckIfGatesOpen { get; set; }

        public virtual ParamsIp? IpParams { get; set; }
        public virtual Post? Post { get; set; }
        public virtual ICollection<AutomaticDeviceStatus> AutomaticDeviceStatuses { get; set; }
        public virtual ICollection<Gate> Gates { get; set; }
        public virtual ICollection<Post> PostSensorAutodevices { get; set; }
        public virtual ICollection<Post> PostSensorKppAutodevices { get; set; }
        public virtual ICollection<Sensor> Sensors { get; set; }
        public virtual ICollection<TrafficLight> TrafficLights { get; set; }
    }
}
