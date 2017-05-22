using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Customer:ICustomer
    {
        private IAdvisor _advisor;
        private string info;
        private bool login = false;
        private bool venderSuggest=false;

        public Customer() { }
        //If vender have something to recommend to customer
        public bool VenderSuggest
        {
            get
            {
                return venderSuggest;
            }

            set
            {
                venderSuggest = value;
            }
        }
        //if customer logged in 
        public void Login()
        {
            login = true;
        }

        //Execute the strategy 
        public void showAdvices()
        {
            if (_advisor == null)
            {
                if (login == true)
                {
                    _advisor = RefEngine.singleton;
                }
                else if (venderSuggest == true)
                {
                    _advisor = OtherRecEngine.singleton;
                }
                else
                    _advisor = RandomEngine.singleton;
            }
            Console.WriteLine(_advisor.Recommend(this));
        }

        //get the info of customer
        public string getInfo()
        {
            return "I'm a customer";
        }
    }
}
