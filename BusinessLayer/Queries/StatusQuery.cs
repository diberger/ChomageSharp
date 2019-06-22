using ChomageLibrary.Context;
using ChomageLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class StatusQuery
    {

        private readonly ContextDA _contexte;

        public StatusQuery(ContextDA contexte)
        {
            _contexte = contexte;
        }

        public IQueryable<Statut> GetAll()
        {
            return _contexte.Statuts;
        }
    }
}
