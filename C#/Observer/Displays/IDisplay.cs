using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Displays
{
    internal interface IDisplay
    {
        void Update(float temp, float humidity, float pressure);
    }
}
