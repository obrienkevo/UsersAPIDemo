using System.ComponentModel.DataAnnotations;

namespace UsersAPIDemo.Models
{
    public class User
    {
        [Key]
        [Required]
        public int UserID { get; set; }
        [Required]
        [MaxLength(80)]
        public string Username { get; set; }
        [Required]
        [MaxLength(250)]
        public string Email { get; set; }
    }
}