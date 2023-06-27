namespace StaticaDbContext.Models
{
    public partial class DigitTableText
    {
        public DigitTableText()
        {
            DigitTableStatuses = new HashSet<DigitTableStatus>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int DigitTableId { get; set; }
        public bool IsDouble { get; set; }
        public string? Text1 { get; set; }
        public string? Text2 { get; set; }
        public bool IsRound { get; set; }
        public bool IsWeiSend { get; set; }

        public virtual DigitTable DigitTable { get; set; } = null!;
        public virtual ICollection<DigitTableStatus> DigitTableStatuses { get; set; }
    }
}
