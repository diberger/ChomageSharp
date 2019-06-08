using ChomageLibrary.Context;
using ChomageLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class PostulationQuery
    {

        private readonly ContextDA _contexte;

        public PostulationQuery(ContextDA contexte)
        {
            _contexte = contexte;
        }

        public IQueryable<Postulation> GetAll()
        {
            return _contexte.Postulations;
        }

    }
}
