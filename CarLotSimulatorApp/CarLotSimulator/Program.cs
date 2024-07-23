// Program.cs
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciate the CarLot
            CarLot carLot = new CarLot();

            // Create first car using object initializer syntax
            Car car1 = new Car()
            {
                Year = 2020,
                Make = "Toyota",
                Model = "Camry",
                EngineNoise = "Vroom",
                HonkNoise = "Beep",
                IsDriveable = true
            };
            carLot.Cars.Add(car1);

            // Create second car using the constructor
            Car car2 = new Car();
            car2.Year = 2018;
            car2.Make = "Honda";
            car2.Model = "Civic";
            car2.EngineNoise = "Zoom";
            car2.HonkNoise = "Honk";
            car2.IsDriveable = true;
            carLot.Cars.Add(car2);

            // Create third car using property assignments
            Car car3 = new Car();
            car3.Year = 2015;
            car3.Make = "Ford";
            car3.Model = "Focus";
            car3.EngineNoise = "Roar";
            car3.HonkNoise = "Toot";
            car3.IsDriveable = false;
            carLot.Cars.Add(car3);

            // Call each of the methods for each car
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            //*************BONUS*************//

            // Iterate through the list printing each car's Year, Make, and Model to the console
            foreach (var car in carLot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}
