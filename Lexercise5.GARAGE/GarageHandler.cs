namespace Lexercise5.GARAGE
{
    internal class GarageHandler
    {
        private Garage<Vehicle> garage;

        public GarageHandler(int capacity)
        {
          garage = new Garage<Vehicle>(capacity);
        }

        internal IEnumerable<string> GetVehicles()
        {
            List<string> result = new List<string>();
            foreach(var v in garage)
            {
                result.Add(v.GetStats());
            }
            return result;
        }

        internal void Park(Vehicle vehicle)
        {
            garage.Park(vehicle);
        }

        internal void Seed()
        {
            var airplane = new Airplane();
            garage.Park(airplane);
        }
    }
}