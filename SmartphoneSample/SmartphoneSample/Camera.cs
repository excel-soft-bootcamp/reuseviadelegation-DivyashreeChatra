using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneSample
{
    class Camera:ICamera
    {
        public void Click() {
            Console.WriteLine("Camera Capture");
                }
    }
}
