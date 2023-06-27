namespace StaticaDbContext.Models
{
    public partial class Rfid
    {
        public Rfid()
        {
            PostRfidBacks = new HashSet<Post>();
            PostRfids = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string RfidName { get; set; } = null!;
        public int? ComParamsId { get; set; }
        public bool? UseId { get; set; }
        public bool? IsUhf { get; set; }

        public virtual ParamsCom? ComParams { get; set; }
        public virtual ICollection<Post> PostRfidBacks { get; set; }
        public virtual ICollection<Post> PostRfids { get; set; }
    }
}
