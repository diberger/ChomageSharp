using ChomageLibrary.Entity;
using System.Collections.ObjectModel;

namespace ChomageWpf.ViewModels
{
    public class EmployeeVM : BaseViewModel
    {
        private Employee _employee;


        public EmployeeVM(Employee employee)
        {
            this._employee = employee;
        }


        public string EmployeeName
        {
            get { return _employee.FirstName; }
            set { _employee.FirstName = value; }
        }

    }
}