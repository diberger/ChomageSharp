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
    }
}
