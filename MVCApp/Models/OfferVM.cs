using ChomageLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class OfferVM
    {
        private Offer _offer;

        public int Id
        {
            get { return _offer.Id; }
            set { _offer.Id = value; }
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

        public OfferVM(Offer offer)
        {
            this._offer = offer;
        }


    }
}