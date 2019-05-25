using ChomageLibrary.Context;
using ChomageLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    class EmployeeQuery
    {

        private readonly ContextDA _contexte;

        public EmployeeQuery(ContextDA contexte)
        {
            _contexte = contexte;
        }

        public IQueryable<Employee> GetAll()
        {
            return _contexte.Employees;
        }
    }
}
