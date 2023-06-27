namespace StaticaHelper.Models
{
    internal class Record
    {
        public int Number { get; set; }
        public DateTime? BruttoDate { get; set; }
        public DateTime? TareDate { get; set; }
        public string? Car { get; set; }
        public double? Brutto { get; set; }
        public double? Tare { get; set; }
        public double? Netto { get; set; }

        public string[] ToArray()
        {
            return new[]
            {
                Number.ToString(),
                BruttoDate.ToString()!,
                TareDate.ToString()!,
                Car ?? string.Empty,
                Brutto.ToString()!,
                Tare.ToString()!,
                Netto.ToString()!
            };
        }
    }
}
