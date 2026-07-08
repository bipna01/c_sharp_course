using System;
class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine("hello world");
        
        Question2 question2 = new Question2();
        question2.Sum(1,2);
         
         Question3 question3 = new Question3();
         question3.Calculate();
 

        Question4 question4 = new Question4();
        question4.Area();

        Question5 question5 = new Question5();
        question5.Swap();

        Question6 question6 = new Question6();
        question6.Swapping();

        Question7 question7 = new Question7();
        question7.perimeter();

        Question8 question8 = new Question8();
        question8.SI();

        Question9 question9 = new Question9();
        question9.Average();

        Question10 question10 = new Question10();
        question10.Convert();

    }
}

