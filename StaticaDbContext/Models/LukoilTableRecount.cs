namespace StaticaDbContext.Models
{
    public partial class LukoilTableRecount
    {
        public int Id { get; set; }
        public int? JournalId { get; set; }
        public double Press { get; set; }
        public double Temp { get; set; }
        public double Density { get; set; }
        public string Good { get; set; } = null!;

        public virtual Journal? Journal { get; set; }
    }
}
