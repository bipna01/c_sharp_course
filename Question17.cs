/*Display Student Information**
Create a function `DisplayStudent()` with **no arguments and no return type**.

The function should display:

```text
Name: Apar
Age: 29
City: Pokhara
```

Call the function from `Main()`.
*/


public class Question17
{
    public void DisplayStudent()
    {
        string name= "bipana";
        int age = 16 ; 
        string city = "pokhara";

        Console.WriteLine($"Name:{name}");
        Console.WriteLine($"Age:{age}");
        Console.WriteLine($"City:{city}");
    }
}