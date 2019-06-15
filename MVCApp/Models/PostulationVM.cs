using ChomageLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class PostulationVM
    {
        private Postulation _postulation;

        public string Title
        {
            get { return _postulation.Offer.Title; }
            set { _postulation.Offer.Title = value; }
        }
        public string Description
        {
            get { return _postulation.Offer.Description; }
            set { _postulation.Offer.Description = value; }
        }
        public string Salary
        {
            get { return _postulation.Offer.Salary; }
            set { _postulation.Offer.Salary = value; }
        }

        public PostulationVM(Postulation postulation)
        {
            this._postulation = postulation;
        }


    }
}