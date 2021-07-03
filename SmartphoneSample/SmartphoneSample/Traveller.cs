using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneSample
{
    class Traveller
    {
        public void Hike(ITraveller gps)
        {
           
            gps.Navigate();
        }
      
    }
}
