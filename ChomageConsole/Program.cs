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
            Console.WriteLine("...METHODDDEEE...");

            // test du contexte avec data annotation
            try
            {
                BusinessManager bm = BusinessManager.Instance;

                Console.WriteLine("...CONTEXTE...");

                // ajout d'un nouveau client avec un compte

                //bm.Employees.Add(new Employee("Baptiste", "Andrieux", new DateTime(), 5, "Rapide, court mais efficace"));
                //Console.WriteLine("...AJOUTOUILLE...");

                //contexteDA.SaveChanges();
                //Console.WriteLine("...COUCOUILLE...");
                //// lecture des clients
                //List<Employee> employees = bm.GetAllEmployee;
                Console.WriteLine("Liste de mes clients avec DA : ");
                foreach (Employee e in employees)
                {
                    Console.WriteLine("Client n°{0} : {1} {2}", e.Id, e.FirstName, e.LastName);
                }
                Console.WriteLine("...Fin...");

            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
