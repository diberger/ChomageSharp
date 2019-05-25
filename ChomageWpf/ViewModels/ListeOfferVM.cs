using BusinessLayer;
using ChomageLibrary.Entity;
using ChomageWpf.Mock;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChomageWpf.ViewModels
{
    public class ListeOfferVM : BaseViewModel
    {

        private ObservableCollection<OfferVM> _offers = null;
        private OfferVM _selectedOffer;

   

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ListeOfferVM()
        {
            // on appelle le mock pour initialiser une liste de produits
            _offers = new ObservableCollection<OfferVM>();

            foreach (Offer o in BusinessManager.Instance.GetAllOffer())
            {
                _offers.Add(new OfferVM(o));
            }

            if (_offers != null && _offers.Count > 0)
                _selectedOffer = _offers.ElementAt(0);
        }

        /// <summary>
        /// Obtient ou définit une collection de DetailProduitViewModel (Observable)
        /// </summary>
        public ObservableCollection<OfferVM> Offers
        {
            get { return _offers; }
            set
            {
                _offers = value;
                OnPropertyChanged("Offers");
            }
        }

        /// <summary>
        /// Obtient ou défini le produit en cours de sélection dans la liste de DetailProduitViewModel
        /// </summary>
        public OfferVM SelectedOffer
        {
            get { return _selectedOffer; }
            set
            {
                _selectedOffer = value;
                OnPropertyChanged("SelectedOffer");
            }
        }


    }
}

