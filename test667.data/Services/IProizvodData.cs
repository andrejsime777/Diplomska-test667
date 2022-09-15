using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test667.data.Models;

namespace test667.data.Services
{
    public interface IProizvodData
    {
        IEnumerable<Proizvod> GetAll();
        Proizvod Get(int id);
        void Add(Proizvod proizvod);
        void Update(Proizvod proizvod);
        void Delete(int id);
    }
}
