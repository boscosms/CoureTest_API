using CoureTest_API.Data;
using CoureTest_API.Interfaces;
using CoureTest_API.Models;
using CoureTest_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class CountryController : ControllerBase
{
    private readonly ICountryService _countryService;

    public CountryController(ICountryService countryService)
    {
        _countryService = countryService ?? throw new ArgumentNullException(nameof(countryService));
        countryService = _countryService;
    }

    [HttpGet]
    public IActionResult GetCountryDetails(string phoneNumber)
    {
        try
        {
            var (country, countryDetails) = _countryService.GetCountryDetails(phoneNumber);

            // Concatenate a plus sign to the phoneNumber
            string formattedPhoneNumber = "+" + phoneNumber;
            var result = new
            {
                number = formattedPhoneNumber,
                country = new
                {
                    countryCode = country.CountryCode,
                    name = country.Name,
                    countryIso = country.CountryIso,
                    countryDetails = countryDetails
                }
            };

            return Ok(result);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            return NotFound(ex.Message);
        }
    }
}
