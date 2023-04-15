namespace RA_OEE_App.Models
{
    public class MockLineRepository : ILineRepository
    {


        public IEnumerable<Line> AllLines =>
            new List<Line>
            {
                new Line{
                    LineId=1, 
                    LineName="Line 1", 
                    Description="Sandwich Breads", 
                    Oee = 86.0D, 
                    OeeTarget = 85.0D, 
                    CurrentStatus = Line.StatusEnum.Running
                },
                new Line{
                    LineId=2, 
                    LineName="Line 2", 
                    Description="Baguettes", 
                    Oee = 70.0D, 
                    OeeTarget = 85.0D, 
                    CurrentStatus = Line.StatusEnum.Running
                },
                new Line{
                    LineId=3, 
                    LineName="Line 3", 
                    Description="Pizza crusts", 
                    Oee = 88.0D, 
                    OeeTarget = 85.0D, 
                    CurrentStatus = Line.StatusEnum.Stopped
                },
            };

        public IEnumerable<Line> GetLineById(int LineId)
        {
            return AllLines.Where(l => l.LineId == LineId);
        }

    }
}
