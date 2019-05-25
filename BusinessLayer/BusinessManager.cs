using BusinessLayer.Queries;
using ChomageLibrary.Context;
using ChomageLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessManager
    {
    private readonly ContextDA contexte;
    private static BusinessManager _businessManager = null;
        private BusinessManager()
        {
            contexte = new ContextDA();
        }
        public static BusinessManager Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new BusinessManager();
                return _businessManager;
            }
        }

        public List<Employee> GetAllEmployee()
        {
            EmployeeQuery eq = new EmployeeQuery(contexte);
            return eq.GetAll().ToList();
        }
    }
}
