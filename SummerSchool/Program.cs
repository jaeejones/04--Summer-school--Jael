using System;
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
            while (true)
            {


                Console.WriteLine("Are your eyes on the teacher?");
                string eyes = Console.ReadLine();
                if (eyes == "yes")
                {
                    Console.WriteLine("Student to be Enrolled");
                    Console.WriteLine("Students unenrolled");
                    Console.WriteLine("Roster of Enrolled students");
                    Console.WriteLine("Exit Menu");


                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        // child typed typed "Yes" this code is executed.
                        Console.WriteLine("You are a very good listener!");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();


                    }
                    else
                    {
                        // child did not type "yes" this code is executed. 
                        Console.WriteLine("Try again, you can do!");

                        /*Console.ReadLine();*/

                        // added Console.ReadKey and commented out Console.ReadLine

                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }
                }

                else
                {
                    Console.WriteLine("You can do it, Try Again! Press enter to try again!");
                    Console.ReadKey();
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

