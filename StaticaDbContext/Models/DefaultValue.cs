namespace StaticaDbContext.Models
{
    public partial class DefaultValue
    {
        public int Id { get; set; }
        public int? GoodId { get; set; }
        public int? SenderId { get; set; }
        public int? PayerId { get; set; }
        public int? RecipientId { get; set; }
        public int TemplateId { get; set; }
        public int? TransitId { get; set; }

        public virtual Good? Good { get; set; }
        public virtual Company? Payer { get; set; }
        public virtual Company? Recipient { get; set; }
        public virtual Company? Sender { get; set; }
        public virtual DefValsTemplate Template { get; set; } = null!;
        public virtual Company? Transit { get; set; }
    }
}
