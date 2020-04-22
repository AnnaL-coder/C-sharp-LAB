using System;
using System.Collections.Generic;
using System.Text;

namespace man_stud_sport
{
    class ship
    {
        protected string name;
        protected string aimed;
        protected double water_power;
        protected double engine_power;
        protected string type_power;


    }

    class avia : ship
    {
        protected string type_of_planes;
        protected double number_of_planes;
        public void input()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter aimed");
            aimed = Console.ReadLine();
            Console.WriteLine("Enter water_power");
            water_power = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter engine_power");
            engine_power = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter type_power");
            type_power = Console.ReadLine();
            Console.WriteLine("Enter type_of_planes");
            type_of_planes = Console.ReadLine();
            Console.WriteLine("Enter number_of_planes");
            number_of_planes = double.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("name: {0}, aim: {1}, water_power: {2}, engine_poew: {3}, type_power: {4}, type_of_planes: {5}, number_of_planes: {6}",
                name, aimed, water_power, engine_power, type_power, type_of_planes, number_of_planes);
        }
    }
    class rocket : ship
    {
        protected string type_of_rocket;
        protected double number_of_rocket;
        public void input()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter aimed");
            aimed = Console.ReadLine();
            Console.WriteLine("Enter water_power");
            water_power = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter engine_power");
            engine_power = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter type_power");
            type_power = Console.ReadLine();
            Console.WriteLine("Enter type_of_rocket");
            type_of_rocket = Console.ReadLine();
            Console.WriteLine("Enter number_of_rocket");
            number_of_rocket = double.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("name: {0}, aim: {1}, water_power: {2}, engine_poew: {3}, type_power: {4}, type_of_rocket: {5}, number_of_rocket: {6}",
                name, aimed, water_power, engine_power, type_power, type_of_rocket, number_of_rocket);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            avia a = new avia();
            rocket r = new rocket();
            Console.WriteLine("Avia:");
            a.input();
            a.output();
            Console.WriteLine("Rocket:");
            r.input();
            r.output();
        }
    }
}

