using RA_OEE_App.Models;

namespace RA_OEE_App.ViewModel
{
    public class HomeViewModel
    {
        private Func<int, IEnumerable<Unit>> unitsByLine;

        public IEnumerable<Line> AllLines { get; }

        public IEnumerable<Unit> UnitsByLine { get; }

        public HomeViewModel(IEnumerable<Line> allLines, Func<int, IEnumerable<Unit>> unitsByLine)
        {
            AllLines = allLines;
            this.unitsByLine = unitsByLine;
        }
    }
}
