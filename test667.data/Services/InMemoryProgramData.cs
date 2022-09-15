using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test667.data.Models;

namespace test667.data.Services
{
    public class InMemoryProgramData : IProgramData
    {
        private readonly IKategorijaProgramiData _kategorijaData = new InMemoryKategorijaProgramiData();

        public IEnumerable<Program> SiteProgrami =>
            new List<Program>
            {
                new Program {Id = 1, Ime = "Винова Лоза", Link = "https://www.maganmak.com.mk/documents/programi/zastita_ishrana/vinova_loza.pdf", kategorija_programi = _kategorijaData.SiteKategorii.ToList()[1]},
                new Program {Id = 2, Ime = "Праска", Link = "https://www.maganmak.com.mk/documents/programi/zastita_ishrana/praska.pdf", kategorija_programi = _kategorijaData.SiteKategorii.ToList()[1]},
                new Program {Id = 3, Ime = "Јагода со гранулирани ѓубрива", Link = "https://www.maganmak.com.mk/documents/programi/zastita_ishrana/jagoda_granuli.pdf", kategorija_programi = _kategorijaData.SiteKategorii.ToList()[1]},
                new Program {Id = 4, Ime = "Јагода со водорастворливи ѓубрива", Link = "https://www.maganmak.com.mk/documents/programi/zastita_ishrana/jagoda_vodorastvorlivi.pdf", kategorija_programi = _kategorijaData.SiteKategorii.ToList()[1]}
            };

        public void Add(Program program)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Program> GetAll()
        {
            throw new NotImplementedException();
        }

        public Program GetProgramById(int ProgramId)
        {
            return SiteProgrami.FirstOrDefault(p => p.Id == ProgramId);
        }

        public void Update(Program program)
        {
            throw new NotImplementedException();
        }
    }
}
