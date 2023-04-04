using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taks_taxi
{
    internal class taxi
    {
        public string drivername { get; set; }
        public bool onduty { get; set; }
        public int numpassenger { get; set; }

        public void taxiinfo()
        {
            Console.WriteLine("Driver Name : {0}", drivername);
            if (onduty)
            {
                Console.WriteLine("On Duty : Yes ");
            }
            else 
            {
                Console.WriteLine("On Duty : No");
            }

            Console.WriteLine
                ("Number Passenger : {0}", numpassenger);
        }
        public void pickupassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", drivername);
        }
        public void droppassenger()
        {
            Console.WriteLine("{0} sedang mengantarkan penumpang" , drivername);
        }
    }
}
