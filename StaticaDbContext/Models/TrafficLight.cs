namespace StaticaDbContext.Models
{
    public partial class TrafficLight
    {
        public TrafficLight()
        {
            AutomaticDeviceStatuses = new HashSet<AutomaticDeviceStatus>();
        }

        public int Id { get; set; }
        public int? AutodeviceId { get; set; }
        public int? ContactNum { get; set; }
        public string? Name { get; set; }

        public virtual AutomaticDevice? Autodevice { get; set; }
        public virtual ICollection<AutomaticDeviceStatus> AutomaticDeviceStatuses { get; set; }
    }
}
