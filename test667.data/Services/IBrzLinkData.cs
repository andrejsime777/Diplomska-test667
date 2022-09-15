using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test667.data.Models;

namespace test667.data.Services
{
    public interface IBrzLinkData
    {
        IEnumerable<Brz_link> GetAll();
        Brz_link Get(int id);
        void Add(Brz_link brz_link);
        void Update(Brz_link brz_link);
        void Delete(int id);
    }
}
