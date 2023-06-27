namespace StaticaDbContext.Models
{
    public partial class DigitTable
    {
        public DigitTable()
        {
            DigitTableStatuses = new HashSet<DigitTableStatus>();
            DigitTableTexts = new HashSet<DigitTableText>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? PostId { get; set; }
        public string? Address { get; set; }
        public int? Brightness { get; set; }
        public int? Speed { get; set; }
        public int? Port { get; set; }
        public int? ComParamsId { get; set; }
        public int? IpParamsId { get; set; }
        public bool? TranslateWeight { get; set; }
        public bool TranslatePsResult { get; set; }
        public bool? Dttype { get; set; }

        public virtual ParamsCom? ComParams { get; set; }
        public virtual Post? Post { get; set; }
        public virtual ICollection<DigitTableStatus> DigitTableStatuses { get; set; }
        public virtual ICollection<DigitTableText> DigitTableTexts { get; set; }
    }
}
