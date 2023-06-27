namespace StaticaDbContext.Models
{
    /// <summary>
    /// Пользователи
    /// </summary>
    public partial class User
    {
        public User()
        {
            Journals = new HashSet<Journal>();
            Logs = new HashSet<Log>();
            MobUsers = new HashSet<MobUser>();
            PostsAndUsers = new HashSet<PostsAndUser>();
        }

        public int Id { get; set; }
        public string? Login { get; set; }
        public string? Fio { get; set; }
        public bool? CanEdit { get; set; }

        public virtual ICollection<Journal> Journals { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<MobUser> MobUsers { get; set; }
        public virtual ICollection<PostsAndUser> PostsAndUsers { get; set; }
    }
}
