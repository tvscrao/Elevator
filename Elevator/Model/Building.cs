
using System;
using System.Collections.Generic;
 
namespace Elevator
{
    public class Building : IBuilding
    {
        //Building contains floors and elevators
        List<IFloor> Floors = new List<IFloor>();
        List<IElevator> Elevators = new List<IElevator>();
        public Building(int minFloorId, int maxFloorId, int noOfElevators)
        {
            try
            {
                InitFloors(minFloorId, maxFloorId);
                InitElevators(noOfElevators);
            }
            catch (Exception ex)
            {
                Logger.Log(string.Format("Message: {0}; StackTrace: {1}", ex.Message, ex.StackTrace), LogType.Error);
            }
        }
        public List<IFloor> GetFloors()
        {
            return Floors;
        }
        public List<IElevator> GetElevators()
        {
            return Elevators;
        }
        private void InitFloors(int minFloorId, int maxFloorId)
        {
            FloorFactory fact = new FloorFactory();

            for (int i = minFloorId; i <= maxFloorId; i++)
            {
                IFloor flr = fact.GetFloor();
                flr.FloorId = i;
                Floors.Add(flr);
            } 
        }
        private void InitElevators(int NoOfElevators)
        {
            ElevatorFactory elevatorFactory = new ElevatorFactory();
             
            for (int i = 1; i <= NoOfElevators; i++)
            {
                IElevator elevator = elevatorFactory.GetElevator();
                elevator.ElevatorId = i;
                elevator.ElevatorName = "E"+ i.ToString();
                Elevators.Add(elevator); 
            }
        }
    }
}
