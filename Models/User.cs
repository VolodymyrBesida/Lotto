using System.ComponentModel.DataAnnotations;
using TestTaskOnSea.Models.Interfaces;

namespace TestTaskOnSea.Models
{
    #region Public Class User
    public class User : Person,IUser
    {
        #region Public Attributes
        [Key]
        public int Id { get; set; }
        [StringLength(100,MinimumLength = 5)]
        public string? Login { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [StringLength(16, ErrorMessage = "Must be between 5 and 50 characters", MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Your email doesn't match pattern")]
        public string Email { get; set; }
        #endregion
    }
    #endregion
}
