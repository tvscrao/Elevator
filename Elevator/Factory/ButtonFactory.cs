namespace Elevator
{
    internal class ButtonFactory
    {
        public IElevatorButton GetButton(Direction direction)
        {
            return new ElevatorButton() {ButtonDirection = direction};
        }
    }
}
