using System;

namespace test.Lavrenko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students");
            int n = int.Parse(Console.ReadLine());
            Student[] A = new Student[n];
            for (int i = 0; i < n; i++)
                A[i] = new Student();
            for (int i = 0; i < n; i++)
                A[i].InputStudent();

            bool execution= true;

            while (execution)
            {   
                Console.WriteLine("\nA. Search Student by Lastname");
                Console.WriteLine("B. Search Student by Group");
                Console.WriteLine("C. Exit");

                string action;
                action = Console.ReadLine();

                switch(action)
                {
                    case "A":
                        Console.WriteLine("\n Enter Lastname of Student");
                        string SLastname = Console.ReadLine();
                        for (int i = 0; i < n; i++)
                            A[i].FindByLastname(A[i], SLastname);
                        break;
                    case "B":
                        Console.WriteLine("\n Enter Group of Student");
                        string SGroup = Console.ReadLine();
                        for (int i = 0; i < n; i++)
                            A[i].FindByGroup(A[i], SGroup);
                        break;
                    case "C":
                        execution = false;
                        break;
                }
                

            }
        }
    }
}
