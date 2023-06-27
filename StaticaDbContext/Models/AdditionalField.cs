namespace StaticaDbContext.Models
{
    public partial class AdditionalField
    {
        public AdditionalField()
        {
            AdditDefaultValues = new HashSet<AdditDefaultValue>();
            AdditFieldsCatalogs = new HashSet<AdditFieldsCatalog>();
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Required { get; set; }
        public bool Deleted { get; set; }
        public string? ColName { get; set; }
        public bool? TvInput { get; set; }
        public int? Priority { get; set; }

        public virtual ICollection<AdditDefaultValue> AdditDefaultValues { get; set; }
        public virtual ICollection<AdditFieldsCatalog> AdditFieldsCatalogs { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
