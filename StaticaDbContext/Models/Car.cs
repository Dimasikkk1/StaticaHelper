namespace StaticaDbContext.Models
{
    /// <summary>
    /// Автомобили
    /// </summary>
    public partial class Car
    {
        public Car()
        {
            BetweenCars = new HashSet<BetweenCar>();
            DownSuspCars = new HashSet<DownSuspCar>();
            InverseParent = new HashSet<Car>();
            Journals = new HashSet<Journal>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string? Name { get; set; }
        public bool? Isgroup { get; set; }
        public string? Mark { get; set; }
        public string? Model { get; set; }
        public string? Type { get; set; }
        public int? Driver { get; set; }
        public double Tara { get; set; }
        public bool Deleted { get; set; }
        public int? GoodId { get; set; }
        public int? TrailerId { get; set; }
        public string? RfidCode { get; set; }
        public int? SenderId { get; set; }
        public bool? NoPrint { get; set; }
        public int? RecipientId { get; set; }
        public int? TransitId { get; set; }

        public virtual Driver? DriverNavigation { get; set; }
        public virtual Good? Good { get; set; }
        public virtual Car? Parent { get; set; }
        public virtual Company? Recipient { get; set; }
        public virtual Company? Sender { get; set; }
        public virtual Trailer? Trailer { get; set; }
        public virtual Company? Transit { get; set; }
        public virtual ICollection<BetweenCar> BetweenCars { get; set; }
        public virtual ICollection<DownSuspCar> DownSuspCars { get; set; }
        public virtual ICollection<Car> InverseParent { get; set; }
        public virtual ICollection<Journal> Journals { get; set; }
    }
}
