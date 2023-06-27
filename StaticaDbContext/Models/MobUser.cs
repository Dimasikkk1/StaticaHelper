namespace StaticaDbContext.Models
{
    public partial class MobUser
    {
        public int Id { get; set; }
        public string Login { get; set; } = null!;
        public int SystemLogin { get; set; }
        public bool? Active { get; set; }
        public string Password { get; set; } = null!;

        public virtual User SystemLoginNavigation { get; set; } = null!;
    }
}
