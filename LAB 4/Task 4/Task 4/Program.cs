using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of product");
            int n = int.Parse(Console.ReadLine());
            Sklad[] A = new Sklad[n];

            for (int i = 0; i < n; i++)
                A[i] = new Sklad();
            for (int i = 0; i < n; i++)
                A[i].Inputonfo();

            bool execution = true;

            while (execution)
            {
                Console.WriteLine("\nA. Search Product by DATE");
                Console.WriteLine("B. Search Product by PRICE");
                Console.WriteLine("C. Search Product by SIZE");
                Console.WriteLine("D. Exit");

                string action;
                action = Console.ReadLine();

                switch (action)
                {
                    case "A":
                        Console.WriteLine("\n Enter DATETOCOME");
                        string date = Console.ReadLine();
                        for (int i = 0; i < n; i++)
                            A[i].FindByDatetocome(A[i], date);
                        break;
                    case "B":
                        Console.WriteLine("\n Enter  price");
                        double Price;
                        Price = double.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                            A[i].FindByPrice(A[i], Price);
                        break;
                    case "C":
                        Console.WriteLine("\n Enter size");
                        int Size;
                        Size = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                            A[i].FindByPrice(A[i], Size);
                        break;
                    case "D":
                        execution = false;
                        break;
                }

            }
        }
    }
}
