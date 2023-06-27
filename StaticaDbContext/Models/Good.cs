namespace StaticaDbContext.Models
{
    /// <summary>
    /// Номенклатура
    /// </summary>
    public partial class Good
    {
        public Good()
        {
            Cars = new HashSet<Car>();
            DefaultValues = new HashSet<DefaultValue>();
            InverseParent = new HashSet<Good>();
            Journals = new HashSet<Journal>();
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string? Name { get; set; }
        public bool? Isgroup { get; set; }
        public double Coef { get; set; }
        public bool Deleted { get; set; }
        public string? MeasureCoef { get; set; }
        public string? Barcode { get; set; }
        public int? TareId { get; set; }
        public string? IconName { get; set; }
        public string? VendorCode { get; set; }
        public bool? NoPrint { get; set; }
        /// <summary>
        /// 0 - multiply, 1 - plus, 2 - minus, 3 - divide
        /// </summary>
        public int? CoefAction { get; set; }

        public virtual Good? Parent { get; set; }
        public virtual Tare? Tare { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<DefaultValue> DefaultValues { get; set; }
        public virtual ICollection<Good> InverseParent { get; set; }
        public virtual ICollection<Journal> Journals { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
