namespace Elevator
{
    class ElevatorFactory
    {
        public IElevator GetElevator()
        {
            return new Elevator();
        }
    }
}
