namespace StaticaDbContext.Models
{
    public partial class AutomaticDeviceStatus
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int? AutodeviceId { get; set; }
        public int? GatesId { get; set; }
        public int? TrafficLightId { get; set; }

        public virtual AutomaticDevice? Autodevice { get; set; }
        public virtual Gate? Gates { get; set; }
        public virtual Post Post { get; set; } = null!;
        public virtual TrafficLight? TrafficLight { get; set; }
    }
}
