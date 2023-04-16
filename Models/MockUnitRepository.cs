namespace RA_OEE_App.Models
{
    public class MockUnitRepository : IUnitRepository
    {
        private readonly ILineRepository _lineRepository = new MockLineRepository();

        public IEnumerable<Unit> AllUnits =>
            new List<Unit>
            { 
                //Bread Line Mock Data
                new Unit{ 
                    UnitId = 1, 
                    UnitName = "Mix", 
                    Line= _lineRepository.AllLines.ToList()[0] , 
                    CurrentStatus = Unit.StatusEnum.Running, 
                    Description = "Details",
                    Recipe = "Whole Wheat"
                },
                new Unit{ 
                    UnitId = 2, 
                    UnitName = "Bake", 
                    Line= _lineRepository.AllLines.ToList()[0] , 
                    CurrentStatus = Unit.StatusEnum.Running, 
                    Description = "Details",
                    Recipe = "Whole Wheat"
                },
                new Unit{ 
                    UnitId = 3, 
                    UnitName = "Package", 
                    Line= _lineRepository.AllLines.ToList()[0], 
                    CurrentStatus = Unit.StatusEnum.Running, 
                    Description = "Details",
                    Recipe = "Whole Wheat"
                },

                //Baguette Line Mock Data
                new Unit{ 
                    UnitId = 4,
                    UnitName = "Mix", 
                    Line= _lineRepository.AllLines.ToList()[1], 
                    CurrentStatus = Unit.StatusEnum.Running, 
                    Description = "Details",
                    Recipe = "Classic Baguette"
                },
                new Unit{ 
                    UnitId = 5, 
                    UnitName = "Proof", 
                    Line= _lineRepository.AllLines.ToList()[1], 
                    CurrentStatus = Unit.StatusEnum.Running, 
                    Description = "Details",
                    Recipe = "Classic Baguette"
                },
                new Unit{ 
                    UnitId = 6, 
                    UnitName = "Bake", 
                    Line= _lineRepository.AllLines.ToList()[1], 
                    CurrentStatus = Unit.StatusEnum.Running, 
                    Description = "Details",
                    Recipe = "Classic Baguette"
                },
                new Unit{ 
                    UnitId = 7, 
                    UnitName = "Package", 
                    Line= _lineRepository.AllLines.ToList()[1], 
                    CurrentStatus = Unit.StatusEnum.Running, 
                    Description = "Details",
                    Recipe = "Classic Baguette"
                },

                //Pizza Crust Line Mock Data
                new Unit{ 
                    UnitId = 8, 
                    UnitName = "Mix", 
                    Line= _lineRepository.AllLines.ToList()[2], 
                    CurrentStatus = Unit.StatusEnum.Stopped, 
                    Description = "Details",
                    Recipe = "Thin Pizza Crust"
                },
                new Unit{ 
                    UnitId = 9, 
                    UnitName = "Freeze", 
                    Line= _lineRepository.AllLines.ToList()[2], 
                    CurrentStatus = Unit.StatusEnum.Running, 
                    Description = "Details",
                    Recipe = "Thin Pizza Crust"
                },
                new Unit{ 
                    UnitId = 10, 
                    UnitName = "Package", 
                    Line= _lineRepository.AllLines.ToList()[2], 
                    CurrentStatus = Unit.StatusEnum.Running, 
                    Description = "Details",
                    Recipe = "Thin Pizza Crust"
                }

            };

        public IEnumerable<Unit> GetUnitById(int Id)
        {
              return AllUnits.Where(u => u.UnitId == Id);
        }

        public IEnumerable<Unit> UnitsByLine(int LineId)
        {
            return AllUnits.Where(u => u.Line.LineId == LineId);
        }


    }
}
