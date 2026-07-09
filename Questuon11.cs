//Store the price and quantity of three products and calculate the total bill.
public class Question11
{
    public void Bill()
    {
        double pen ;
         double price1= 10;
         double quantity1 =3;

         double copy;
         double price2=100;
         double quantity2 = 4;

         double book;
         double price3 = 400;
         double quantity3 =2;

         double bill;
         bill= (price1*quantity1)+(price2*quantity2)+(price3*quantity3);
         Console.WriteLine($"the total bill of pen, copy and book is {bill}");
    }
}