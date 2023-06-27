namespace StaticaDbContext.Models
{
    public partial class Task
    {
        public Task()
        {
            TasksAndDrivers = new HashSet<TasksAndDriver>();
        }

        public int Id { get; set; }
        public string? TaskName { get; set; }
        public string? TaskText { get; set; }
        public bool? IsActive { get; set; }
        public int? GoodId { get; set; }
        public bool? UseGoodsCatalog { get; set; }
        public int? Priority { get; set; }
        public double? ExpectedWeight { get; set; }
        public double? ExpectedWeightPercentMes { get; set; }
        public bool? UseCustomField { get; set; }
        public int? CustomFieldId { get; set; }
        public bool? UseTaresCatalog { get; set; }

        public virtual AdditionalField? CustomField { get; set; }
        public virtual Good? Good { get; set; }
        public virtual ICollection<TasksAndDriver> TasksAndDrivers { get; set; }
    }
}
