using System.ComponentModel.DataAnnotations;

namespace TestTaskOnSea.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
