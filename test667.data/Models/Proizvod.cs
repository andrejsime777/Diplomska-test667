using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test667.data.Models
{
    public class Proizvod
    {
        public int Id { get; set; }
        [Display(Name = "Име")]
        [Required]
        public string ime { get; set; }

        [Display(Name = "Краток опис")]
        public string kratok_opis { get; set; }

        [Display(Name = "Долг опис")]
        public string dolg_opis { get; set; }

        [Display(Name = "Слика")]
       /* [DataType(DataType.ImageUrl)]*/
        public string slika { get; set; }
        [Display(Name = "Линк за проспект")]
        [DataType(DataType.Url)]
        public string prospekt_link { get; set; }

        [Display(Name = "Линк за упатство")]
        [DataType(DataType.Url)]
        public string upatstvo_link { get; set; }

        [Display(Name ="Цена (во денари)")]
        public decimal Cena { get; set; }

        [Display(Name ="Залиха")]
        public bool Zaliha { get; set; }

        [Display(Name ="Категорија")]
        public Kategorija kategorija { get; set; }

    }
}
