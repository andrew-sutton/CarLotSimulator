﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
            CarLot.Cars.Add(this);
        }
        public Car(int year, string make, string model, string engineNoise, string honk, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honk;
            IsDrivable = isDrivable;
            CarLot.numberOfCars++;
            CarLot.Cars.Add(this);
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        

        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine(noise);
        }
        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine(noise);
        }
    }
}
