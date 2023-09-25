using System;
using System.Collections.Generic;
using System.Linq;
using CoureTest_API.Data;
using CoureTest_API.Interfaces;
using CoureTest_API.Models;
using Microsoft.EntityFrameworkCore;
namespace CoureTest_API.Services
{
    public class CountryService : ICountryService
    {
        private readonly DataContext _context;

        public CountryService(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public (Country country, List<CountryDetails> countryDetails) GetCountryDetails(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                throw new ArgumentException("Invalid number! Phone number is empty.");
            }

            string countryCode = phoneNumber.Substring(0, 3);
            Country country = _context.Countries.Include(x => x.Details).FirstOrDefault(c => c.CountryCode == countryCode);

            if (country == null)
            {
                throw new InvalidOperationException("Country not found");
            }

            List<CountryDetails> countryDetails = country.Details.ToList();

            return (country, countryDetails);
        }
    }
}
