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
            Console.WriteLine("2016 Summer Student Enrollment for Hogwarts Academy");
            Console.WriteLine("1. Student enrollment");
            Console.WriteLine("2. Student unenrollment");
            Console.WriteLine("3. Roster of Enrolled students");
            Console.WriteLine("4. Exit Menu");

            while (true)
            {
                Console.WriteLine("2016 Summer Student Enrollment for Hogwarts Academy");
                Console.WriteLine("1. Student enrollment");
                Console.WriteLine("2. Student unenrollment");
                Console.WriteLine("3. Roster of Enrolled students");
                Console.WriteLine("4. Exit Menu");
                //print out the menu
                int menuchoice = Convert.ToInt32(Console.ReadLine()); // Why is the Convert.ToInt32 used?
                if (choice == 1)

                {
                    EnrollStudent(); //initiate the method to enroll students 
                    Console.WriteLine("Enter the name of the student you wish to enroll.");
                }
                else if (choice == 2)
                {
                    Unenrollstudent();
                    //Console.WriteLine("Choose 2 to unenroll a student, then press enter.");
                    //Console.ReadKey(); I have kept this here as a reminder of what I need to do if the person does not choose to enroll. I 
                }
                else if (choice == 3)
                {
                    PrintStudent();
                }

                else if (choice == 4)
                {
                    //quit
                    break;
                }
               else 
                {
                    //Unknown choice!
                    Console.WriteLine("Please enter a number 1-4");

                }
             }
            Console.ReadKey();
        }

       

        static void EnrollStudent() //Jael Here is the method that you need to create to use to enroll the students
        {
            Console.WriteLine("Enter the name of student to enroll.");
            string[] student = Console.ReadLine();

            // put the students in the next free spot.
            int spot = GetNextFreeSpot();

            Students[spot] = student;
            if (spot == -1)
            {
                Console.WriteLine("Enrollment is Full.");
                Console.WriteLine("Press enter to return to main menu.");
                Console.ReadKey();
            }
            else
            {
                Students[spot] = stu;
                //method to find next available spot in students
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


*/
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


/* Notes from Today

static 

//Finding the next free spot

for (int i = 0; 1 < Students.Lenght; i++)


/* int spot = GetNext
                         