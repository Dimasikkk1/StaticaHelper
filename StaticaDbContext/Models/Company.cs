namespace StaticaDbContext.Models
{
    /// <summary>
    /// Контрагенты
    /// </summary>
    public partial class Company
    {
        public Company()
        {
            CarRecipients = new HashSet<Car>();
            CarSenders = new HashSet<Car>();
            CarTransits = new HashSet<Car>();
            DefaultValuePayers = new HashSet<DefaultValue>();
            DefaultValueRecipients = new HashSet<DefaultValue>();
            DefaultValueSenders = new HashSet<DefaultValue>();
            DefaultValueTransits = new HashSet<DefaultValue>();
            InverseParent = new HashSet<Company>();
            JournalCompanyPayerNavigations = new HashSet<Journal>();
            JournalCompanyRecipientNavigations = new HashSet<Journal>();
            JournalCompanySenderNavigations = new HashSet<Journal>();
            JournalCompanyTransitNavigations = new HashSet<Journal>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string? Name { get; set; }
        public bool? Isgroup { get; set; }
        public string? LawAddress { get; set; }
        public string? FactAddress { get; set; }
        public string? Contacts { get; set; }
        public string? Inn { get; set; }
        public string? Kpp { get; set; }
        public string? Ogrn { get; set; }
        public bool Deleted { get; set; }
        public bool? NoPrint { get; set; }

        public virtual Company? Parent { get; set; }
        public virtual ICollection<Car> CarRecipients { get; set; }
        public virtual ICollection<Car> CarSenders { get; set; }
        public virtual ICollection<Car> CarTransits { get; set; }
        public virtual ICollection<DefaultValue> DefaultValuePayers { get; set; }
        public virtual ICollection<DefaultValue> DefaultValueRecipients { get; set; }
        public virtual ICollection<DefaultValue> DefaultValueSenders { get; set; }
        public virtual ICollection<DefaultValue> DefaultValueTransits { get; set; }
        public virtual ICollection<Company> InverseParent { get; set; }
        public virtual ICollection<Journal> JournalCompanyPayerNavigations { get; set; }
        public virtual ICollection<Journal> JournalCompanyRecipientNavigations { get; set; }
        public virtual ICollection<Journal> JournalCompanySenderNavigations { get; set; }
        public virtual ICollection<Journal> JournalCompanyTransitNavigations { get; set; }
    }
}
