using System.ComponentModel.DataAnnotations;

namespace Commander.models
{
    public class Command 
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line {get; set; }

        [Required]
        public string Platfrom { get; set; }
    }
}