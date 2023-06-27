namespace StaticaDbContext.Models
{
    /// <summary>
    /// Водители
    /// </summary>
    public partial class Driver
    {
        public Driver()
        {
            Cars = new HashSet<Car>();
            InverseParent = new HashSet<Driver>();
            TasksAndDrivers = new HashSet<TasksAndDriver>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string? Name { get; set; }
        public bool? Isgroup { get; set; }
        public string? Document { get; set; }
        public string? Comment { get; set; }
        public bool Deleted { get; set; }

        public virtual Driver? Parent { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<Driver> InverseParent { get; set; }
        public virtual ICollection<TasksAndDriver> TasksAndDrivers { get; set; }
    }
}
