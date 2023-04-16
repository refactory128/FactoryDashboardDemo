namespace RA_OEE_App.Models
{
    public class Unit
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; } = string.Empty;
        public string? Description { get; set; }

        public enum StatusEnum { Stopped, Running }

        public StatusEnum CurrentStatus { get; set; }

        public string? Recipe { get; set; }

        public Line Line { get; set; } = default!;
    }
}
