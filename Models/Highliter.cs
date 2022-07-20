using TestTaskOnSea.Strategy;
using TestTaskOnSea.Strategy.Interfaces;
using TestTaskOnSea.Models.Pointable;
using TestTaskOnSea.Models.Interfaces;

namespace TestTaskOnSea.Models
{
    #region Public Class Highliter
    public class Highliter : IHighlitable
    {
        #region Public Attributes
        public IWinningWay WinWay { get; set; }
        #endregion
        #region Private Attributes
        private Point target { get; set; }
        private IEnumerable<IWinningWay> WinChain { get; set; }
        #endregion
        #region Constructor
        public Highliter(IWinningWay winWay,Point winCoordinate)
        {
            WinWay = winWay;
            target = winCoordinate;
            this.WinChain = new List<IWinningWay>()
            {
                new DiagonalWinningWay(),
                new HorizontalWinningway(),
                new VerticalWinningWay()
            };
        }
        #endregion
        #region Private Mathods
        private void chainableCall(IEnumerable<IWinningWay>winningWays,IEnumerable<Point>Coordinates,int maxRow,int maxCol)
        {
            foreach(var winningWay in winningWays)
            {
                this.WinWay = winningWay;
                this.WinWay.showWinningWay(Coordinates.ToList(), target, maxRow, maxCol);
            }
        }
        #endregion
        #region Public Methods
        public void Highlit(List<Point> Coordinates,int maxRow,int maxCol)
            => chainableCall(this.WinChain, Coordinates, maxRow, maxCol);
        #endregion
    }
    #endregion
}
