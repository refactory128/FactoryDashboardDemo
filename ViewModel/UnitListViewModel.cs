using RA_OEE_App.Models;

namespace RA_OEE_App.ViewModel
{
    public class UnitListViewModel
    {
        public IEnumerable<Unit> Units { get; }
        public string? CurrentLine { get; }

        public UnitListViewModel(IEnumerable<Unit> units, string? currentLine)
        {
            Units = units;
            CurrentLine = currentLine;
        }
    }
}
