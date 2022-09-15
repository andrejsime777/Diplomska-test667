using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test667.data.Models;

namespace test667.data.Services
{
    public interface IKategorijaProgramiData
    {
        IEnumerable<Kategorija_Programi> SiteKategorii { get; }
        Kategorija_Programi Get(int id);
        void Add(Kategorija_Programi kategorija);
        void Update(Kategorija_Programi kategorija);
        void Delete(int id);
    }
}
