namespace StaticaDbContext.Models
{
    public partial class ParamsCom
    {
        public ParamsCom()
        {
            DigitTables = new HashSet<DigitTable>();
            Qrs = new HashSet<Qr>();
            Rfids = new HashSet<Rfid>();
            Scales = new HashSet<Scale>();
        }

        public int Id { get; set; }
        public string? ComPort { get; set; }
        public int? Callback { get; set; }

        public virtual ICollection<DigitTable> DigitTables { get; set; }
        public virtual ICollection<Qr> Qrs { get; set; }
        public virtual ICollection<Rfid> Rfids { get; set; }
        public virtual ICollection<Scale> Scales { get; set; }
    }
}
