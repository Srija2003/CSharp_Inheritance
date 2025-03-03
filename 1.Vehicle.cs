using System;
    public class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

    public class Car : Vehicle
    {
        public Car(string brand, int speed) : base(brand, speed) { }
    }

    public class Bike : Vehicle
    {
        public Bike(string brand, int speed) : base(brand, speed) { }
    }

