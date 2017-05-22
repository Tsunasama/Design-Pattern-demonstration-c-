using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize all customers
            Customer c1 = new Customer();
            c1.Login();

            Customer c2 = new Customer()
            {
                VenderSuggest =true
            };

            Customer c3 = new Customer();

            c1.showAdvices();
            c2.showAdvices();
            c3.showAdvices();            
        }
    }
}
