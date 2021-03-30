using System.Collections.Generic;
using System.Threading.Tasks;
using ChunkysPieShopHRM.Shared;

namespace ChunkysPieShopHRM.App.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
