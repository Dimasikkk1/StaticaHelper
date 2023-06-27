namespace StaticaDbContext.Models
{
    public partial class DigitTableStatus
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int? DigitTableId { get; set; }
        public int? TextStatusId { get; set; }

        public virtual DigitTable? DigitTable { get; set; }
        public virtual Post Post { get; set; } = null!;
        public virtual DigitTableText? TextStatus { get; set; }
    }
}
