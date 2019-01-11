namespace Elevator
{
    class Floor : IFloor
    {
        public Floor()
        {
            ButtonFactory factory = new ButtonFactory();
            UpButton = factory.GetButton(Direction.Up);
            DownButton = factory.GetButton(Direction.Down);
        }
        public int FloorId { get; set; }
        //Each Floor contains Two ElevatorButtons : Composition Rule
        public IElevatorButton UpButton { get; set; }
        public IElevatorButton DownButton { get; set; }
    }
}
