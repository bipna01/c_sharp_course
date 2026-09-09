public class Array3
{
    public void displayArray3()
    {
        Console.WriteLine($"Enter how many elements you want to store:");
        int size =int.Parse(Console.ReadLine());

        string[] arrayString= new string[size];

        Console.WriteLine($"Enter the number of array:");

        for( int i=0; i<arrayString.Length; i++)
        {
            Console.WriteLine($"Enter element {i+1}");
            arrayString[i]=Console.ReadLine();


        }
        Console.WriteLine($"Array elements are:");

        foreach(string element in arrayString)
        {
            Console.WriteLine(element);
        }

    }
}