using BusinessLayer;
using ChomageLibrary.Entity;
using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class OfferController : Controller
    {
        public ActionResult List()
        {
            BusinessManager businessManager = BusinessManager.Instance;
            List<Offer> offers = businessManager.GetAllOffer();
            List<OfferVM> offerVMs = new List<OfferVM>();
            offers.ForEach((elt) => offerVMs.Add(new OfferVM(elt)));
            OfferListVM offerListVM = new OfferListVM(offerVMs);

            return View(offerListVM);
        }
        public ActionResult Detail(int id)
        {
            try
            {
                BusinessManager businessManager = BusinessManager.Instance;
                Offer offer = businessManager.GetOfferById(id);
                OfferVM offerVM = new OfferVM(offer);
                return View(offerVM);
            } catch (Exception e)
            {
                return RedirectToRoute("Error");
            }
        }
    }
}