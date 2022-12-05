using System;

class Swap: Question7 {

   public SwapNumbers(){
    // value of first is assigned to temp
    temp = first;

    // value of second is assigned to first
    first = second;

    // value of temp (initial value of first) is assigned to second
    second = temp;
   }
}

class Question7
{
    int first, second, temp; 
   public static void Main(string[] args)
   {
    Console.WriteLine("Enter first number:");
    first = Convert.ToInt32(Console.Readline());
    Console.WriteLine("Enter second number:");
    second = Convert.ToInt32(Console.Readline());

    //output before swapping
    Console.WriteLine("\n Numbers Before Swapping are {}  {}\n" , first, second);

    Swap SwapExample = new Swap();
    SwapExample.SwapNumbers();

    //output after swapping 
    Console.WriteLine("\n Numbers after swapping are \n", SwapExample.first, SwapExample.second);



   }
}