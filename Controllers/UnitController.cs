using RA_OEE_App.Models;
using RA_OEE_App.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace RA_OEE_App.Controllers
{
    public class UnitController : Controller
    {
        private readonly IUnitRepository _unitRepository;
        private readonly ILineRepository _lineRepository;

        public UnitController(IUnitRepository unitRepository, ILineRepository lineRepository)
        {
            _unitRepository = unitRepository;
            _lineRepository = lineRepository;
        }

        public ViewResult List(string LineName)
        {
            IEnumerable<Unit> units;
            string? currentLine;

            if (string.IsNullOrEmpty(LineName))
            {
                units = _unitRepository.AllUnits.OrderBy(p => p.UnitId);
                currentLine = "All Units";
            }
            else
            {
                units = _unitRepository.AllUnits.Where(p => p.Line.LineName == LineName)
                    .OrderBy(p => p.UnitId);
                currentLine = _lineRepository.AllLines.FirstOrDefault(c => c.LineName == LineName)?.LineName;
            }

            return View(new UnitListViewModel(units, currentLine));
        }

        public IActionResult Details(int id)
        {
            var unit = _unitRepository.GetUnitById(id);
            if (unit == null)
                return NotFound();

            return View(unit.First());
        }

    }
}
