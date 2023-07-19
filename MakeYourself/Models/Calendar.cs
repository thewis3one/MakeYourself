using System.ComponentModel.DataAnnotations;

namespace MakeYourself.Models
{
    public class Calendar
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int ClientId { get; set; }

        public Client Clients { get; set; }

        public IEnumerable<TrainDay> TrainDays { get; set; }

    }
}
