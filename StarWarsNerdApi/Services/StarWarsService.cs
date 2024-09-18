using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using StarWarsNerdApi.Models;

namespace StarWarsNerdApi.Services
{
    public class StarWarsService : IStarWarsService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://swapi.dev/api/";

        public StarWarsService(HttpClient httpClient) => _httpClient = httpClient;

        public async Task<IEnumerable<Film>> GetFilmsAsync()
        {
            var response = await _httpClient.GetStringAsync($"{BaseUrl}films/");
            var result = JsonSerializer.Deserialize<StarWarsApiResponse<Film>>(response);
            return result.Results;
        }

        public async Task<IEnumerable<Person>> GetPeopleAsync()
        {
            var response = await _httpClient.GetStringAsync($"{BaseUrl}people/");
            var result = JsonSerializer.Deserialize<StarWarsApiResponse<Person>>(response);
            return result.Results;
        }

        public async Task<IEnumerable<Starship>> GetStarshipsAsync()
        {
            var response = await _httpClient.GetStringAsync($"{BaseUrl}starships/");
            var result = JsonSerializer.Deserialize<StarWarsApiResponse<Starship>>(response);
            return result.Results;
        }
    }

    public class StarWarsApiResponse<T>
    {
        [JsonPropertyName("results")]
        public IEnumerable<T> Results { get; set; }
    }
}
