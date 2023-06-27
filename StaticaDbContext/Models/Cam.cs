using System.Net;

namespace StaticaDbContext.Models
{
    /// <summary>
    /// IP-камеры
    /// </summary>
    public partial class Cam
    {
        public int Id { get; set; }
        public string CamName { get; set; } = null!;
        public IPAddress Ip { get; set; } = null!;
        public int? Port { get; set; }
        public string Path { get; set; } = null!;
        public string? Login { get; set; }
        public string? Pass { get; set; }
        public int CamRate { get; set; }
        public int? PostId { get; set; }
        public int? IpParamsId { get; set; }
        public bool ReadOnly { get; set; }
        public bool? ViaHttp { get; set; }
        public bool? UseMainThreadMjpeg { get; set; }
        public bool? UseInKpp { get; set; }
        public bool? IsReverse { get; set; }
        public bool? IsOverview { get; set; }
        public bool? OnlySnapshots { get; set; }

        public virtual ParamsIp? IpParams { get; set; }
        public virtual Post? Post { get; set; }
    }
}
