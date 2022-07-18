namespace TestTaskOnSea.Models
{
    #region Public Class PointGrid
    public abstract class PointGrid
    {
        #region Public Attributes
        public int X { get; set; }
        public int Y { get; set; }
        #endregion
        #region Constructor
        public PointGrid(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion
    }
    #endregion
}
