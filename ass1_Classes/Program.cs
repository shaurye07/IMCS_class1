using System;
using System.Collections.Generic;
using System.Collections;


namespace Stud_directory
{
    public class Stud_details
    {
        public int ID { get; set; }
        public String F_name { get;  set; }
        public String L_name { get; set; }
        public String email { get; set; }
        public long Cell_Number { get; set; }


    }

    class Program :Stud_details
    {
        
        
        static void Main(string[] args)
        {
            List<Stud_details> studs = new List<Stud_details>(3);

            Stud_details current1 = new Stud_details()
            {
                ID=1,
                F_name="Shaurye",
                L_name="Bhatnagar",
                email="bhat.shaur@gmail.com",
                Cell_Number=7632863
            };

            studs.Add(current1);

            Stud_details current2 = new Stud_details()
            {
                ID = 1,
                F_name = "Rohit",
                L_name = "Sharma",
                email = "sharma.rohit@gmail.com",
                Cell_Number = 7627392
            };

            studs.Add(current2);
            while (true)
            {
                Console.WriteLine("Welcome to Student Directory !");
                Console.WriteLine("Please select the course of action:\n 1. Add Record\n 2. Display Record");
                int ans = Convert.ToInt32(Console.ReadLine());

                if (ans == 1)
                {
                    Stud_details student = new Stud_details();

                    Console.WriteLine("Id: ");
                    student.ID = Convert.ToInt32(Console.Read());
                    Console.WriteLine("First Name: ");
                    student.F_name = Console.ReadLine();
                    Console.WriteLine("Last Name: ");
                    student.L_name = Console.ReadLine();
                    Console.WriteLine("Email: ");
                    student.email = Console.ReadLine();
                    Console.WriteLine("Telephone");
                    student.Cell_Number = Convert.ToInt32(Console.Read());

                    studs.Add(student);


                }
                else
                {
                    foreach (var studen in studs)
                    {
                        Console.WriteLine("ID: " + studen.ID);
                        Console.WriteLine("First Name: " + studen.F_name);
                        Console.WriteLine("Last Name: " + studen.L_name);
                        Console.WriteLine("Email: " + studen.email);
                        Console.WriteLine("Cell Number: " + studen.Cell_Number);
                    }
                }

                Console.WriteLine("Do you want to continue: Y/N?");
                char ans2 = Convert.ToChar(Console.ReadLine());
                if (ans2 == 'N' || ans2 == 'n') { break; }


            }


        }
    }
}
