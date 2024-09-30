public class Person(string n, DateTime dob, char g)
{
     public string name = n;
     public DateTime dob{get;set;}=dob;
     public char g{get;set;}=g;
     public virtual void PrintDetails()
    {
      
        var message = $"{name}\t\t{dob}\t\t{g}";
        Console.Write(message);
    }

}