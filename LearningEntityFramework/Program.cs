using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace LearningEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroDBContext db = new IntroDBContext();

            Order[] orders = db.Orders.ToArray();

             foreach (var o in orders)
             {
                Console.WriteLine($"{o.Id}, {o.Total} {o.customer.Name} {o.OrderDescription}");
                Thread.Sleep(2000);
            }
            //Customer[] customers = db.Customers.ToArray();
            //foreach (var c in customers)            
            //{
            //    string message = $"Id:{c.Id}, Name: {c.Name}, City: {c.City}, State: {c.State}";
            //    Console.WriteLine(message);
            //}
            //// Func<Customer>

            //Func<Customer, bool> hey = MyFunction;
            //Customer[] customersState = db.Customers.Where(hey).ToArray();
            //foreach (var c in customersState)
            //{
            //    string message = $"Id:{c.Id}, Name: {c.Name}, City: {c.City}, State: {c.State}";
            //    Console.WriteLine(message);
            //}

            //Console.WriteLine("");
            //Customer[] customersStateNV = db.Customers.Where(c => c.State == "NV").ToArray();
            //foreach (var c in customersStateNV)
            //{
            //    string message = $"Id:{c.Id}, Name: {c.Name}, City: {c.City}, State: {c.State}";
            //    Console.WriteLine(message);
            //}

            //List<List<string>> listOfLists = new List<List<string>>();
            //listOfLists.Add()

            // db.Customers.SqlQuery("")
            //  Customer[] customersStateNV = db.Customers.Where(c => c.State == "OH" && c.City == "St. Petersburg").OrderByDescending(c => c.Name).ToArray();

            // Customer k = db.Customers.Where(p => p.Id == 1);
            //Customer guy = db.Customers.Find(15);

            // Console.WriteLine(guy.Name);
            // Console.WriteLine(db.Customers.Sql.ToString());
            // Customer[] custs = db.Customers.SqlQuery("SELECT id, name, city, state FROM customers WHERE id=5").ToArray();
            //Console.WriteLine(custs[0].Name);
            /*
            foreach (var c in customersStateNV)
            {
                string message = $"Id:{c.Id}, Name: {c.Name}, City: {c.City}, State: {c.State}";
                Console.WriteLine(message);
            }*/

        }

        static public bool MyFunction(Customer c)
        {
            if(c.State == "GA")
            return true;

            return false;
        }

        static public bool SortBySecond(List<string> arr)
        {
            return true;
        }
    }
}
