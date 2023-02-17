using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveDesingPattern
{

    public interface ICalculateObsever
    {
        void Update(float direction, float angle, float force);
    }

}
