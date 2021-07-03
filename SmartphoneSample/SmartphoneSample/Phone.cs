using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneSample
{
    class Phone:IPhone
    {
        public void Hangup()
        {
            Console.WriteLine("Disconnected");
        }
        public void Release()
        {
            Console.WriteLine("Connected");
        }
    }
}
