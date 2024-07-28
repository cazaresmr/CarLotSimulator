using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carLot = new CarLot();

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
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");

            Car car2 = new Car();
            car2.Year = 2018;
            car2.Make = "Honda";
            car2.Model = "Civic";
            car2.EngineNoise = "Zoom";
            car2.HonkNoise = "Honk";
            car2.IsDriveable = true;
            carLot.Cars.Add(car2);
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");

            Car car3 = new Car();
            car3.Year = 2015;
            car3.Make = "Ford";
            car3.Model = "Focus";
            car3.EngineNoise = "Roar";
            car3.HonkNoise = "Toot";
            car3.IsDriveable = false;
            carLot.Cars.Add(car3);
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");

            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            foreach (var car in carLot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}
