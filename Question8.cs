Using system;


//Inheritance 
class Animal  // base class 
    {
    public string Family = "Animalia";  // Vehicle field
    public void eat()             // Vehicle method 
    {                    
        Console.WriteLine("Animal is eating");
    }
    }

class Cow : Animal // Child Class
{
  public string breed = "Fresian";  // Cow field
}



//Overriding 

abstract class Shape
{
    public abstract int GetArea();
}

class Square : Shape
{
    private int _side;

    public Square(int n) => _side = n;

    // GetArea method is required to avoid a compile-time error.
    public override int GetArea() => _side * _side;

    static void Main()
    {
        var sq = new Square(12);
        Console.WriteLine($"Area of the square = {sq.GetArea()}");
    }
}
// Output: Area of the square = 144

// Overload 


  class MethodOverload {  

    // method with one parameter
    void display(int a) {
      Console.WriteLine("Arguments: " + a);
    }
 
    // method with two parameters
    void display(int a, int b) {
      Console.WriteLine("Arguments: " + a + " and " + b);
    } 
  }

// Encapsulation 

public class DemoEncap {
      
    // private variables declared
    // these can only be accessed by
    // public methods of class
    private String studentName;
    private int studentAge;
      
    // using accessors to get and 
    // set the value of studentName
    public String Name
    {
          
        get
        {
            return studentName;    
        }
          
        set 
        {
            studentName = value;
        }
          
    }
      
    // using accessors to get and 
    // set the value of studentAge
    public int Age
    {
          
        get 
        {
            return studentAge;    
        }
          
        set 
        {
            studentAge = value;
        }
          
    }
  
      
}

    //constructors 
        public class Person
            {
                private string last;
                private string first;

                public Person(string lastName, string firstName)
                {
                    last = lastName;
                    first = firstName;
                }

            // Remaining implementation of Person class.
            }
    
    //Default constructors 

    class DefConstruct {

        int num;

        string name;

        // this would be invoked while the

        // object of that class created.

        DefConstruct()

        {

        Console.WriteLine("Constructor Called");

        }
    }

    // destructor 
    class Destroy
        {
            ~Destroy()  // finalizer
            {
                Console.WriteLine("Destructor has been called ");
            }
        }

// properties 

public class Property 
{
    private double number= 60.02;

    public double valueChecker
    {
        get { return number / 2; }
        set
        {
            if ( value > 50)
                Console.WriteLine("This number is big");
            number = value ;
        }
    }
}


// try catch 
class Trycatch
{
    public Handle(){
        try
        {
            Console.WriteLine("Enter a number: ");

            var num = int.parse(Console.ReadLine());

            Console.WriteLine($"Squre of {num} is {num * num}");
        }
        catch(Exception ex)
        {
            Console.Write("Error info:" + ex.Message);
        }
        finally
        {
            Console.Write("Re-try with a different number.");
        }
    }
}


class Question8
{
    static void main (string[] args){
        //Illustrating Inheritance 
    Cow cow1 = new Cow();
    // Call the eat method from the base class (Animal)
    cow1.Eat();
    Console.WriteLine(cow1.breed + " " + cow1.Family);


    // Illustrating  Overriding

    // Illustrating encapsulation

        // creating object
            DemoEncap obj = new DemoEncap();
            obj.Name = "Caroline Waruingi";
            obj.Age = 21;
    
            // Displaying values of the variables
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);

    // default constructor 

            DefConstruct def1 = new DefConstruct();
            Console.WriteLine(def1.name);
            Console.WriteLine(def1.num);

    
    //Illustrating property
            Property prop1 = new Property();
            prop1.valueChecker();

    // Exception Handling 
            Trycatch error1 = new Trycatch();
            error1.Handle();
    }


    



}