namespace StaticaDbContext.Models
{
    public partial class TisTable
    {
        public int Id { get; set; }
        public int? JournalId { get; set; }
        public string Truck { get; set; } = null!;
        public string Rfid { get; set; } = null!;
        public bool Finished { get; set; }

        public virtual Journal? Journal { get; set; }
    }
}
