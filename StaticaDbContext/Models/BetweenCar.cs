namespace StaticaDbContext.Models
{
    public partial class BetweenCar
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int Betw { get; set; }

        public virtual Car Car { get; set; } = null!;
    }
}
