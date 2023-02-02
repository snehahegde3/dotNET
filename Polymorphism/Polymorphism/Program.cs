﻿using System.Numerics;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            foreach(var car in Cars)
            {
                car.Repair();
            }

            Car bmw1 = new BMW(240, "green", "M7");
            bmw1.ShowDetails();

            M3 m31 = new M3(250, "silver", "M31");
            m31.Repair();

        }
    }
}