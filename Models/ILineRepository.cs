namespace RA_OEE_App.Models
{
    public interface ILineRepository
    {
        IEnumerable<Line> AllLines { get; }

        IEnumerable<Line> GetLineById(int LineId);
    }
}
