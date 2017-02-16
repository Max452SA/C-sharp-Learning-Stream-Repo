// Modified LetterGrades.cs
// using a switch statement to count letter grades from A - F

using System;

namespace LetterGradesCh6
{
    class LetterGrades
    {
        static void Main(string[] args)
        {
            int total = 0;
            int gradeCounter = 0;
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;
            int dCount = 0;
            int eCount = 0;
            int fCount = 0;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  Enter the integer grades in the range 0-100: ");
            Console.WriteLine("  Type <Ctrl> z and Press Enter to terminate ");

            string input = Console.ReadLine();  //reads user input

            //loop until end of file indicator will be a null value - user presses <Ctrl> z 
            while (input != null)
            {
                int grade = int.Parse(input);
                total += grade;
                gradeCounter++;

                //determine the value of the grade entered using integer division
                switch ( grade / 10)
                {
                    case 10:        //grade was a 100
                    case 9:         //grade was a 90+
                        aCount++;
                        break;
                    case 8:         //grade was 80-89
                        bCount++;
                        break;
                    case 7:         //grade was 70-79
                        cCount++;
                        break;
                    case 6:         //grade was 60-69
                        dCount++;
                        break;
                    case 5:         //grade was 50-59
                        eCount++;
                        break;
                    default:        //grade was below 50
                        fCount++;
                        break;
                }// end switch

                input = Console.ReadLine(); //reads user input before loop is tested again
            }// end while (input != null)

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" \n\tGrade Report ");
            Console.WriteLine();
            Console.WriteLine();

            if (gradeCounter != 0 )
            {
                double average = (double)total / gradeCounter;

                Console.WriteLine($"  Total number of grades entered is: {gradeCounter} ");
                Console.WriteLine($"  The sum total of all grades is: {total} ");
                Console.WriteLine($"  The Class Average is: {average:F} ");
                Console.WriteLine("  Breakdown of each Grade: ");
                Console.WriteLine();
                Console.WriteLine($"  A: {aCount} ");
                Console.WriteLine($"  B: {bCount} ");
                Console.WriteLine($"  C: {cCount} ");
                Console.WriteLine($"  D: {dCount} ");
                Console.WriteLine($"  E: {eCount} ");
                Console.WriteLine($"  F: {fCount} ");
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("  No grades were entered? ");
            }

        }// end Main
    }// end class LetterGrades
}// end namespace LetterGradesCh6
