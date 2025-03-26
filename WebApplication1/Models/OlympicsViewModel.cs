namespace WebApplication1.Models
{
    public class OlympicsViewModel
    {
        public List<OlympicSport> Countries { get; set; } = new List<OlympicSport>();
        public List<string> Games { get; set; } = new List<string> { "ALL" };
        public List<string> Categories { get; set; } = new List<string> { "ALL" };
        public string SelectedGame { get; set; } = "ALL";
        public string SelectedCategory { get; set; } = "ALL";
    }
}
