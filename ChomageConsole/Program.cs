using BusinessLayer;
using ChomageLibrary.Context;
using ChomageLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChomageConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEFAvecDataAnnotations();
        }

        public static void TestEFAvecDataAnnotations()
        {
            //try
            //{
                BusinessManager bm = BusinessManager.Instance;

                Statut statut1 = new Statut { Label = "Ouvert" };
                Employee employee1 = new Employee("Baptiste", "Andrieux", new DateTime(), 5, "JE DAB SI CA MARCHE");
                Offer offer1 = new Offer { Title = "Livreur de Pizza", Description = "Défi les loi de la gravité, pour vous emmener vos délices", Salary = "100", Date = new DateTime(), Responsible = "Jean-Michel Amoitier", StatutId = statut1.Id };
                Postulation postulation1 = new Postulation { EmployeeId = employee1.Id, OfferId = offer1.Id };

                Statut statut2 = new Statut { Label = "Mi-Fermer, Mi-Ouvert" };
                Employee employee2 = new Employee("Dimitri", "Berger", new DateTime(), 1, "Pourquoi la vie ?");
                Offer offer2 = new Offer { Title = "Creamers", Description = "Une lettre de plus et vous en ferez des cauchemars", Salary = "5000", Date = new DateTime(), Responsible = "Anne Hultout", StatutId = statut2.Id };
                Postulation postulation2 = new Postulation { EmployeeId = employee2.Id, OfferId = offer2.Id };

                Statut statut3 = new Statut { Label = "Fermer" };
                Employee employee3 = new Employee("David", "Lafarge", new DateTime(), 100, "WHHHHHHOUUUUAWWWW UN PORIGON Z EX ULTRA RARE !!!");
                Offer offer3 = new Offer { Title = "Sourceur", Description = "Pas besoin d'argent, la nature vous suffit", Salary = "0", Date = new DateTime(), Responsible = "Alex Térieur", StatutId = statut3.Id };
                Postulation postulation3 = new Postulation { EmployeeId = employee3.Id, OfferId = offer3.Id };

                bm.addStatut(statut1);
                bm.addStatut(statut2);
                bm.addStatut(statut3);

                bm.addEmployee(employee1);
                bm.addEmployee(employee2);
                bm.addEmployee(employee3);

                bm.addOffer(offer1);
                bm.addOffer(offer2);
                bm.addOffer(offer3);

                bm.addPostulation(postulation1);
                bm.addPostulation(postulation2);
                bm.addPostulation(postulation3);

                List<Employee> employees = bm.GetAllEmployee();
                Console.WriteLine("Liste de mes clients avec DA : ");
                foreach (Employee e in employees)
                {
                    Console.WriteLine("Client n°{0} : {1} {2}", e.Id, e.FirstName, e.LastName);
                }
                Console.WriteLine("...Fin...");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    throw;
            //}

        }
    }
}
