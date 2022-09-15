using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test667.data.Models;

namespace test667.data.Services
{
    public interface IProgramData
    {
        IEnumerable<Program> SiteProgrami { get; }
        IEnumerable<Program> GetAll();
        Program GetProgramById(int programId);
        void Add(Program program);
        void Update(Program program);
        void Delete(int id);

    }
}
