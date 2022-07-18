using TestTaskOnSea.Models;
using TestTaskOnSea.Strategy.Interfaces;

namespace TestTaskOnSea.Strategy
{
    #region Public Class DiagonalWinningWay
    public class DiagonalWinningWay : IWinningWay
    {
        #region Private Methods
        private int calculateCentralPoint(List<Point> coordinates)
        {
            int totalX = 0;
            foreach (var coord in coordinates)
                totalX += coord.X;

            return totalX / coordinates.Count;
        }

        private List<Point> calculatePrincipleLine(List<Point>coordinates,int maxCol)
        {
            List<Point> primaryLine = new List<Point>();
            for (int i = 0; i < maxCol; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    if (i == j)
                    {
                        var checkPoint = coordinates
                                    .Where(cord => cord.X == i && cord.Y == j)
                                    .FirstOrDefault();
                        if (checkPoint != null)
                            primaryLine.Add(checkPoint);
                    }
                }
            }
            return primaryLine;
        }

        private List<Point> calculateSecondaryLine(List<Point>coordinates,int maxCol)
        {
            List<Point> secondary = new List<Point>();
            for (int i = 0; i < maxCol; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    if ((i + j) == (maxCol - 1))
                    {
                        var checkPoint = coordinates
                                    .Where(cord => cord.X == i && cord.Y == j)
                                    .FirstOrDefault();
                        if(checkPoint != null)
                            secondary.Add(checkPoint);
                    }
                }
            }
            return secondary;
        }

        private void setStreakInLine(List<Point>lineCoordinates, PointGrid target)
        {
            bool isHasTarget = false;
            foreach (var point in lineCoordinates)
            {
                if (point.X == target.X && point.Y == target.Y)
                {
                    isHasTarget = true;
                }
            }
            if (isHasTarget)
            {
                foreach (var point in lineCoordinates)
                    point.isStreak = true;
            }
        }
        #endregion
        #region Public Methods
        public void showWinningWay(List<Point> Coordinates, PointGrid target, int maxRow, int maxCol)
        {
            int centralCoordinate = calculateCentralPoint(Coordinates);

            var point = Coordinates
                           .Where(cord => cord.X == centralCoordinate && cord.Y == centralCoordinate)
                           .FirstOrDefault();
            if (point != null)
            {
                List<Point> principle = calculatePrincipleLine(Coordinates,maxCol);
                List<Point> second = calculateSecondaryLine(Coordinates, maxCol);
                
                setStreakInLine(principle, target);
                setStreakInLine(second, target);
            }
        }
        #endregion
    }
    #endregion
}