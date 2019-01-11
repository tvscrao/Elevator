 
namespace Elevator
{
    public interface IElevator
    {
        int ElevatorId { get; set; }
        string ElevatorName { get; set; }
        int CurrentFloorId { get; set; }
        Direction CurrentDirection { get; set; }
        void MoveTo(int floor, Direction direction); 
        void Hold();
    }
}
