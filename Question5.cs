using System;

class Question5
{
   public static void Main(string[] args)
   {
        Console.WriteLine("Enter The number if items you want to work with ");
        NumberOfItems = Convert.ToInt32(Console.ReadLine());
        Items [] list = new Items[NumberofItems];
        int NumberOfItems= Convert.ToDouble(Console.Readline());
         for(int i = 0 ; i< NumberofItems ; i++){
            Console.WriteLine("Enter Item Code  ");
            ProductCode= Convert.ToDouble(Console.Readline());
            Console.WriteLine("Enter Item Price  ");
            Price= Convert.ToDouble(Console.Readline());
            Console.WriteLine("Enter Item Quantity  ");
            Quantity= Convert.ToDouble(Console.Readline());
            listofitems[i]= Items(ProductCode, Price, Quantity);

        }
   }
}