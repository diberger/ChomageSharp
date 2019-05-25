using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChomageLibrary.Entity;

namespace ChomageWpf.ViewModels
{
    public class OfferVM : BaseViewModel
    {
        private Offer _offer;

        public OfferVM(Offer offer)
        {
            this._offer = offer;
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
    }
}
