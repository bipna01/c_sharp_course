public class Array4
{
    public void displayArray4()
    {
         Console.WriteLine($"Enter how many elements you want to store:");
        int size =int.Parse(Console.ReadLine());

        double[] arrayDouble= new double[size];

        Console.WriteLine($"Enter the number of array:");

        for( int i=0; i<arrayDouble.Length; i++)
        {
            Console.WriteLine($"Enter element {i+1}");
            arrayDouble[i]= Convert.ToDouble(Console.ReadLine());


        }
        Console.WriteLine($"Array elements are:");

        foreach(double element in arrayDouble)
        {
            Console.WriteLine(element);
        }
    }
}