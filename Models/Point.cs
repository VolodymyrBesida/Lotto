namespace TestTaskOnSea.Models
{
    #region Public Class Point
    public class Point : PointGrid
    {
        #region Public Attributes
        public PointGrid? Position { get; set; }
        public int Value { get; set; }
        public bool isStreak { get; set; } = false;
        public bool isWin { get; set; } = false;
        #endregion
        #region Constructors
        public Point(int x,int y) 
            : base(x, y) { }
        public Point(int x, int y, int value, bool isWin)
            : base(x, y)
        {
            Value = value;
            this.isWin = isWin;
        }
        #endregion
    }
    #endregion
}
