﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        static string[] Students = new string[15];

        static void Main(string[] args)

        {
            string student = Console.ReadLine();
            Console.WriteLine("2016-2017 Student Enrollment for Hogwarts Academy");
            Console.WriteLine("Student to be Enrolled");
            Console.WriteLine("Students unenrolled");
            Console.WriteLine("Roster of Enrolled students");
            Console.WriteLine("Exit Menu");

            while (true)
            {

                //print out the menu
                int menuchoice = Convert.ToInt32(Console.ReadLine());
                if (menuchoice == 1)


                {
                    EnrollStudent(); //initiate the method to enroll students 
                }
            }
        }

        /* else
         {
             Console.WriteLine("You can do it, Try Again! Press enter to try again!");
             Console.ReadKey();
         }*/

        static void EnrollStudent() //Jael Here is the method that you need to create to use to enroll the students

        {
            string[15] students = {"Angelina Thornton", "Pam Barnett", "Carol Gomez", "Marty Marshall", "Alison Gomez", "Kyle Lawson", "Jean Gray","Scott Summers","Hank McCoy","Mo JoJo","Bloosom Puff","Bubbles Puff","Buttercup Puff","Barney Rub","Fred Flint",};
                
        }
         

       
        /*while (true)
        {
            //print out the menu
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)

            {
                EnrollStudent();
            }
        }
    }

     static void EnrollStudent()
    {
        Students[1] = "Bob";*/
    }
}
    }
}


/*"Angelina Thornton(£200)";
            Students[2] = "Pam Barnett(£200";
            Students[2] = "Carol Gomez(£190)";
            Students[2] = "Marty Marshall(£180)";
            Students[2] = "";
                 Students[2]
                 Students[2]
                 Students[2]
                 Students[2]
                 Students[2]
                 Students[2]
                 Students[2]
                 Students[2]
                 Students[2]
                 Students[2]*/
/* 1. Angelina Thornton(£200)
2. Pam Barnett(£200)
3. Carol Gomez(£190)
4. Marty Marshall(£180)
5. Gordon Griffith(£180)
6. Alison Gomez(£190)
7. Kyle Lawson(£200)
*/