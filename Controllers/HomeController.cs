using Microsoft.AspNetCore.Mvc;
using RA_OEE_App.Models;
using RA_OEE_App.ViewModel;
using System.Diagnostics;

namespace RA_OEE_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILineRepository _lineRepository;
        private readonly IUnitRepository _unitRepository;

        public HomeController(ILogger<HomeController> logger, ILineRepository lineRepository, IUnitRepository unitRepository)
        {
            _logger = logger;
            _lineRepository = lineRepository;
            _unitRepository = unitRepository;

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ViewResult Index()
        {
            var allLines = _lineRepository.AllLines;
            var unitsByLine = _unitRepository.UnitsByLine;

            var homeViewModel = new HomeViewModel(allLines, unitsByLine);

            return View(homeViewModel);
        }


    }
}