namespace TestTaskOnSea.Models.Pointable.Streakerable
{
    #region Public Class Streaker
    public class Streaker : AbsStreaker
    {
        #region Constructors
        public Streaker()
        {
            isStreak = false;
            isDiagonalStreak = false;
            isVerticalStreak = false;
            isHorizontalStreak = false;
            isWin = false;
        }
        public Streaker(bool isWin) => this.isWin = isWin;
        public Streaker(bool isStreak, bool isDiagonalStreak, bool isVerticalStreak, bool isHorizontalStreak, bool isWin)
        {
            this.isStreak = isStreak;
            this.isDiagonalStreak = isDiagonalStreak;
            this.isVerticalStreak = isVerticalStreak;
            this.isHorizontalStreak = isHorizontalStreak;
            this.isWin = isWin;
        }
        #endregion
    }
    #endregion
}
