namespace CoureTest_API.Models
{
    // Country.cs
    public class Country
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }

        public IList<CountryDetails> Details { get; set; }
    }

    // CountryDetails.cs
    public class CountryDetails
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
    }

   

}
