using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveDesingPattern
{
    public interface IPlayer
    {
        void CreateObserver(ICalculateObsever observer);
        void NotifyObservers();
    }
}
