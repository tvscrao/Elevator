using System.Collections.Generic;

namespace Elevator
{
    public interface IElevatorButton
    {
        Direction ButtonDirection { get; set; }
        string Press(IFloor floor, List<IElevator> elevators);
    }
}
