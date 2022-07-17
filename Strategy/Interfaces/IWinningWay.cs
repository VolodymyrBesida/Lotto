using TestTaskOnSea.Models;

namespace TestTaskOnSea.Strategy.Interfaces
{
    public interface IWinningWay
    {
        void showWinningWay(List<Point> Coordinates, Point target, int maxRow, int maxCol);
    }
}
