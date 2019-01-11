using Elevator;
using System;
using System.Collections.Generic;

namespace ElevatorConsumerWinForm
{
    public class Utility
    {
        public static string PressButtonFromAFloor(IBuilding building, int floorId, Direction direction)
        {
            IFloor floor = building.GetFloors().Find(X => X.FloorId == floorId);
            string result = string.Empty;
            if (direction == Direction.Up)
            {
                result = floor.UpButton.Press(floor, building.GetElevators());
            }
            else
            {
                result = floor.DownButton.Press(floor, building.GetElevators());
            }

            return result;
        }
        public static void DisplayFloors(IBuilding building)
        {
            foreach (IFloor floor in building.GetFloors())
            {
                Console.WriteLine("Floor Id : {0} ", floor.FloorId.ToString());
            }
        }
        public static void DisplayElevators(IBuilding building)
        {
            foreach (IElevator elevator in building.GetElevators())
            {
                Console.WriteLine("Elevator Id : {0} CurrentDirection: {1}, CurrentFloor: {2}", elevator.ElevatorName.ToString(), ((Direction)elevator.CurrentDirection).ToString(), elevator.CurrentFloorId);
            }
        }
        public static void SetSampleFloorElevatorValues(IBuilding building)
        {
            List<IElevator> elevators = building.GetElevators();
            elevators[0].CurrentFloorId = 7;
            elevators[0].CurrentDirection = Direction.Up;

            elevators[1].CurrentFloorId = 4;
            elevators[1].CurrentDirection = Direction.Hold;

            elevators[2].CurrentFloorId = -2;
            elevators[2].CurrentDirection = Direction.Up;
        }
    }
}
