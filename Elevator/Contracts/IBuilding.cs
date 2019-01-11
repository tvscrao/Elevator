using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    public interface IBuilding
    { 
        List<IFloor> GetFloors();
        List<IElevator> GetElevators();
    }
}
