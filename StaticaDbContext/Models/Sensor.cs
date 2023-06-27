namespace StaticaDbContext.Models
{
    public partial class Sensor
    {
        public int Id { get; set; }
        public int? AutodeviceId { get; set; }
        public int ContactNum { get; set; }
        public string? Name { get; set; }

        public virtual AutomaticDevice? Autodevice { get; set; }
    }
}
