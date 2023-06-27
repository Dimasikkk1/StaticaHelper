namespace StaticaDbContext.Models
{
    public partial class TasksAndDriver
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public int TaskId { get; set; }

        public virtual Driver Driver { get; set; } = null!;
        public virtual Task Task { get; set; } = null!;
    }
}
