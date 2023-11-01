public class Person
{
    public string FirstName { get; init; }
    public string LastName { get; private set; }

    public int Height { get; set; }

    public DateTime Birthdate { get; init; }

    public Person()
    {
        FirstName = "";
        LastName = "";
        Height = 60;
        //Birthdate =  new DateTime(2023, 10, 31);
        Birthdate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Height = 60;
        //Birthdate =  new DateTime(2023, 10, 31);
        Birthdate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
    }

    public Person(string firstName, string lastName, int feet, int inches)
    {
        FirstName = firstName;
        LastName = lastName;
        Height = inches;
        Height += 12 * feet;
        //Birthdate =  new DateTime(2023, 10, 31);
        Birthdate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
    }

    public Person(Person anotherObject)
    {
        FirstName = anotherObject.FirstName;
        LastName = anotherObject.LastName;
        Height = anotherObject.Height;
        Birthdate = new DateTime(anotherObject.Birthdate.Year, 
                                 anotherObject.Birthdate.Month, 
                                 anotherObject.Birthdate.Day);
    }

    public override bool Equals(object? obj)
    {
        if(obj.GetType() == typeof(Person))
        {
            Person newObject = (Person)obj;

            return FirstName == newObject.FirstName && LastName == newObject.LastName && Height == newObject.Height && Birthdate == newObject.Birthdate;
        }
        else
        {
            return false;
        }
    }

    public bool Equals(Person otherPerson)
    {
         return FirstName == otherPerson.FirstName && LastName == otherPerson.LastName && Height == otherPerson.Height && Birthdate == otherPerson.Birthdate;
    }

    public override string ToString()
    {
        string msg = "";

        if(FirstName == "")
        {
            msg += $"First Name: NOT PROVIDED\n";
        }
        else
        {
            msg += $"First Name: {FirstName}\n";
        }
       
        msg += $"Last Name: {LastName}\n";
        msg += $"Birthdate: {Birthdate}\n";
        msg += $"Height: {Height}\"";
        
        return msg;
    }

    public void LegallyChangeYouLastName(string lastName)
    {
        //you do something to ensure it can be done 

        //Then change it.
        LastName = lastName;
    }
}
