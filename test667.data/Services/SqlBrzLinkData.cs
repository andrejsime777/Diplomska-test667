using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test667.data.Models;

namespace test667.data.Services
{
    public class SqlBrzLinkData : IBrzLinkData
    {
        private readonly test667DbContext db;

        public SqlBrzLinkData(test667DbContext db)
        {
            this.db = db;
        }

        public void Add(Brz_link brz_link)
        {
            db.Brzi_linkovi.Add(brz_link);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var brzLink = db.Brzi_linkovi.Find(id);
            db.Brzi_linkovi.Remove(brzLink);
            db.SaveChanges();
        }

        public Brz_link Get(int id)
        {
            return db.Brzi_linkovi.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Brz_link> GetAll()
        {
            return from b in db.Brzi_linkovi
                   orderby b.Ime
                   select b;
        }

        public void Update(Brz_link brz_link)
        {
            var entry = db.Entry(brz_link);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
