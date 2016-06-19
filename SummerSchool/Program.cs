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
            Console.WriteLine("Student to be enrolled");
            Console.WriteLine("Students to be unenrolled");
            Console.WriteLine("Roster of Enrolled students");
            Console.WriteLine("Exit Menu");

            while (true)
            {

                //print out the menu
                int menuchoice = Convert.ToInt32(Console.ReadLine());
                if (menuchoice == 1)


                {
                    EnrollStudent(); //initiate the method to enroll students 
                    Console.WriteLine( "Enter the name of the student you wish to enroll.");

                    
                }
            }
        }

        /* else
         {
             Console.WriteLine("Chose {0} to unenroll a student, then press enter.");
             Console.ReadKey(); // I have kept this here as a reminder of what I need to do if the person does not choose to enroll. I 
         }*/

        static void EnrollStudent() //Jael Here is the method that you need to create to use to enroll the students

        {
            string[15] enrolledstudents = { "Angelina Thornton", "Pam Barnett", "Carol Gomez", "Marty Marshall", "Alison Gomez", "Kyle Lawson", "Jean Gray", "Scott Summers", "Hank McCoy", "Mo JoJo", "Bloosom Puff", "Bubbles Puff", "Buttercup Puff", "Barney Rub", "Fred Flint", };

            /* PrintArray(students);  where would I add this*/
        }

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
 /*static void Main(string[] args)
{
    string[] enrolledstudents = new string[15];
    Console.WriteLine("Let's grab 5 strings!");
    for (int i = 0; i < 15; i++)
    {
        Console.WriteLine("Enter a sentence then press enter.");
        myArray[i] = Console.ReadLine();
    }
    Console.WriteLine("Great! Here's what I read:");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(myArray[i]);
    }*/