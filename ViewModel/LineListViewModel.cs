using RA_OEE_App.Models;

namespace RA_OEE_App.ViewModel
{
    public class LineListViewModel
    {
        public IEnumerable<Line> Lines { get; }

        public LineListViewModel(IEnumerable<Line> lines)
        {
            Lines = lines;
        }
    }
}
