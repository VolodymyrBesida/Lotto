using TestTaskOnSea.Models.Pointable;

namespace TestTaskOnSea.Strategy.Interfaces
{
    public interface IWinningWay
    {
        void showWinningWay(List<Point> Coordinates, PointGrid target, int maxRow, int maxCol);
    }
}
