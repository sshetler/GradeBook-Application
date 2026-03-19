using System;


public class GradeBookTest
{
    public static void Main()
    {
        Console.Write("Please enter the course name: ");
        string cName = Console.ReadLine();

        Console.Write("Please enter the number of credits for the course: ");
        int credits = int.Parse(Console.ReadLine());

        Console.Write("Please enter the course number: ");
        string cNum = Console.ReadLine();

        GradeBook mygb = new GradeBook(cName, credits, cNum);//header variables

        decimal avg = mygb.CalcAverage();

        Console.WriteLine("The average of the 5 students is: " + avg);

    }
}
