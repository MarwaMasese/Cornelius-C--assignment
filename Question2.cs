Using System;

class Loop{
    private int total, member;
    private int EvenSum, OddSum = 0 ;
    

    public Input(){
        Console.WriteLine("Enter the length of the array");
        total = Convert.ToInt32(Console.Readline());
        int [] integers = new int[total];
        for(int i = 0 ; i<total ; i++){
            Console.WriteLine("Enter an integer  Member of array");
            member = Convert.ToInt32(Console.Readline());
            integers[i]= member;
        }  
    }
    public Output(){
       for(int i = 0; i <= integers.Length(); i++){
                if(integer[i] %2== 0){
                    Console.WriteLine(integers[i]+ "is an even number");
                    int EvenIntegerIndex = 0;
                    int [] EvenNumbers= new int[total];
                    EvenNumbers[EvenIntegerIndex]= integers[i];
                    EvenIntegerIndex +=1;
                    Console.WriteLine(integers[i]+ "is an even number");
                    foreach(int theValue in EvenNumbers)
                        {
                            EvenSum = EvenSum + theValue;
                        }
                }
                else if(integer[i] %2== 1){
                    Console.WriteLine(integers[i]+ "is an even number");
                    int OddIntegerIndex = 0;
                    int [] EvenNumbers= new int[total];
                    OddNumbers[OddIntegerIndex]= integers[i];
                    OddIntegerIndex +=1;
                    Console.WriteLine(integers[i] + "is an odd number");
                    foreach(int Value in OddNumbers)
                        {
                            OddSum = OddSum+ Value;
                        }
                        
                }
        } 
        Console.WriteLine("There are {} even numbers ", EvenNumbers.Length());
        Console.WriteLine("There are {} odd numbers ", OddNumbers.Length());
        Console.WriteLine("The sum of even numbers is {} ", OddSum);
        Console.WriteLine("The sum of even numbers is {} ", EvenSum);
    }
}

class Question2
    {
        public static void main (string[] args){
            Loop Example1 = new Loop();
            Example1.Input();
            Example1.Output();
    }
}