using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ContactsMultiPage.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name for the contact.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please only use letters for your name.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter a phone number for the contact.")]
        [RegularExpression(@"^\s*\+?\s*([0-9][\s-]*){9,}$", ErrorMessage = "Please format phone as - 111-111-111 or 222 222 2222.")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Please enter an address for the contact")]
        [RegularExpression(@"\d+[ ](?:[A-Za-z0-9.-]+[ ]?)+(?:Avenue|Lane|Road|Boulevard|Drive|Street|Ave|Dr|Rd|Blvd|Ln|St|Place|Pl).?", ErrorMessage = "Please format address as - 123 Living Lane.")]
        public string? Address { get; set; }

        public string Note { get; set; }
    }
}
