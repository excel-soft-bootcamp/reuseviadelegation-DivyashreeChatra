using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneSample
{
    class Photographer
    {
        public void Capture(ICamera camera)
        {
            camera.Click();
        }
    }
}
