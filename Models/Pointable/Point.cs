using TestTaskOnSea.Models.Pointable.Streakerable;

namespace TestTaskOnSea.Models.Pointable
{
    #region Public Class Point
    public class Point : PointGrid
    {
        #region Public Attributes
        public PointGrid? Position { get; set; }
        public int Value { get; set; }
        public Streaker Streaker { get; set; }
        #endregion
        #region Constructors
        public Point(int x, int y)
            : base(x, y) => this.Streaker = new Streaker();
        public Point(int x, int y, int value, bool isWin)
            : base(x, y)
        {
            Value = value;
            this.Streaker = new Streaker();
            this.Streaker.isWin = isWin;
        }
        #endregion
    }
    #endregion
}
