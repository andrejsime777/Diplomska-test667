using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test667.data.Models;

namespace test667.data.Services
{
    public class SqlKategorijaProgramiData : IKategorijaProgramiData
    {
        private readonly test667DbContext db;

        public SqlKategorijaProgramiData(test667DbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Kategorija_Programi> SiteKategorii => db.kategorija_Programi;


        public void Add(Kategorija_Programi kategorija)
        {
            db.kategorija_Programi.Add(kategorija);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var kategorija = db.kategorija_Programi.Find(id);
            db.kategorija_Programi.Remove(kategorija);
            db.SaveChanges();
        }

        public Kategorija_Programi Get(int id)
        {
            /*var test = db.Programi.Select(p => p).Where(p => p.KategorijaId == id);
            test.*/
            return db.kategorija_Programi.FirstOrDefault(p => p.KategorijaId == id);
        }

        public void Update(Kategorija_Programi kategorija)
        {
            var entry = db.Entry(kategorija);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
