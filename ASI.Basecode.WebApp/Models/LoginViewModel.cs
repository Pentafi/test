using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ASI.Basecode.WebApp.Models
{
    /// <summary>
    /// Login View Model
    /// </summary>
    public class LoginViewModel
    {
 
        [JsonPropertyName("email")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [JsonPropertyName("userid")]
        [Required(ErrorMessage = "UserId is required.")]
        public string UserId { get; set; }

        [JsonPropertyName("password")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
}