using System.ComponentModel.DataAnnotations;

namespace MakeYourself.Dto
{
    public class ClientRegistrationDto
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
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public int BuildTypeId { get; set; }
    }
}
