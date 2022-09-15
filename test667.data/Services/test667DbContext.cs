using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test667.data.Models;

namespace test667.data.Services
{
    public class test667DbContext : DbContext
    {
        public DbSet<Proizvod> Proizvodi { get; set; }
        public DbSet<Brz_link> Brzi_linkovi { get; set; }
        public DbSet<Program> Programi { get; set; }
        public DbSet<Kategorija_Programi> kategorija_Programi { get; set; }
    }
}
