namespace TestTaskOnSea.Models.Pointable.Streakerable
{
    #region Public Abstract Class AbsStreaker
    public abstract class AbsStreaker
    {
        #region Public Attributes
        public bool isStreak { get; set; }
        public bool isDiagonalStreak { get; set; }
        public bool isVerticalStreak { get; set; }
        public bool isHorizontalStreak { get; set; }
        public bool isWin { get; set; }
        #endregion
    }
    #endregion
}
