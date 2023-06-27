namespace StaticaDbContext.Models
{
    public partial class PrintScheme
    {
        public int Id { get; set; }
        public string? SchemaName { get; set; }
        public int? ActCount { get; set; }
        public int? TnCount { get; set; }
        public int? TtnCount { get; set; }
        public int? VgmCount { get; set; }
    }
}
