using System.ComponentModel.DataAnnotations;

namespace MakeYourself.Models
{
    public class Physique
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public IEnumerable<Client> Clients { get; set; }
    }
}
