using System;
using System.Collections.Generic;
using System.Linq;

namespace Elevator
{
    class ElevatorButton : IElevatorButton
    {
        public Direction ButtonDirection { get; set; }
        public string Press(IFloor floor, List<IElevator> elevators)
        {
            try
            {
                //gets the optimal elevator
                IElevator optimalElevator = GetOptimalElevator(floor, elevators);

                //move the elevator to the required floor
                optimalElevator.MoveTo(floor.FloorId, ButtonDirection);

                return optimalElevator.ElevatorName;
            }
            catch (Exception ex)
            {
                Logger.Log(string.Format("Message: {0}; StackTrace: {1}", ex.Message, ex.StackTrace), LogType.Error);
            }
            return string.Empty;
        }
        private IElevator GetOptimalElevator(IFloor floor, List<IElevator> elevators)
        { 
            Dictionary<int, int> distances = new Dictionary<int, int>();

            //know the distance of each elevator (not in hold) from the current floor
            foreach (IElevator elevator in elevators.FindAll(e => e.CurrentDirection != Direction.Hold))
            {
                distances.Add(elevator.ElevatorId, Math.Abs(floor.FloorId - elevator.CurrentFloorId));
            }

            //find the nearest elevator
            int optimalElevatorId = distances.OrderBy(k => k.Value).ThenBy(k=>k.Key).FirstOrDefault().Key;

            return elevators.Find(x => x.ElevatorId == optimalElevatorId);
        }

        private IElevator GetOptimalElevator1(IFloor floor, List<IElevator> elevators)
        {
            Dictionary<int, int> distances = new Dictionary<int, int>();

            //know the distance of each elevator (not in hold) from the current floor
            foreach (IElevator elevator in elevators.FindAll(e => e.CurrentDirection != Direction.Hold))
            {
                distances.Add(Math.Abs(floor.FloorId - elevator.CurrentFloorId), elevator.ElevatorId);
            }

            //find the nearest elevator
            int optimalElevatorId = distances[distances.Min(x => x.Key)];

            return elevators.Find(x => x.ElevatorId == optimalElevatorId);
        }
    }
}
