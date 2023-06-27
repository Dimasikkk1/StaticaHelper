namespace StaticaDbContext.Models
{
    public partial class AdditDefaultValue
    {
        public int Id { get; set; }
        public int AdditFieldId { get; set; }
        public int? AdditFieldCatId { get; set; }
        public string? Value { get; set; }
        public int? TemplateId { get; set; }

        public virtual AdditionalField AdditField { get; set; } = null!;
        public virtual AdditFieldsCatalog? AdditFieldCat { get; set; }
        public virtual DefValsTemplate? Template { get; set; }
    }
}
