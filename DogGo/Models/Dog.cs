using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Models
{
    public class Dog
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Hmmm... You should really add a Name...")]
        [MaxLength(35)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Hmmm... You should really add a Breed...")]
        public string Breed { get; set; }


        [Required]
        [DisplayName("Owner")]
        public int OwnerId { get; set; }
        
        
        public string ImageUrl { get; set; }
        
        
        public Owner Owner { get; set; }

        [Required]
        public string Notes { get; set; }
    }
}
