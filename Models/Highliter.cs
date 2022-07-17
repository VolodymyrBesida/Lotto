using TestTaskOnSea.Strategy;
using TestTaskOnSea.Strategy.Interfaces;

namespace TestTaskOnSea.Models
{
    #region Public Class Highliter
    public class Highliter
    {
        #region Public Attributes
        public IWinningWay WinWay { get; set; }
        private Point target { get; set; }
        #endregion
        #region Constructor
        public Highliter(IWinningWay winWay,Point winCoordinate)
        {
            WinWay = winWay;
            target = winCoordinate;
        }
        #endregion
        #region Public Methods
        public void Highlit(List<Point> Coordinates,int maxRow,int maxCol)
        {
            this.WinWay = new DiagonalWinningWay();
            //this.WinWay = new HorizontalWinningway();
            //this.WinWay = new VerticalWinningWay();
            this.WinWay.showWinningWay(Coordinates,target,maxRow,maxCol);
        }
        #endregion
    }
    #endregion
}
