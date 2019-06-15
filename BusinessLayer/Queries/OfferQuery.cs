using ChomageLibrary.Context;
using ChomageLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    class OfferQuery
    {

        private readonly ContextDA _contexte;

        public OfferQuery(ContextDA contexte)
        {
            _contexte = contexte;
        }

        public IQueryable<Offer> GetAll()
        {
            return _contexte.Offers;
        }

        public Offer GetById(int id) 
        {
             return _contexte.Offers.Where(o => o.Id == id).First();
        }


        public List<Employee> GetAllEmployeeOfSpecificOffer(int offerId)
        {
            List<Postulation> postulations = _contexte.Postulations.Where(p => p.OfferId == offerId).ToList();
            int[] employeIds = postulations.Select(p => p.EmployeeId).ToArray();
            return _contexte.Employees.Where(e => employeIds.Contains(e.Id)).ToList();
        }
    }
}
