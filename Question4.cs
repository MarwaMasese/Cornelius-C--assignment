Using System;

class Items{
    private int ProductCode;
    private double Price,Discount, Quantity, Total, Discount, Net;
    int NumberOfItems;


    public double Price  // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
    
    public double Quantity // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
    public double Total  // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

    public Items(int ProductCode, double Price, double Quantity){
        ProductCode= ProductCode;
        Price= Price;
        Quantity= Quantity;
    }

    public Input(){
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
    public Calculate(){
       Total = Price * Quantity;
       if(Total>20000){
        Discount = 0.14* Total;
        Net = Total- Discount;
       }
       else if(Total >= 10000 && Total<= 20000){
        Discount= 0.1 * Total;
        Net = Total- Discount;
       }
       else if (Total < 1000){
            Discount = 0 ;
            Net = Total- Discount;
       }

    }
    public OutPut(){
        for(int i = 0 ; i< list.length() ; i++){
            Console.WriteLine("\n Item Code     Price          Quantity         Total Cost     Discount            Net  \n");
            Console.WriteLine("\n {}     {}          {}         {}     {}            {}  \n", list[i].ProductCode, list[i].Price, list[i].Quantity, list[i].Total, list[i].Discount, list[i].Net);
        }
    }
    }

class Question4
    {
        public static void main (string[] args){
            Items item1 = new Items();
            item1.Input();
            item1.Calculate();
            item1.Output();
            

    }
}