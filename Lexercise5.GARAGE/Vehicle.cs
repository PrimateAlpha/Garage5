using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexercise5.GARAGE
{
    internal /*abstract*/ class Vehicle : IVehicle
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string RegNr { get; set; }

        public void Testing()
        {
            //
        }

        public Vehicle(string regnr, string color, string model, string manufacturer)
        {
            RegNr= regnr;
            Model = model;
            Color = color;
            Manufacturer = manufacturer;
        }

        internal virtual string GetStats()
        {
            return $"[{this.GetType().Name}, Model: {Model}]";
        }
    }
}
