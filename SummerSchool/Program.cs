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
            Console.WriteLine("Student to be Enrolled");
            Console.WriteLine("Students unenrolled");
            Console.WriteLine("Roster of Enrolled students");
            Console.WriteLine("Exit Menu");

            while (true)
            {

                //print out the menu
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)


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


