Using System;

class InterestRate{
    private double Amount, InterestRate, TargetAmount, Years, Interest, EndBalance;
    public Input(){
        Console.WriteLine("Enter the Amount");
        Amount = Convert.ToInt32(Console.Readline());
        Console.WriteLine("Enter Interest rate ");
        InterestRate = Convert.ToInt32(Console.Readline());
        Console.WriteLine("Enter Target Amount");
        TargetAmount  = Convert.ToInt32(Console.Readline());

        Years = 0;
        Interest = 0;
        InterestRate = InterestRate/ 100.0;
        EndBalance = Amount + Interest;
        
    }
    public Output(){
        do {
        EndBalance = EndBalance + Amount + Interest;
        Years += 1;
        Interest = (EndBalance + Amount) * rate;
    } while (EndBalance <= TargetAmount); 
        Console.WriteLine("It will take {} years for your money to reach your target.", Years);
        Console.WriteLine("By the end of this period, the amount in your account will be {}", EndBalance);
        printf("\n In year %d, balance %.2lf reaches target %.2lf", year, balance, target);

}
    }

class Question3
    {
        public static void main (string[] args){
            InterestRate calculate1 = new InterestRate();
            calculate1.Input();
            calculate1.Output();
    }
}