using RA_OEE_App.Models;
using RA_OEE_App.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace RA_OEE_App.Controllers
{
    public class LineController : Controller
    {
        private readonly ILineRepository _lineRepository;
        private readonly IUnitRepository _unitRepository;

        public LineController(IUnitRepository unitRepository, ILineRepository lineRepository)
        {
            _lineRepository = lineRepository;
            _unitRepository = unitRepository;
        }

        public ViewResult List()
        {
            IEnumerable<Line> lines;

            lines = _lineRepository.AllLines;

            return View(new LineListViewModel(lines));
        }

        public IActionResult Details(int id)
        {
            var line = _lineRepository.GetLineById(id).First();
            if (line == null)
                return NotFound();

            var units = _unitRepository.UnitsByLine(line.LineId);
            
            var lineDetailViewModel = new LineDetailViewModel(line, units);

            return View(lineDetailViewModel);
        }

    }
}
