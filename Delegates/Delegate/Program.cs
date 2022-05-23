using System;
using System.Collections.Generic;
using Delegate.Entities;
using System.Linq;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            #region Delegate Predicate

            // Reference to a Function
            Predicate<Product> predicate = ProductTest;

            // Labmda Expression
            //Predicate<Product> predicate = p => p.Price >= 100.0;

            list.RemoveAll(predicate);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            #endregion

            #region Delegate Action
            // 0 to 16  parameters

            // Reference to a function
            //Action<Product> act = UpdatePrice;

            // Lambda Expression
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };

            //list.ForEach(act);
            //foreach(Product p in list)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Delegate Func
            // 0 to 16 parameters

            ////Reference to a function
            ////Func<Product, string> func = NameUpper;

            ////Lambda Expression
            //Func<Product, string> func = p => p.Name.ToUpper();

            //List<string> result = list.Select(func).ToList();
            //foreach (string s in result)
            //{
            //    Console.WriteLine(s);
            //}


            #endregion
        }

        ////Delegate Predicate
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }


        // Delegate Action
        //public static void UpdatePrice(Product p)
        //{
        //    p.Price += p.Price * 0.1;
        //}

        public static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

    }
}
