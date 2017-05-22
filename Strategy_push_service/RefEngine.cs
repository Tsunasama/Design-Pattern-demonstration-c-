using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class RefEngine : IAdvisor
    {
        //Using singleton pattern for just on instance of this class
        public static readonly RefEngine singleton = new RefEngine();

        private RefEngine() { }

        //using Engine to generate outcome with the info of customer
        public object Recommend(Customer c)
        {
            return "Using RefEngine to generate outcome with the infomation of the customer: \"" + c.getInfo() + "\"";
        }
    }
}
