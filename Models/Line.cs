namespace RA_OEE_App.Models
{
    public class Line
    {
        public int LineId { get; set; }
        public string LineName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public double Oee { get; set; }
        public double OeeTarget { get; set; }

        public enum StatusEnum { Stopped, Running }

        public StatusEnum CurrentStatus { get; set; }
        public List<Unit>? Units { get; set; }
    }
}
