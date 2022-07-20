using TestTaskOnSea.Models.Pointable;
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
                var centralPoint = Coordinates
                            .Where(cord => cord.X == target.X && cord.Y == i)
                            .FirstOrDefault();
                if (centralPoint == null)
                    break;
                centralPoint.Streaker.isStreak = true;
                centralPoint.Streaker.isHorizontalStreak = true;
            }
        }
        #endregion
    }
    #endregion
}
