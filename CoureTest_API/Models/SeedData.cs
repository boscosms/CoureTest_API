using CoureTest_API.Data;

namespace CoureTest_API.Models
{
    public static class SeedData
    {
        public static void Seed(DataContext context)
        {
            // Just checking if the data exists 
            if (context.Countries.Any() || context.CountryDetails.Any())
            {
                return;
            }

            // Here I added the countries
            var countries = new List<Country>
        {
            new Country { CountryCode = "234", Name = "Nigeria", CountryIso = "NG" },
            new Country { CountryCode = "233", Name = "Ghana", CountryIso = "GH" },
            new Country { CountryCode = "229", Name = "Benin Republic", CountryIso = "BN" },
            new Country { CountryCode = "225", Name = "Côte d'Ivoire", CountryIso = "CIV" },

        };

            context.Countries.AddRange(countries);

            var countryDetails = new List<CountryDetails>
        {
            new CountryDetails { CountryId = 1, Operator = "MTN Nigeria", OperatorCode = "MTN NG" },
            new CountryDetails { CountryId = 1, Operator = "Airtel Nigeria", OperatorCode = "ANG" },
            new CountryDetails { CountryId = 1, Operator = "9 Mobile Nigeria", OperatorCode = "ETN" },
            new CountryDetails { CountryId = 1, Operator = "Globacom Nigeria", OperatorCode = "GLO NG" },
            new CountryDetails { CountryId = 2, Operator = "Vodafone Ghana", OperatorCode = "Vodafone GH" },
            new CountryDetails { CountryId = 2, Operator = "MTN Ghana", OperatorCode = "MTN Ghana" },
            new CountryDetails { CountryId = 2, Operator = "Tigo Ghana", OperatorCode = "Tigo Ghana" },
            new CountryDetails { CountryId = 3, Operator = "MTN Benin", OperatorCode = "MTN Benin" },
            new CountryDetails { CountryId = 3, Operator = "Moov Benin", OperatorCode = "Moov Benin" },
            new CountryDetails { CountryId = 4, Operator = "MTN Côte d'Ivoire", OperatorCode = "MTN CIV" },
        };

            context.CountryDetails.AddRange(countryDetails);

            context.SaveChanges();
        }
    }


}
