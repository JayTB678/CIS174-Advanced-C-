using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApplication.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a sprint number with at least a value of 1.")]
        public int SprintNumber { get; set; }
        [Range(1, 50, ErrorMessage = "Please enter a point number between 1 and 50")]
        public int PointValue { get; set; }
        [Required]
        public int TicketStatusId { get; set; }
        [ForeignKey("TicketStatusId")]
        public TicketStatus? Status { get; set; }
    }

}
