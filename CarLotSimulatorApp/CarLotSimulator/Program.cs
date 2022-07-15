using System;
using CarLotSimulator;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carlot = new CarLot(); 
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //Now that the Car class is created we can instanciate 3 new cars
            var car1 = new Car();  //dot operator

            var car2 = new Car()    //object initializer syntax
            {
                carlot.ParkingSpots.Add(car2),
                Year = 1967,
                Make = "Mini",
                Model = "Cooper",
                IsDriveable = true,
                IsElectric = false,
                EngineNoise = "RRROOOOOAAAARRRputputputputputRRRRRRRRRRROOOOOOOOAAAAARRRRRRR",
                HonkNoise = "boop",
            };

            var car3 = new Car();   // can't figure out parameterized constructor, so dot operator again

            //Set the properties for each of the cars
            car1.Year = 1995;
            car1.Make = "Vauxhall";
            car1.Model = "Volvo 960 Estate";
            car1.IsDriveable = false;
            car1.IsElectric = false;
            car1.EngineNoise = "ffft ffft fffft VRRRMM VRRM tf tf tf";
            car1.HonkNoise = "BEEEEEEEEP!";

            car3.Year = 2020;
            car3.Make = "Jaguar";
            car3.Model = "I=Pace Electric";
            car3.IsDriveable = true;
            car3.IsElectric = true;
            car3.EngineNoise = "it doesn't make a noise, right? I've never driven one";
            car3.HonkNoise = "BEEEEEEEEP!";

            //Call each of the methods for each car

            Console.Write($"When you firmly press the {car3.Year} {car3.Make} {car3.Model}'s horn, " +
                $"it makes the sound \"");
            car1.MakeHonkNoise(car3.HonkNoise);
            Console.WriteLine($"\". As this car {car3.IsWorking(car3.IsDriveable)}, " +
                $"it's engine makes the sound {car3.MakeEngineNoise(car3.IsElectric, car3.IsDriveable, car3.EngineNoise)}");

            Console.WriteLine("");

            Console.Write($"When you firmly press the {car2.Year} {car2.Make} {car2.Model}'s horn, " +
                $"it makes the sound \"");
            car1.MakeHonkNoise(car2.HonkNoise);
            Console.WriteLine($"\". As this car {car2.IsWorking(car2.IsDriveable)}, " +
                $"it's engine makes the sound {car2.MakeEngineNoise(car2.IsElectric, car2.IsDriveable, car2.EngineNoise)}");

            Console.WriteLine("");

            Console.Write($"When you firmly press the {car1.Year} {car1.Make} {car1.Model}'s horn, " +
                $"it makes the sound \"");
            car1.MakeHonkNoise(car1.HonkNoise);
            Console.WriteLine($"\". As this car {car1.IsWorking(car1.IsDriveable)}, " +
                $"it's engine makes the sound {car1.MakeEngineNoise(car1.IsElectric, car1.IsDriveable, car1.EngineNoise)}");


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
