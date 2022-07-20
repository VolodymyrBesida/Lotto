using TestTaskOnSea.Models.Pointable;

namespace TestTaskOnSea.Models.Interfaces
{
    public interface IHighlitable
    {
        void Highlit(List<Point> Coordinates, int maxRow, int maxCol);
    }
}
