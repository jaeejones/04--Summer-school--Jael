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
            while (true)
            {
                Console.WriteLine("2016 Summer Student Enrollment for Hogwarts Academy");
                Console.WriteLine("1. Student enrollment");
                Console.WriteLine("2. Student unenrollment");
                Console.WriteLine("3. Roster of Enrolled students");
                Console.WriteLine("4. Exit Menu");
                //print out the menu

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)

                {
                    EnrollStudent(); //initiate the method to enroll students 
                    //Console.WriteLine("Enter the name of the student you wish to enroll.");
                    //Console.WriteLine("Press enter to continue.");
                }
                else if (choice == 2)
                {
                    Unenrollstudent();
                    //Console.WriteLine("Choose 2 to unenroll a student, then press enter.");
                    //Console.WriteLine("Press enter to continue.");
                }
                else if (choice == 3)
                {
                    Printlist();
                }
               else if (choice == 4)
                {
                     ExitMenu();
                 
                }
                else
                {
                    //Unknown choice!
                    Console.WriteLine("Please choose between 1-4.");

                }
            }

            Console.ReadKey();
        }



        static void EnrollStudent()
        {
            Console.WriteLine("Enter the name of student to enroll.");
            string student = Console.ReadLine();

            int spot = GetNextFreeSpot(); // put the students in the next free spot.

            if (spot >= 0)
            {
                Students[spot] = student;

                Console.WriteLine("\n {0} Student enrolled \n {0} £200 owed in class fees.\n", student);
                Console.WriteLine("Press Enter to continue.");
                Console.ReadKey();
            }

            else if (student.ToLower() == "malfoy")
            {
                Console.WriteLine("Student cannot be enrolled!");
            }
            else if (student.ToLower() == "potter")
            {
                Console.WriteLine("Student enrollment complete. Free is discounted at half off.Fee £100");
            }
            else if (student.ToLower() == "longbottom")
            {
                if (spot < 10)
                {

                    Console.WriteLine("Enrollemnt complete, no fee's owed");
                }
            }
            else if (student.ToLower() == "tom")
            {
                Console.WriteLine("RED ALERT!!!HE WHO MUST NOT BE NAMED!!!");
            }
            else if (student.ToLower() == "riddle")
            {
                Console.WriteLine("RED ALERT!!!HE WHO MUST NOT BE NAMED!!!");
            }
            else if (student.ToLower() == "voldemort")
            {
                Console.WriteLine("RED ALERT!!!HE WHO MUST NOT BE NAMED!!!");
            }
            else
            {
                Console.WriteLine("Enrollment is Full.");
                Console.WriteLine("Press enter to return to main menu.");
                Console.ReadKey();
            }
        }
        static void Unenrollstudent()

        {
            Printlist();

            Console.WriteLine("Choose the numeber you want to remove a student.");
            int choice = Convert.ToInt32(Console.ReadLine());

            Students[choice - 1] = null;
            Console.WriteLine("Student had been unenrolled");

        }

        static void Printlist()
        {
            for (int i = 0; i < Students.Length; i++)

                if (Students[i] != null)

                {
                    Console.WriteLine(i + 1 + "." + Students[i]);
                }
        }

      static void ExitMenu()
        {
            Console.WriteLine("Press enter to exit the system");
            Console.ReadKey();

        }


        static int GetNextFreeSpot()

        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] == null)
                {
                    //we found one!
                    return i;
                }
            }

            // if we get through menu
            return -1;

        }
    }
}
















