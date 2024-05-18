using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Solid.Models;

namespace Solid.Services
{

    public class CompanyRepository : ICompanyRepository //Darle a la campana y luego a interface para quitar el error
    {
        public void Add(Company company)
        {
            throw new NotImplementedException();
        }

        public void Delete(Company company)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public Company GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Company company)
        {
            throw new NotImplementedException();
        }
    }
}