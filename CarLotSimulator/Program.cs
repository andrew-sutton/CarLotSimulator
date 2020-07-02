using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            
            //DONE - See car class

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            // DONE - See below
            //Using the constructor
            var carOne = new Car(2003, "Honda", "Civic", "Klunk", "Beep beep!", false);
            Console.WriteLine($"The new number of cars on the lot are: {CarLot.numberOfCars}");
            //Using the Set properties
            var carTwo = new Car();
            Console.WriteLine($"The new number of cars on the lot are: {CarLot.numberOfCars}");
            carTwo.Year = 2012;
            carTwo.Make = "GMC";
            carTwo.Model = "Denali";
            carTwo.EngineNoise = "ROAAAR";
            carTwo.HonkNoise = "BLAAAM";
            carTwo.IsDrivable = true;
            //Using object initializer
            var carThree = new Car() { Year = 2020, Make = "Ford", Model = "Mustang", EngineNoise = "Vrooom", HonkNoise = "Breee", IsDrivable = true };
            Console.WriteLine($"The new number of cars on the lot are: {CarLot.numberOfCars}");
            //Call each of the methods for each car DONE - See Below
            carOne.MakeEngineNoise(carOne.EngineNoise);
            carOne.MakeHonkNoise(carOne.HonkNoise);
            carTwo.MakeEngineNoise(carTwo.EngineNoise);
            carTwo.MakeHonkNoise(carTwo.HonkNoise);
            carThree.MakeEngineNoise(carThree.EngineNoise);
            carThree.MakeHonkNoise(carThree.HonkNoise);

            //*************BONUS X 2*************//
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            //DONE - See below
            foreach (var car in CarLot.Cars)
            {
                Console.WriteLine($"{car.Year}, {car.Make}, {car.Model}");
            }
        }
    }
}
