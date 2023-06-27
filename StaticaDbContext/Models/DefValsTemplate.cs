namespace StaticaDbContext.Models
{
    public partial class DefValsTemplate
    {
        public DefValsTemplate()
        {
            AdditDefaultValues = new HashSet<AdditDefaultValue>();
            DefaultValues = new HashSet<DefaultValue>();
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<AdditDefaultValue> AdditDefaultValues { get; set; }
        public virtual ICollection<DefaultValue> DefaultValues { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
