using TestTaskOnSea.Models.Interfaces;
using TestTaskOnSea.Strategy;
using TestTaskOnSea.Strategy.Interfaces;

namespace TestTaskOnSea.Models
{
    #region Public Class Grid2
    public class Grid2 : IGridable
    {
        #region Public Attributes
        public List<Point> Row { get; set; }
        public IWinningWay? WinWay { get; set; }
        public PointGrid MaxPosition { get;private set; }
        public int MaxRandom { get; private set; }
        #endregion
        #region Private Attributes
        private int _winNumber { get; set; }
        #endregion
        #region Constructor
        public Grid2(int maxRow,int maxCol, int maxRandom,int winNumber)
        {
            MaxPosition = new Point(maxRow, maxRow);
            Row = new List<Point>();
            MaxRandom = maxRandom;
            _winNumber = winNumber;
        }
        #endregion
        #region Public Methods
        public void CreateField()
        {
            Random randomizer = new Random();
            List<int> hasList = new List<int>();
            for (int i = 0; i < this.MaxPosition.X; i++)
            {
                for (int j = 0; j < this.MaxPosition.Y; j++)
                {
                    int randomInt = randomizer.Next(1, MaxRandom);
                    while (hasList.Contains(randomInt))
                        randomInt = randomizer.Next(1, MaxRandom);
                    hasList.Add(randomInt);
                    Row.Add(new Point(i, j, randomInt, randomInt == _winNumber ? true : false));
                }
            }
        }
        #endregion
    }
    #endregion
}
