using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class RandomEngine : IAdvisor
    {
        //Using Singleton pattern to only generate one instance
        public static readonly RandomEngine singleton = new RandomEngine();

        private RandomEngine() { }

        //Generate outcome with no info
        public object Recommend(Customer c)
        {
            return "Generate using Random Engine";
        }
    }
}
