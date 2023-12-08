using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASI.Basecode.Services.ServiceModels
{
    public class ReviewViewModel
    {
        [JsonPropertyName("id")]
        [Required(ErrorMessage = "Review Id is required.")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        [Required(ErrorMessage = "Reviewer name is required.")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        [Required(ErrorMessage = "Reviewer email is required.")]
        public string Email { get; set; }

        [JsonPropertyName("content")]
        [Required(ErrorMessage = "Review content is required.")]
        public string Content { get; set; }

        [JsonPropertyName("rating")]
        [Required(ErrorMessage = "Rating is required"), Range(1, 5)]
        public int Rating { get; set; }

        [JsonPropertyName("bookId")]
        [Required(ErrorMessage = "Book Id is required.")]
        public string BookId { get; set; }

        [JsonPropertyName("dateReviewed")]
        [Required(ErrorMessage = "Review date is required.")]
        public DateTime DateReviewed { get; set; }
    }
}