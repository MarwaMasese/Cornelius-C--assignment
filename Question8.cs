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



//OverLoading



class Question8
{
    static void main (string[] args){
        //Illustrating Inheritance 
    Cow cow1 = new Cow();
    // Call the eat method from the base class (Animal)
    cow1.Eat();
    Console.WriteLine(cow1.breed + " " + cow1.Family);


    // Illustratin  Overriding

    }
}