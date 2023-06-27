namespace StaticaDbContext.Models
{
    public partial class ApiSetting
    {
        public int Id { get; set; }
        public int ApiPort { get; set; }
        public string ApiHost { get; set; } = null!;
        public bool ApiSsl { get; set; }
        public bool ApiUseAuth { get; set; }
        public bool ApiUseSendW { get; set; }
        public bool ApiUseToken { get; set; }
        public bool ApiAutosend { get; set; }
        public bool? ApiSendPhotos { get; set; }
        public bool ApiSendAllWeights { get; set; }
        public string? ApiLogin { get; set; }
        public string? ApiPassword { get; set; }
        public string? ApiAuthCmd { get; set; }
        public string? ApiSendWCmd { get; set; }
        public string? ApiSyncGoodCmd { get; set; }
        public string? ApiSyncCompCmd { get; set; }
        public string? ApiSyncCarCmd { get; set; }
        public string? ApiSyncTrailerCmd { get; set; }
        public string? ApiSyncTrainCmd { get; set; }
        public string? ApiSyncDriverCmd { get; set; }
        public bool UseRetrySendWeights { get; set; }
        public int RetryTime { get; set; }
    }
}
