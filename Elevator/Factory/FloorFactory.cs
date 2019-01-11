namespace Elevator
{ 
    class FloorFactory
    {
        public IFloor GetFloor()
        {
            return new Floor();
        }
    }
}
