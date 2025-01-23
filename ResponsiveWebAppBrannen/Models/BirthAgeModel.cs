using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace ResponsiveWebAppBrannen.Models
{
    public class BirthAgeModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        //allows for the user to only enter letters for the name
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please only use letters for your name.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your birth year.")]
        [Range(1, 2024, ErrorMessage = "Birth of year must be between the year of 1 and 2024.")]
        public int? BirthYear { get; set; }
        //Method getting the age of the user in a simple way
        public string? ageThisYear()
        {
            const int currentYear = 2025;
            int age = currentYear - BirthYear.Value;
            return Name + " will be " + age + " by Dec 31st of this year.";
        }
    }
}
