using System.Text.Json.Serialization;

namespace StarWarsNerdApi.Models
{
    public class Film {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("director")]
        public string Director { get; set; }
    }

    public class Person {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("birth_year")]
        public string BirthYear { get; set; }
    }

    public class Starship {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("model")]
        public string Model { get; set; }
    }
}
