using System.ComponentModel.DataAnnotations;

namespace MakeYourself.Models
{
    public class TrainDay
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CalendarId { get; set; }

        [Required]
        public int ExerciseId { get; set; }

        [Required]
        public sbyte GoalReps { get; set; }

        public sbyte ActualReps { get; set; }

        public Calendar Calendar { get; set; }

        public Exercise Exercise { get; set; } 
    }
}
