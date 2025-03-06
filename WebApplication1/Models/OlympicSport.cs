namespace WebApplication1.Models
{
    public class OlympicSport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Game { get; set; }
        public string Sport { get; set; }
        public string Category { get; set; }
        public string CountryCode { get; set; }
        public string FlagUrl => $"https://flagcdn.com/w80/{CountryCode}.png";
       
        
    }
}