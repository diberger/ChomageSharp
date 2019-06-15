using BusinessLayer;
using System;
using System.Collections.Generic;
using ChomageLibrary.Entity;
using System.Web.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class PostulationController : Controller
    {
        public ActionResult List()
        {
            BusinessManager businessManager = BusinessManager.Instance;
            Employee currentEmployee = businessManager.GetEmployeeById(1);
            List<Postulation> offers = businessManager.GetPostulationByEmployee(currentEmployee);
            List<PostulationVM> postulationVMs = new List<PostulationVM>();
            offers.ForEach((elt) => postulationVMs.Add(new PostulationVM(elt)));
            PostulationListVM postulationListVM = new PostulationListVM(postulationVMs);

            return View(postulationListVM);
        }
        public ActionResult Apply(Offer offer)
        {
            BusinessManager businessManager = BusinessManager.Instance;
            Employee currentEmployee = businessManager.GetEmployeeById(1);
            businessManager.setEmployeePostulation(offer, currentEmployee);

            return RedirectToRoute("PostulationList");
        }
    }
}