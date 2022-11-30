namespace Lexercise5.GARAGE
{
    internal class Manager
    {
        private UI ui;
        private GarageHandler handler = null!;

        public Manager()
        {
            ui = new UI();
        }

        internal void Start()
        {
            ui.Print("Welcome");
            ui.Print("Nr of slots?");
            int capacity = int.Parse(ui.GetInput());

            //Garqagets storlek
            //Hårdkodad storlek till 10

            handler = new GarageHandler(capacity);
            MainMeny();
        }

        private void MainMeny()
        {

            do
            {
                ui.Print("1. Seed");
                ui.Print("2. ListAll");
                //Get input from user
                var hardCodeedInput = ui.GetInput();

                switch (hardCodeedInput)
                {
                    case "1":
                        handler.Seed();
                        break;
                    case "2":
                       IEnumerable<string> vehicles= handler.GetVehicles();
                        foreach (var vehicle in vehicles)
                        {
                            ui.Print($"{vehicle}");
                        }
                        break;
                    case "3":
                        ParkNewVehicle();
                        break;
                    default:
                        break;


                }
            } while (true);
        }

        private void ParkNewVehicle()
        {
            // skriv ut instruktioner
            // fråga om typ
            // fråga om regnr
            Console.Write("Reg nr? ");
            var regnr = Console.ReadLine();
            // ...

            //handler.Park(new Vehicle(regnr, ));
            // skriv emeddelande om att detr gick bra
        }
    }
}