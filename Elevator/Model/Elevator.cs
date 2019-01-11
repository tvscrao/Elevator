
namespace Elevator
{
    class Elevator : IElevator
    { 
        public Elevator()
        {
            CurrentDirection = Direction.Up;
        }
        public int ElevatorId { get; set; }
        public string ElevatorName { get; set; }
        public Direction CurrentDirection { get; set; }
        public int CurrentFloorId { get; set; }

        //elevator methods
        public void Hold()
        {
            CurrentDirection = Direction.Hold;
        }
        public void MoveTo(int floor, Direction direction)
        {
            CurrentFloorId = floor;
            CurrentDirection = direction;
        }
        
    }
}
