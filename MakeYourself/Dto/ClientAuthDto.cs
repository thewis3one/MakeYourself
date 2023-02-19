using System.ComponentModel.DataAnnotations;

namespace MakeYourself.Dto
{
    public class ClientAuthDto
    {
        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
