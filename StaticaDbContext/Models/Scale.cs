namespace StaticaDbContext.Models
{
    /// <summary>
    /// Весы
    /// </summary>
    public partial class Scale
    {
        public int Id { get; set; }
        public string ScalesName { get; set; } = null!;
        public string ComPort { get; set; } = null!;
        public short NetAddress { get; set; }
        public int Callback { get; set; }
        public int? PostId { get; set; }
        public int StableTimeout { get; set; }
        public double Threshold { get; set; }
        public string? ClientIp { get; set; }
        public int? ServerPort { get; set; }
        public int? ClientPort { get; set; }
        public int? IpParamsId { get; set; }
        public int? ComParamsId { get; set; }
        public int ErrorTicks { get; set; }
        public bool? UseNewStable { get; set; }
        public bool OnlyClient { get; set; }
        public bool WeighAnimals { get; set; }
        public bool AutoZero { get; set; }
        public bool SendConfirm { get; set; }
        public int CancelCode { get; set; }
        public int RepeatCode { get; set; }
        public string TvText { get; set; } = null!;
        public bool SaveLastCode { get; set; }
        public bool AvionAxlesOnScales { get; set; }
        public bool ZeroBeforeIn { get; set; }
        public int? WaitOutAddTime { get; set; }
        public bool? LiquidWeighting { get; set; }
        public int? LiquidOffset { get; set; }

        public virtual ParamsCom? ComParams { get; set; }
        public virtual ParamsIp? IpParams { get; set; }
        public virtual Post? Post { get; set; }
    }
}
