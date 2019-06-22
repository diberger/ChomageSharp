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


        public PostulationVM()
        {
            this._postulation = new Postulation();
        }

        public void GeneratePostulationEntityFromSelf()
        {
            this._postulation.Date = this.Date;
            this._postulation.Status = this.StatutId;
            this._postulation.OfferId = this.OfferId;
            this._postulation.EmployeeId = this.EmployeeId;
        }

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

        public DateTime Date
        {
            get { return _postulation.Date; }
            set { _postulation.Date= value; }
        }

        public string StatutId
        {
            get { return _statusId; }
            set { _statusId = value; }
        }

        private string _statusId;

        public int OfferId
        {
            get { return _offerId; }
            set { _offerId = value; }
        }

        private int _offerId;

        public int EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        private int _employeeId;

        public PostulationVM(Postulation postulation)
        {
            this._postulation = postulation;
        }

        public Postulation getPostulation()
        {
            return this._postulation;
        }


    }
}