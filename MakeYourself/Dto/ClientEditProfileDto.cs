using System.ComponentModel.DataAnnotations;

namespace MakeYourself.Dto
{
    public class ClientEditProfileDto
    {
        [Required]
        public string FIO { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public double Weight { get; set; }

        [Required]
        public double Height { get; set; }

        [Required]
        public int BuildTypeId { get; set; }
    }
}
