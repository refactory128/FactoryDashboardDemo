namespace RA_OEE_App.Models
{
    public interface IUnitRepository
    {
        IEnumerable<Unit> AllUnits { get; }
        IEnumerable<Unit> GetUnitById(int Id);

        IEnumerable<Unit> UnitsByLine(int LineId);
    }
}
