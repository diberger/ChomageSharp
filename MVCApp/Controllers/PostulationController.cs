using BusinessLayer;
using System;
using System.Collections.Generic;
using ChomageLibrary.Entity;
using System.Web.Mvc;
using MVCApp.Models;
using System.Data;

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
        public ActionResult ApplyForm(int offerId)
        {
            BusinessManager businessManager = BusinessManager.Instance;
            List<Statut> statuts = businessManager.GetAllStatut();
            Employee currentEmployee = businessManager.GetEmployeeById(1);
            SelectList items = new SelectList(statuts, "Label", "Label");

            ViewBag.StatutList = items;
            ViewBag.OfferId = offerId;
            ViewBag.EmployeeId = currentEmployee.Id;
            return View();
        }


        [HttpPost]
        public ActionResult ApplyForm(PostulationVM postulationVM)
        {
            postulationVM.GeneratePostulationEntityFromSelf();
            BusinessManager businessManager = BusinessManager.Instance;
            businessManager.addPostulation(postulationVM.getPostulation());

            return RedirectToAction("List");
        }

    }
}