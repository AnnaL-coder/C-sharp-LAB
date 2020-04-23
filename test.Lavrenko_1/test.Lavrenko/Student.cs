using System;

namespace test.Lavrenko
{
    class Student
    {
        string lastname;
        string firstname;
        string group;
        double average_mark;
        string budget_or_not;

        public Student()
        {
        }
      

        public void InputStudent()
        {
            string lastname;
            string firstname;
            string group;
            double average_mark;
            string budget_or_not;
            Console.WriteLine("\n Enter lastname");                                                  
            lastname = Console.ReadLine();
            Console.WriteLine(" Enter firstname");
            firstname = Console.ReadLine();
            Console.WriteLine(" Enter group");
            group = Console.ReadLine();
            Console.WriteLine(" Enter average_mark");
            average_mark = double.Parse(Console.ReadLine());
            if(average_mark<0)
            {
                Console.WriteLine("Value of mark is wrong");
            }
            Console.WriteLine(" Enter budget_or_not(yes/no)");
            budget_or_not = Console.ReadLine();

            this.lastname = lastname;
            this.firstname = firstname;
            this.group = group;
            this.average_mark = average_mark;
            this.budget_or_not = budget_or_not;
        }

        public void Getinfo(Student info )
        {
            Console.WriteLine("\n Firstname:{0} Lastname: {1} Group: {2}", info.firstname, info.lastname, info.group);
            Console.WriteLine(" Average mark: {0}, Budget: {1}", info.average_mark, info.budget_or_not);
        }

       
        public void FindByLastname(Student info, string lastname)
        {
            if(info.lastname==lastname)
            {
                Getinfo(info);
            }
        }

        public void FindByGroup(Student info, string group)
        {
            if (info.group == group)
                Getinfo(info);
        }


    }


}
