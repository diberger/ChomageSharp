using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BusinessLayer;
using ChomageLibrary.Entity;

namespace ChomageWpf.ViewModels
{
    public class OfferVM : BaseViewModel
    {
        private Offer _offer;
        private RelayCommand _editOffer;


        public OfferVM(Offer offer)
        {
            this._offer = offer;
            this.Employees = new ObservableCollection<EmployeeVM>();

            List<Employee> employees = BusinessManager.Instance.GetEmployeeFromSpecificOffer(offer.Id);
            foreach(Employee e in employees)
            {
                this.Employees.Add(new EmployeeVM(e));
            }
        }


        public string Title
        {
            get { return _offer.Title; }
            set { _offer.Title = value; }
        }

        public string Salary
        {
            get { return _offer.Salary; }
            set { _offer.Salary = value; }
        }

        public string Description
        {
            get { return _offer.Description; }
            set { _offer.Description = value; }
        }

        public ObservableCollection<EmployeeVM> Employees { get; set; }


        /// <summary>
        /// Commande pour ouvrir la fenêtre pour ajouter une opération
        /// </summary>
        public ICommand EditOffer
        {
            get
            {
                if (_editOffer == null)
                    _editOffer = new RelayCommand(() => this.UpdateModele());
                return _editOffer;
            }
        }

        private void UpdateModele()
        {
            BusinessManager.Instance.Update();
        }

        public ICollection<Postulation> GetPostulations()
        {
            Console.WriteLine("sdfdsf");
            Console.WriteLine(this._offer.Postulations);
            return this._offer.Postulations;
        }

    }
}
