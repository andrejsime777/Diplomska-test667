using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test667.data.Models;

namespace test667.data.Services
{
    public class SqlProizvodData : IProizvodData
    {
        private readonly test667DbContext db;

        public SqlProizvodData(test667DbContext db)
        {
            this.db = db;
        }

        public void Add(Proizvod proizvod)
        {
            db.Proizvodi.Add(proizvod);
            db.SaveChanges();
        }

        public Proizvod Get(int id)
        {
            return db.Proizvodi.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Proizvod> GetAll()
        {
            return from p in db.Proizvodi
                   orderby p.ime
                   select p;
        }

        public void Update(Proizvod proizvod)
        {
            var entry = db.Entry(proizvod);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var proizvod = db.Proizvodi.Find(id);
            db.Proizvodi.Remove(proizvod);
            db.SaveChanges();
        }
    }
}
