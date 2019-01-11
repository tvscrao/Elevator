 
namespace Elevator
{
    public interface IFloor
    {
        int FloorId { get; set; }
        IElevatorButton UpButton { get; set; }
        IElevatorButton DownButton { get; set; }
    }
}
