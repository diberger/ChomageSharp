using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class PostulationListVM
    {
        public List<PostulationVM> PostulationVMs { get; set; }

        public PostulationListVM(List<PostulationVM> postulationVMs)
        {
            this.PostulationVMs = postulationVMs;
        }
    }
}