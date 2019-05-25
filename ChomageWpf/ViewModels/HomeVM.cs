using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChomageWpf.ViewModels
{
    public class HomeVM
    {

        private ListeOfferVM _listeOffersVM = null;
        

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public HomeVM()
        {
            _listeOffersVM = new ListeOfferVM();
        }
        
        /// <summary>
        /// Obtient ou définit le ListeProduitViewModel
        /// </summary>
        public ListeOfferVM ListeOfferVM
        {
            get { return _listeOffersVM; }
            set { _listeOffersVM = value; }
        }

    }
}
