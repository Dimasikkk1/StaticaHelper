namespace StaticaDbContext.Models
{
    public partial class AdditFieldsCatalog
    {
        public AdditFieldsCatalog()
        {
            AdditDefaultValues = new HashSet<AdditDefaultValue>();
        }

        public int Id { get; set; }
        public int AdditFieldId { get; set; }
        public string? Name { get; set; }
        public bool Deleted { get; set; }

        public virtual AdditionalField AdditField { get; set; } = null!;
        public virtual ICollection<AdditDefaultValue> AdditDefaultValues { get; set; }
    }
}
