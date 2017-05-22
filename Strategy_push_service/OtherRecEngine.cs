using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class OtherRecEngine:IAdvisor
    {
        //Using Singleton pattern to only generate one instance
        public static readonly OtherRecEngine singleton = new OtherRecEngine();

        private OtherRecEngine() { }

        //using Engine to generate outcome with the info of customer
        public object Recommend(Customer c)
        {
            return "Using OtherRecEngine to generate outcome with the infomation of the customer: \"" + c.getInfo() + "\"";
        }
    }
}
