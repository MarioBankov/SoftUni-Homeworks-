using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Milions.Models
{
    public class Milion
    {
       
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int EyeCountP { get; set; }
    }
}
