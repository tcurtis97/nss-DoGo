using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Models
{
    public class Walk
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime Date { get; set; }

        [Required]
        public int Duration { get; set; }


        [Required]
        [DisplayName("Walker")]
        public int WalkerId { get; set; }

        [Required]
        [DisplayName("Dog")]
        public int DogId { get; set; }

        
        
        public string Client { get; set; }


    }
}
