using System.ComponentModel.DataAnnotations;

namespace ServerApi.Models
{
    public class UserDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Username { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        // Các thuộc tính khác của người dùng
    }
}
