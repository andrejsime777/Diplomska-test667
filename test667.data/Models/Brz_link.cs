using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test667.data.Models
{
    public class Brz_link
    {
        public int Id { get; set; }

        [Display(Name = "Име")]
        [Required]
        public string Ime { get; set; }

        [Display(Name = "Линк")]
        public string Link { get; set; }
    }
}
