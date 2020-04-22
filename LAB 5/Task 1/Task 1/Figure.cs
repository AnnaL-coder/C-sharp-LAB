using System;

namespace lab5
{
    abstract class Figure
    {
        abstract public void Show();
        abstract public double Param();
        abstract public double Plosh();

    }

    class Program
    {
        static void Main()
        {
            Rectangle rec1 = new Rectangle();
            Triangle tri1 = new Triangle();
            Circle cir1 = new Circle();
            Console.WriteLine("Enter a, b of rectangle");
            rec1.a = int.Parse(Console.ReadLine());
            rec1.b = int.Parse(Console.ReadLine());
            rec1.Show();
            double par;
            par = rec1.Param();
            double pl;
            pl = rec1.Plosh();
            Console.WriteLine("Parametr={0}", par);
            Console.WriteLine("Plosh={0}", pl);

            Console.WriteLine("Enter a, b, c of tiangle");
            tri1.a = int.Parse(Console.ReadLine());
            tri1.b = int.Parse(Console.ReadLine());
            tri1.c = int.Parse(Console.ReadLine());
            par = tri1.Param();
            pl = tri1.Plosh();
            Console.WriteLine("Parametr={0}", par);
            Console.WriteLine("Plosh={0}", pl);

            Console.WriteLine("Enter r of circle");
            cir1.r = int.Parse(Console.ReadLine());
            par = cir1.Param();
            pl = cir1.Plosh();
            Console.WriteLine("Parametr={0}", par);
            Console.WriteLine("Plosh={0}", pl);

        }
    }

}
