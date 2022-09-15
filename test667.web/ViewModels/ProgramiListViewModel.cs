using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test667.data.Models;

namespace test667.web.ViewModels
{
    public class ProgramiListViewModel
    {
        public IEnumerable<Program> Programi { get; set; }
        public string CurrentCategory { get; set; }

        public IEnumerable<Kategorija_Programi> Kategorija { get; set; }
    }
}