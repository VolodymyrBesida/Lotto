using TestTaskOnSea.Models;
using TestTaskOnSea.Strategy.Interfaces;

namespace TestTaskOnSea.Strategy
{
    #region Public Class HorizontalWinningWay
    public class HorizontalWinningway : IWinningWay
    {
        #region Public Methods
        public void showWinningWay(List<Point> Coordinates, PointGrid target, int maxRow, int maxCol)
        {
            for (int i = 0; i < maxCol; i++)
            {
                var point = Coordinates
                            .Where(cord => cord.X == target.X && cord.Y == i)
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
