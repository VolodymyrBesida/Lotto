using TestTaskOnSea.Models.Pointable;
using TestTaskOnSea.Strategy.Interfaces;

namespace TestTaskOnSea.Strategy
{
    #region Public Class DiagonalWinningWay
    public class DiagonalWinningWay : IWinningWay
    {
        #region Private Methods
        //necessary method for getting central point of game field
        private int calculateCentralPoint(List<Point> coordinates)
        {
            int totalX = 0;
            foreach (var coord in coordinates)
                totalX += coord.X;

            return totalX / coordinates.Count;
        }
        //calculating from top left side to bottom right
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
        //calculating from top right side to left bottom
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
        //we're using this method  to draw line in our coordinates in each line
        private void setStreakInLine(List<Point>lineCoordinates, PointGrid target)
        {
            bool isHasTarget = false;
            //check if our array has target point
            foreach (var point in lineCoordinates)
            {
                if (point.X == target.X && point.Y == target.Y)
                {
                    isHasTarget = true;
                }
            }
            if (isHasTarget) // if we have, we should say that our line is streakable
            {
                foreach (var point in lineCoordinates)
                {
                    point.Streaker.isStreak = true;
                    point.Streaker.isDiagonalStreak = true;
                }
                    
            }
        }
        #endregion
        #region Public Methods
        public void showWinningWay(List<Point> Coordinates, PointGrid target, int maxRow, int maxCol)
        {
            int centralCoordinate = calculateCentralPoint(Coordinates);
            //getting central point
            var centralPoint = Coordinates
                           .Where(cord => cord.X == centralCoordinate && cord.Y == centralCoordinate)
                           .FirstOrDefault();
            if (centralPoint != null)
            {
                //getting each type of lines
                List<Point> principle = calculatePrincipleLine(Coordinates,maxCol);
                List<Point> second = calculateSecondaryLine(Coordinates, maxCol);
                //here we gonna check each line if target point is present there
                setStreakInLine(principle, target);
                setStreakInLine(second, target);
            }
        }
        #endregion
    }
    #endregion
}