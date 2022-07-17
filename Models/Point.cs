namespace TestTaskOnSea.Models
{
    #region Public Class Point
    public class Point
    {
        #region Public Attributes
        public int X { get; set; }
        public int Y { get; set; }
        public int Value { get; set; }
        public bool isStreak { get; set; } = false;
        public bool isWin { get; set; } = false;
        #endregion
        #region Constructors
        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }
        public Point(int x, int y, int value, bool isWin)
        {
            X = x;
            Y = y;
            Value = value;
            this.isWin = isWin;
        }
        #endregion
    }
    #endregion
}
