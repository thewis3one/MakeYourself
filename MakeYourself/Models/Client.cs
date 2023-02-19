using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakeYourself.Models
{
    public class Client : IEntityTypeConfiguration<Client>
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FIO { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public double Weight { get; set; }

        [Required]
        public double Height { get; set; }

        [Required]
        public int PhysiqueId { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        public Physique Physique { get; set; }

        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .Property(x => x.Password)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(30);

            builder.HasOne(x => x.Physique)
                .WithMany(x => x.Clients)
                .HasForeignKey(x => x.PhysiqueId);

            builder
                .Property(x => x.Height)
                .HasPrecision(3, 2);
        }
    }
}
