using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    interface IAdvisor
    {
        Object Recommend(Customer c);
    }
}
