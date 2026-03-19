using System;

public class GradeBook
{
    public string CourseName { get; set; }//auto-implemented properties

    public int NumOfCredits { get; set; }

    public string CourseNum { get; set; }

    public GradeBook(string cName, int credits, string cNum)//constructor
    {
        CourseName = cName;
        NumOfCredits = credits;
        CourseNum = cNum;
    }
    public decimal CalcAverage()//property method
    {
        decimal total = 0;//local variable

        int count = 1;
        while(count <= 5)
        {
            Console.Write("Please enter a grade: ");
            int grade = int.Parse(Console.ReadLine());

            total = total + grade;

            count = count + 1;
        }
        decimal avg = total / (count - 1);//local variable

        return avg;
    }
}