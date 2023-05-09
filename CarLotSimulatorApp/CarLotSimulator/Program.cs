using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            // year, make, model, engineNoise, honkNoise, isDriveable

            var carList = new List<Car>();

            var myCar = new Car(1989, "Ford", "Focus", "Rrrrrrrr", "Honk", true);
        
            carList.Add(myCar);
            var rockCar = new Car(1763, "Flinestone", "Stone", "Pat Pat", "Crank", false);
            
            carList.Add(rockCar);
            var fireCar = new Car(4078, "Flamehose", "Wood", "Froom", "Flint", true);
            
            carList.Add(fireCar);

            for (int i = 0; i < carList.Count; i++)
            {
                carList[i].MakeEgineNoise(carList[i].EngineNoise);
                carList[i].MakeHonkNoise(carList[i].HonkNoise);

            }

            /*myCar.MakeEgineNoise(myCar.EngineNoise);
            rockCar.MakeEgineNoise(rockCar.EngineNoise);
            fireCar.MakeEgineNoise(fireCar.EngineNoise);

            myCar.MakeHonkNoise(myCar.HonkNoise);
            rockCar.MakeHonkNoise(rockCar.HonkNoise);
            fireCar.MakeHonkNoise(fireCar.HonkNoise);*/

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
