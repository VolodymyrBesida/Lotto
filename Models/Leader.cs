namespace TestTaskOnSea.Models
{
    #region Public Class Leader
    public class Leader
    {
        #region Public Attributes
        public int MaxRandomNumber { get; set; }
        public int WinNumber { get; set; }
        #endregion
        #region Constructor
        public Leader(int maxRandomNumber)
        {
            MaxRandomNumber = maxRandomNumber;
        }
        #endregion
        #region Public Methods
        public void ChooseNumber()
        {
            Random randomizer = new Random();
            this.WinNumber = randomizer.Next(1, this.MaxRandomNumber);
        }
        #endregion
    }
    #endregion
}
