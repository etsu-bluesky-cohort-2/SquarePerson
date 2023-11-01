namespace Square;

public class Program
{
    public static void Main(string[] args)
    {
        ///                       aurgument 1, aurgument 2
        ///System.Console.WriteLine(Add(25.25, 54.52));
        /*
        Square mattsBox = new Square(); //instantiation
        System.Console.WriteLine(mattsBox.Area());
        mattsBox.Side = 85;

        mattsBox = new Square();

        System.Console.WriteLine(mattsBox.Area());

        Square bensBox = new Square(25.25);

        Square willsBox = new Square("85.98");

        Box box1 = new Box();


        //mattsBox.Side = 20; //uses the set

       /// mattsBox.Side = 85;

        System.Console.WriteLine(mattsBox.Area()); //uses the get
        System.Console.WriteLine(bensBox.Area()); //uses the get
        System.Console.WriteLine(willsBox.Area()); //uses the get
        */
            //0x01F
        Person person = new Person("Mathew", "Desjardins", 5, 10);


      
        Object obj = new object();

       
        //this is a shallow copy
        //Person person2 = person;

        

        //this is a deep copy
        Person person2 = new Person(person);

       System.Console.WriteLine(person.Equals(person2));


      // System.Console.WriteLine(person.Birthdate);

       System.Console.WriteLine(person);
       System.Console.WriteLine(person2);


    
       
    }

                            //parameter , parameter
    public static double Add(double num1, double num2)
    {
        return num1 + num2;
    }
}
