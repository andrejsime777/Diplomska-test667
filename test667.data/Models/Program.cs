using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test667.data.Models
{
    public class Program
    {
        public int Id { get; set; }

        [Display(Name = "Име")]
        public string Ime { get; set; }

        [Display(Name = "Линк")]
        public string Link { get; set; }


        [Display(Name = "Категорија")]
        public Kategorija_Programi kategorija_programi { get; set; }
        public int kategorija_programi_KategorijaId { get; set; }
    }
}
