using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Services.ServiceModels
{
    public class BookViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("PubDate")]
        public DateTime PubDate { get; set; }

        [JsonPropertyName("author")]
        [Required(ErrorMessage = "Author is required.")]
        public int Author { get; set; }
    }
}