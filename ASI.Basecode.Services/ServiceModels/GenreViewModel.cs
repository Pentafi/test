using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Services.Models
{

    public class GenreViewModel
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        [Required(ErrorMessage = "Genre Name is required.")]
        public string Name { get; set; }
    }
}