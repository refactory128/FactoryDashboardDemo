using RA_OEE_App.Models;

namespace RA_OEE_App.ViewModel
{
    public class LineDetailViewModel
    {
        public IEnumerable<Unit> Units { get; }
        public Line CurrentLine { get; }

        public LineDetailViewModel(Line currentLine, IEnumerable<Unit> units)
        {
            Units = units;
            CurrentLine = currentLine;
        }
    }
}
