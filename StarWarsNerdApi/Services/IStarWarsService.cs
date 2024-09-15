using StarWarsNerdApi.Models;

namespace StarWarsNerdApi.Services
{
    public interface IStarWarsService
    {
        Task<IEnumerable<Film>> GetFilmsAsync();
        Task<IEnumerable<Person>> GetPeopleAsync();
        Task<IEnumerable<Starship>> GetStarshipsAsync();
    }
}
