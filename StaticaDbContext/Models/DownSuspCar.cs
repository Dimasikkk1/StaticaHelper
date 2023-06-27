namespace StaticaDbContext.Models
{
    public partial class DownSuspCar
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public short Down { get; set; }
        public short Susp { get; set; }

        public virtual Car Car { get; set; } = null!;
    }
}
