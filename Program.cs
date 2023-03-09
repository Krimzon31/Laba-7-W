using System;

namespace Laba_7_W
{
    internal class Program
    {
        abstract class Trasport
        {
            public abstract string speed { get; set; }
            public abstract double load_capacity { get; set; }
            public abstract double distance { get; set;}
        }

        abstract class Car : Trasport
        {

            public abstract void speed_Info();
            public abstract void load_capacity_Info();
            public abstract void distance_Info();

        }

        abstract class Airplane : Trasport
        {

            public abstract void speed_Info();
            public abstract void load_capacity_Info();
            public abstract void distance_Info();

        }

        abstract class Ship : Trasport
        {

            public abstract void speed_Info();
            public abstract void load_capacity_Info();
            public abstract void distance_Info();

        }

        class Mitsubishi : Car
        {
            public override string speed { get; set; }
            public override double load_capacity { get; set; }
            public override double distance { get; set; }

            public override void speed_Info()
            {
                Console.WriteLine($"скорость Митсубиси = {speed}");
            }
            public override void load_capacity_Info()
            {
                Console.WriteLine($"Митсубиси имеет грузоподъемность: {load_capacity}");
            }
            public override void distance_Info()
            {
                Console.WriteLine($"Митсубиси проехал: {distance}");
            }
        }

        class Tupolev_Tu_134 : Airplane
        {
            public override string speed { get; set; }
            public override double load_capacity { get; set; }
            public override double distance { get; set; }

            public override void speed_Info()
            {
                Console.WriteLine($"скорость Туполев Ту-134 = {speed}");
            }
            public override void load_capacity_Info()
            {
                Console.WriteLine($"Туполев Ту-134 имеет грузоподъемность: {load_capacity}");
            }
            public override void distance_Info()
            {
                Console.WriteLine($"Туполев Ту-134 пролетел: {distance}");
            }
        }

        class Varag : Airplane
        {
            public override string speed { get; set; }
            public override double load_capacity { get; set; }
            public override double distance { get; set; }

            public override void speed_Info()
            {
                Console.WriteLine($"скорость Варяга = {speed}");
            }
            public override void load_capacity_Info()
            {
                Console.WriteLine($"Варяг имеет грузоподъемность: {load_capacity}");
            }
            public override void distance_Info()
            {
                Console.WriteLine($"Варяг прошёл: {distance}");
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
