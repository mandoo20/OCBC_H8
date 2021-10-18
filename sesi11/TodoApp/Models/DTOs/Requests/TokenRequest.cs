using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models.DTOs.Request
{
    public class TokenRequest
    {
        [Required]
        public string Token { get; set; }

        [Required]
        public string RefreshToken { get; set; }
    }
}