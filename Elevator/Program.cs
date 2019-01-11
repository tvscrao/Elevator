using System.Collections.Generic;
using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilding building = new Building(-2,10,3);
            building.InitBuilding();

            SetSampleFloorElevatorValues(building);
            DisplayFloors(building);
            DisplayElevators(building);

            int floorId = 0;
            Direction direction = Direction.Unknown;

            Console.WriteLine("Which floor are you in : (-2 to 10)");
            
            floorId = Convert.ToInt32(Console.ReadLine());
             
            Console.WriteLine("Up/Down : ");

            char dir = Convert.ToChar(Console.ReadLine());

            if (dir == 'U') direction = Direction.UP;

            if (dir == 'D') direction = Direction.Down;
             
            var result = PressButtonFromAFloor(building, floorId, direction);
            
            Console.WriteLine("Optiaml Elevator Id {0}", result);

            DisplayElevators(building);
            Console.ReadKey();
        }
       

        static int PressButtonFromAFloor(IBuilding building, int floorId, Direction direction)
        {
            IFloor floor = building.GetFloors().Find(X => X.FloorId == floorId);
            int result = 0;
            if(direction == Direction.UP)
            {
                result = floor.UpButton.Press(floor, building.GetElevators());
            }
            else
            {
                result = floor.DownButton.Press(floor, building.GetElevators());
            }

            return result;
        }
        static void DisplayFloors(IBuilding building)
        {
            foreach(IFloor floor in building.GetFloors())
            {
                Console.WriteLine("Floor Id : {0} ", floor.FloorId.ToString());
            }
        }
        static void DisplayElevators(IBuilding building)
        {
            foreach (IElevator elevator in building.GetElevators())
            {
                Console.WriteLine("Elevator Id : {0} CurrentDirection: {1}, CurrentFloor: {2}", elevator.ElevatorId.ToString(), ((Direction)elevator.CurrentDirection).ToString(), elevator.CurrentFloorId);
            }
        }

        static void SetSampleFloorElevatorValues(IBuilding building)
        {
            List<IElevator> elevators = building.GetElevators();
            //TODO: hardcoding for setting sample values //remove this
            elevators[0].CurrentFloorId = 7;
            elevators[0].CurrentDirection = Direction.UP;

            elevators[1].CurrentFloorId = 4;
            elevators[1].CurrentDirection = Direction.Hold;

            elevators[2].CurrentFloorId = -2;
            elevators[2].CurrentDirection = Direction.UP;
        }
    }
}
