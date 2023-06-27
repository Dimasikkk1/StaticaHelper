namespace StaticaDbContext.Models
{
    public partial class Qr
    {
        public Qr()
        {
            PostQrBacks = new HashSet<Post>();
            PostQrs = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string QrName { get; set; } = null!;
        public int? ComParamsId { get; set; }

        public virtual ParamsCom? ComParams { get; set; }
        public virtual ICollection<Post> PostQrBacks { get; set; }
        public virtual ICollection<Post> PostQrs { get; set; }
    }
}
