public class Person((string n, DateTime dob, char g))
{
     public string name = n;
     public DateTime dob=dob{get;set;}
     public char gender=g(get;set;)
     public virtual void PrintDetails()
    {
      
        var message = $"{name}\t\t{dob}\t\t{gender}";
        Console.Write(message);
    }

}