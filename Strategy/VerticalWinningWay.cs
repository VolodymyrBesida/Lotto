using TestTaskOnSea.Models;
using TestTaskOnSea.Strategy.Interfaces;

namespace TestTaskOnSea.Strategy
{
    #region Public Class VerticalWinningway
    public class VerticalWinningWay : IWinningWay
    {
        #region Public Methods
        public void showWinningWay(List<Point> Coordinates, Point target, int maxRow,int maxCol)
        {
            for (int i = 0; i < maxRow; i++)
            {
                var point = Coordinates
                            .Where(cord => cord.X == i && cord.Y == target.Y)
                            .FirstOrDefault();
                if (point == null)
                    break;
                point.isStreak = true;
            }
        }
        #endregion
    }
    #endregion
}
