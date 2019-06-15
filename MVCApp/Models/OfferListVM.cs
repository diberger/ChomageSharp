using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class OfferListVM
    {
        public List<OfferVM> OfferVMs { get; set; }

        public OfferListVM(List<OfferVM> offerVMs)
        {
            this.OfferVMs = offerVMs;
        }
    }
}