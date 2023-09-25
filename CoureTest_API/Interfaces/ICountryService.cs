using CoureTest_API.Models;

namespace CoureTest_API.Interfaces
{
    public interface ICountryService
    {
        (Country country, List<CountryDetails> countryDetails) GetCountryDetails(string phoneNumber);
    }
}
