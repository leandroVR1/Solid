using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Solid.Models;

namespace Solid
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAll();
        Company GetById(int id);
        void Add(Company company);
        void Update(Company company);
        void Delete(Company company);

    }
}