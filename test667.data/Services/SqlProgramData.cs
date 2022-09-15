using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test667.data.Models;

namespace test667.data.Services
{
    public class SqlProgramData : IProgramData
    {
        private readonly test667DbContext db;

        public SqlProgramData(test667DbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Program> SiteProgrami
        {
            get
            {
                return db.Programi.Include(c => c.kategorija_programi);
            }
        }

        public IEnumerable<Program> GetAll()
        {
            return from p in db.Programi
                   orderby p.Ime
                   select p;
        }

        public void Add(Program program)
        {
            db.Programi.Add(program);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var program = db.Programi.Find(id);
            db.Programi.Remove(program);
            db.SaveChanges();
        }

        public Program GetProgramById(int programId)
        {
            return db.Programi.FirstOrDefault(p => p.Id == programId);
        }

        public void Update(Program program)
        {
            var entry = db.Entry(program);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
