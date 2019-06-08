using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BusinessLayer;
using ChomageLibrary.Entity;

namespace WcfService1
{
    public class Service1 : IService1
    {

        public List<Employee> GetEmployees()
        {
            BusinessManager bm = BusinessManager.Instance;
            List<Employee> employees = bm.GetAllEmployee();
            return employees;
        }
    }
}
