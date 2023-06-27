namespace StaticaDbContext.Models
{
    public partial class PostsAndUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }

        public virtual Post Post { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
