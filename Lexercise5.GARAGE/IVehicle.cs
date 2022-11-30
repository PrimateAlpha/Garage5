using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexercise5.GARAGE
{
    internal interface IVehicle
    {
        string Manufacturer { get; set; }
        string Model { get; set; }
        string Color { get; set; }
        string RegNr { get; set; }

    }

    class Airplane : Vehicle
    {
        public Airplane(string regnr, string color, string model, string manufacturer) : base(regnr, color, model, manufacturer)
        {
        }

        public void TEst()
        {
            Testing();
            Model = "Volvo";
        }
    }

    class Motorcycle : Vehicle
    {
        public void TEst()
        {
            Testing();
            Model = "Kawasaki";
        }

    }
    class Car : Vehicle
    {
        public void TEst()
        {
            Testing();
            Model = "Kawasaki";
        }

    }
    class Bus : Vehicle
    {
        public void TEst()
        {
            Testing();
            Model = "Kawasaki";
        }

    }
    class Boat : Vehicle
    {
        public void TEst()
        {
            Testing();
            Model = "Kawasaki";
        }

    }
}
