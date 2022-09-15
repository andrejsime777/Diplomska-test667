using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test667.data.Models;

namespace test667.data.Services
{
    public class InMemoryKategorijaProgramiData : IKategorijaProgramiData
    {
        public IEnumerable<Kategorija_Programi> SiteKategorii =>
            new List<Kategorija_Programi>
            {
                new Kategorija_Programi{KategorijaId = 1, KategorijaIme = "Програми за заштита"},
                new Kategorija_Programi{KategorijaId = 2, KategorijaIme = "Програми за исхрана"},
                new Kategorija_Programi{KategorijaId = 3, KategorijaIme = "Програми за заштита и исхрана"}
            };

        public void Add(Kategorija_Programi kategorija)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Kategorija_Programi Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Kategorija_Programi kategorija)
        {
            throw new NotImplementedException();
        }
    }
}
