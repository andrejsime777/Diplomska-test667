using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test667.data.Models
{
    public enum Kategorija
    {
        [Display(Name = "Нема категорија")]
        None,
        [Display(Name = "Системи за наводнување")]
        Sistem_navodnuvanje,
        [Display(Name = "Исхрана на растенија")]
        Ishrana_Rastenija,
        [Display(Name = "Заштита на растенија")]
        Zastita_Rastenija,
        [Display(Name = "Семиња")]
        seminja,
        [Display(Name = "Садници")]
        sadnici
    }


}
