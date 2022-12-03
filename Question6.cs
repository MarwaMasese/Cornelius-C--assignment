using System;

class ListSorting{
    public Input(){
        Console.WriteLine("Enter The number if items you want to work with ");
    int NumberOfItems = Convert.ToInt32(Console.ReadLine());
    int [] SetOfNumbers = new int [NumberOfItems];

    for( int i = 0 ; i< NumberOfItems; i++){
        Console.WriteLine("Enter Item");
        int element = Convert.ToInt32(Console.ReadLine());
        SetOfNumbers[i]=element;
    }
    }

    public Output(){
        Console.WriteLine("This is the array before sorting");
    foreach (int item in SetofNumbers){
        Console.Write(item);
    }

    Console.WriteLine("Array after sorting");
    int [] SortedSetOfNumbers = new Int[NumberOfItems];
    int counter = 0; 
    for(int j =0 ; j<SetOfNumbers.Length; j++){
        for(int k =0; k< SetOfNumbers.Length; k++){
            if(SetOfNumbers[i]< SetOfNumbers[k]){
                SortedSetOfNumbers[counter]= SetOfNumbers[k];
                counter +1 ;
            }
        }
    }
    Console.WriteLine("Sorted Array is ");
    foreach (int member in SetOfNumbers){
        Console.Write(member);
    }
    }
}
class Question6
{
   public static void Main(string[] args)
   {
    
    ListSorting example1 = new ListSorting();
    example1.Input();
    example1.Output();

   }
}