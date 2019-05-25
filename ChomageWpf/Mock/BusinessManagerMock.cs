using ChomageLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChomageWpf.Mock
{
    public class BusinessManagerMock
    {
        private static BusinessManagerMock _businessManager = null;

        /// <summary>
        /// Constructeur
        /// </summary>
        private BusinessManagerMock()
        {
        }

        /// <summary>
        /// Récupérer l'instance du pattern Singleton
        /// </summary>
        public static BusinessManagerMock Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new BusinessManagerMock();
                return _businessManager;
            }
        }

        /// <summary>
        /// Méthode pour simuler un appel au contexte pour renvoyer une liste de produits
        /// </summary>
        /// <returns></returns>
        public List<Offer> GetAllOffer()
        {
            List<Offer> produits = new List<Offer>();
            produits.Add(new Offer { Title = "Livreur de Pizza", Description = "Défi les loi de la gravité, pour vous emmener vos délices", Salary = "100" });
            produits.Add(new Offer { Title = "Creamers", Description = "Une lettre de plus et vous en ferez des cauchemars", Salary = "5000" });
            produits.Add(new Offer { Title = "Sourceur", Description = "Pas besoin d'argent, la nature vous suffit", Salary = "0" });
            return produits;
        }
    }
}
