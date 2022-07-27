using System.ComponentModel.DataAnnotations;

namespace TestTaskOnSea.Models
{
    #region Public Abstract Class Person
    public abstract class Person
    {
        #region Public Attributes
        
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Age { get; set; }
        #endregion
    }
    #endregion
}
