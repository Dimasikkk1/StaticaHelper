namespace StaticaDbContext.Models
{
    public partial class RecAlias
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Alias { get; set; } = null!;

        public virtual Post Post { get; set; } = null!;
    }
}
