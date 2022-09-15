using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace test667.data.Models
{
    public class Kategorija_Programi
    {
        [Key]
        public int KategorijaId { get; set; }

        [Display(Name = "Име на категорија")]
        public string KategorijaIme { get; set; }


        public List<Program> Programi { get; set; }
    }
}