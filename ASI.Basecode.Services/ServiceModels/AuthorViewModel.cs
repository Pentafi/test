using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Services.Models
{
    public class AuthorViewModel
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("FirstName")]
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [JsonPropertyName("LastName")]
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }
    }
}