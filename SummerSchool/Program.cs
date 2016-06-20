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
                int choice = Convert.ToInt32(Console.ReadLine()); // Why is the Convert.ToInt32 used?
                if (choice == 1)

                {
                    EnrollStudent(); //initiate the method to enroll students 
                    Console.WriteLine("Enter the name of the student you wish to enroll.");
                    Console.WriteLine("Press enter to continue.");
                }
                else if (choice == 2)
                {
                    //Unenrollstudent();
                    //Console.WriteLine("Choose 2 to unenroll a student, then press enter.");
                    //Console.WriteLine("Press enter to continue.");
                }
                else if (choice == 3)
                {
                    //PrintStudent();
                }

                else if (choice == 4)
                {
                    //quit
                    break;
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


            // put the students in the next free spot.
            int spot = GetNextFreeSpot();


            if (spot == -1)
            {
                Console.WriteLine("Enrollment is Full.");
                Console.WriteLine("Press enter to return to main menu.");
                Console.ReadKey();
            }
            else
            {
                Students[spot] = student;
                //method to find next available spot in students
            }
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

            // if we get through the whole 
            return -1;

        }
    }
}






            /*static int //I am confused on how to use the string/loop method to enroll students. 
    {
       string[] enrolledstudents = new string[15];
       Console.WriteLine("Choose student enrollment to add a student.");
       for (int i = 0; i < 15; i++)
       {
           Console.WriteLine("Enter the name of the student.");
           myArray[i] = Console.ReadLine();
       }
       Console.WriteLine("Student had been enrolled");
       for (int i = 0; i < 5; i++)
       {
           Console.WriteLine(myArray[i]);
       }*/
            /* PrintArray(students);  where would I add this
            
    private static void PrintStudents ()
    {
    }*/


// two loops will need to be created to add enroll/unenroll 2. To return the main menu without a break in program. 
/* static void PrintArray(string[] array)
 {
     for (int i = 0; i < array.Length; i++)
     {
         Console.WriteLine(array[i]);
     }
 }

 static int IndexOf(string[] array, string element)
 {
     for (int i = 0; i < array.Length; i++)
     {
         if (array[i] == element)
         {
             return i;
         }
     }
     return -1; */




/* static void EnrollStudent()
{
    Students[1] = "Bob";*/



/*static void Main(string[] args) //I am confused on how to use the string/loop method to enroll students. 
{
   string[] enrolledstudents = new string[15];
   Console.WriteLine("Choose student enrollment to add a student.");
   for (int i = 0; i < 15; i++)
   {
       Console.WriteLine("Enter the name of the student.");
       myArray[i] = Console.ReadLine();
   }
   Console.WriteLine("Student had been enrolled");
   for (int i = 0; i < 15; i++)
   {
       Console.WriteLine(myArray[i]);
   }*/
/*static void Main(string[] args) // I am confused on how to use a string and loop to remove a student. 
{
    string[] enrolledstudents = new string[15];
    Console.WriteLine("Choose student unenrollment to remove a student.");
    for (int i = 0; i < 15; i++)
    {
        Console.WriteLine("Enter the name of the student.");
        myArray[i] = Console.ReadLine();
    }
    Console.WriteLine("Student had been unerolled");
    for (int i = 0; i < 15; i++)
    {
        Console.WriteLine(myArray[i]);
    }*/
// when i is equal to 15 (enrollment is full) is need choice 1 unenroll student to disapear because class full, I am not
// certain on how to display this. 
// what method would I use to remove the uneroll student option option once the roster had been filled. 
// What method would I use 
//What method would I use to save the name of the student once the student has been enrolled, have we even learned this?


   