using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveDesingPattern
{
    class CalculateObsever : ICalculateObsever
    {
        public void Update(float direction, float angle, float force)
        {
            Console.WriteLine("Direction: " + direction + ", Angle: " + angle + ", Force: " + force);
        }
    }
}
