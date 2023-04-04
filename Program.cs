using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taks_taxi
{
    class program
    {
        static void main(string[] args)
        {
            taxi taxi = new taxi();

            taxi.drivername = "jamal";
            taxi.onduty = true;
            taxi.numpassenger = 10;

            taxi.taxiinfo();
            taxi.pickupassenger();
            taxi.droppassenger();

            Console.ReadLine();

        }


    }
}