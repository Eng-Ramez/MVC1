using System.ComponentModel.DataAnnotations;

namespace Session1.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage =" Requierd!!!? ")]
        [MaxLength(20)]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(8)]
        public string Description { get; set; } = string.Empty;// لضمان انها دائما تحوي قميه

    }
}
