using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test667.data.Models;

namespace test667.data.Services
{
    public class InMemoryBrzLinkData : IBrzLinkData
    {
        List<Brz_link> brzi_linkovi;

        public InMemoryBrzLinkData()
        {
            brzi_linkovi = new List<Brz_link>()
            {
                new Brz_link {Id = 1, Ime = "Yara", Link = "https://www.yara.com/crop-nutrition/products-and-solutions/"},
                new Brz_link {Id = 2, Ime = "Hazera", Link = "https://www.hazera.com/"},
                new Brz_link {Id = 3, Ime = "Adama", Link = "http://www.adama.com/en/"}
            };
        }

        public void Add(Brz_link brz_link)
        {
            brzi_linkovi.Add(brz_link);
            brz_link.Id = brzi_linkovi.Max(b => b.Id) + 1;
        }

        public void Delete(int id)
        {
            var brz_link = Get(id);
            if(brz_link != null)
            {
                brzi_linkovi.Remove(brz_link);
            }
        }

        public Brz_link Get(int id)
        {
            return brzi_linkovi.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Brz_link> GetAll()
        {
            return brzi_linkovi.OrderBy(b => b.Ime);
        }

        public void Update(Brz_link brz_link)
        {
            var existing = Get(brz_link.Id);
            if(existing != null)
            {
                existing.Ime = brz_link.Ime;
                existing.Link = brz_link.Link;
            }
        }
    }
}
