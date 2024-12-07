using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaziFeladat3.Models
{
    public class Pet
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        [Range(0, 200)]
        public int Age { get; set; }
        [Required]
        [Range(0,200)]
        public double Weight { get; set; }
        [Required]
        public string PhotoURL { get; set; }
        [Required]
        [ForeignKey("ReferencedCategory")]
        public int CategID { get; set; }

        public virtual Category ReferencedCategory { get; set; }

    }
}
