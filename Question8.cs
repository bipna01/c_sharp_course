//Declare variables for principal, rate, and time, then calculate simple interest.

public  class Question8
{
    public void SI()
    {
        double principal = 5000;
         double rate = 10;
         double time = 3;

         double si;
         si =(principal*rate*time)/100;

         Console.WriteLine($" The simple interest is {si}");
    }
}