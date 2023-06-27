namespace StaticaDbContext.Models
{
    public partial class Journal
    {
        public Journal()
        {
            Axles = new HashSet<Axle>();
            BetwBrus = new HashSet<BetwBru>();
            Betws = new HashSet<Betw>();
            Downsusps = new HashSet<Downsusp>();
            JournalApiSends = new HashSet<JournalApiSend>();
            LukoilTableRecounts = new HashSet<LukoilTableRecount>();
            PepsiRecords = new HashSet<PepsiRecord>();
            Pictures = new HashSet<Picture>();
            QrJournals = new HashSet<QrJournal>();
            TisTables = new HashSet<TisTable>();
            Vels = new HashSet<Vel>();
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? TareDate { get; set; }
        public DateTime? BruttoDate { get; set; }
        public double? Tare { get; set; }
        public double? Brutto { get; set; }
        public double? Netto { get; set; }
        public int? CarId { get; set; }
        public int? TrailerId { get; set; }
        public int? TrainId { get; set; }
        public int? GoodId { get; set; }
        public int? CompanySender { get; set; }
        public int? CompanyPayer { get; set; }
        public int? CompanyRecipient { get; set; }
        public bool Blocked { get; set; }
        public string PostName { get; set; } = null!;
        public bool Deleted { get; set; }
        public bool Finished { get; set; }
        public int? UserId { get; set; }
        public double? CoefWeight { get; set; }
        public DateTime? NettoDate { get; set; }
        public int? DriverId { get; set; }
        public string? RfidCode { get; set; }
        public string? MsScalesName { get; set; }
        public string? MsWgroupName { get; set; }
        public bool? MoveDirection { get; set; }
        public bool BadTransit { get; set; }
        public int? CompanyTransit { get; set; }

        public virtual Car? Car { get; set; }
        public virtual Company? CompanyPayerNavigation { get; set; }
        public virtual Company? CompanyRecipientNavigation { get; set; }
        public virtual Company? CompanySenderNavigation { get; set; }
        public virtual Company? CompanyTransitNavigation { get; set; }
        public virtual Good? Good { get; set; }
        public virtual Trailer? Trailer { get; set; }
        public virtual Train? Train { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Axle> Axles { get; set; }
        public virtual ICollection<BetwBru> BetwBrus { get; set; }
        public virtual ICollection<Betw> Betws { get; set; }
        public virtual ICollection<Downsusp> Downsusps { get; set; }
        public virtual ICollection<JournalApiSend> JournalApiSends { get; set; }
        public virtual ICollection<LukoilTableRecount> LukoilTableRecounts { get; set; }
        public virtual ICollection<PepsiRecord> PepsiRecords { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
        public virtual ICollection<QrJournal> QrJournals { get; set; }
        public virtual ICollection<TisTable> TisTables { get; set; }
        public virtual ICollection<Vel> Vels { get; set; }
    }
}
