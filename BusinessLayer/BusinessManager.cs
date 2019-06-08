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

        public bool addEmployee(Employee employee)
        {
            contexte.Employees.Add(employee);
            contexte.SaveChanges();
            return true;
        }

        public List<Offer> GetAllOffer()
        {
            OfferQuery oq = new OfferQuery(contexte);
            return oq.GetAll().ToList();
        }

        public List<Postulation> GetAllPostulation()
        {
            PostulationQuery pq = new PostulationQuery(contexte);
            return pq.GetAll().ToList();
        }

        public bool addOffer(Offer offer)
        {
            contexte.Offers.Add(offer);
            contexte.SaveChanges();
            return true;
        }

        public bool addPostulation(Postulation postulation)
        {
            contexte.Postulations.Add(postulation);
            contexte.SaveChanges();
            return true;
        }

        public bool addStatut(Statut statut)
        {
            contexte.Statuts.Add(statut);
            contexte.SaveChanges();
            return true;
        }

        public void Update()
        {
            contexte.SaveChanges();
        }

        public List<Employee> GetEmployeeFromSpecificOffer(int offerId)
        {
            OfferQuery oq = new OfferQuery(contexte);
            return oq.GetAllEmployeeOfSpecificOffer(offerId).ToList();
        }
    }
}
