
using System.Diagnostics.CodeAnalysis;

public class PeopleReport()
{
       
   
    public void SaveMales(){
string path=@"C:\C#\Assignments\PeopleManagement\males.csv";
 File.WriteAllText(path, "Male"); 
  var people=new CSVParser().ParserCsv();
  // is is not given in data Person.csv
  var malelist=people.Where(Person=>Person.Sex=="Male").ToList();
   using (var writer = new StreamWriter(path))
        {
            writer.WriteLine("Index,User ID,FirstName,LastName,Sex,,Email,Phone,DateOfBirth,Job Title"); // Write header
            
            foreach (var male in malelist)
            {
                writer.WriteLine($"{male.index},{male.UserId},{male.FirstName},{male.LastName},{male.Sex},{male.Email},{male.Phone},{male.DateOfBirth.ToString("yyyy-MM-dd")},{male.JobTitle}");
            }
        }

        Console.WriteLine(" males have been saved ");
    }

 
    
     public void SaveFemales(){
        string path=@"C:\C#\Assignments\PeopleManagement\females.csv";
 File.WriteAllText(path, "FeMale"); 
  var people=new CSVParser().ParserCsv();
  //Age  is is not given in data Person.csv
  var femaleslist=people.Where(Person=>Person.Sex=="Female").ToList();
   using (var writer = new StreamWriter(path))
        {
            writer.WriteLine("Index,User ID,FirstName,LastName,Sex,,Email,Phone,Date Of Birth,Job Title"); // Write header
            
            foreach (var female in femaleslist)
            {
                writer.WriteLine($"{female.index},{female.UserId},{female.FirstName},{female.LastName},{female.Sex},{female.Email},{female.Phone},{female.DateOfBirth.ToString("yyyy-MM-dd")},{female.JobTitle}");
            }
        }

        Console.WriteLine(" females have been saved ");

    }
     public void SaveDotComUsers(){
        string path=@"C:\C#\Assignments\PeopleManagement\dotcomuser.csv";
 File.WriteAllText(path, "user"); 
  var people=new CSVParser().ParserCsv();
  
  var dotcumuser=people.Where(Person=>Person.Email.EndsWith("@example.com")).ToList();
   using (var writer = new StreamWriter(path))
        {
            writer.WriteLine("Index,User ID,Email,Phone"); // Write header
            
            foreach (var user in dotcumuser)
            {
                writer.WriteLine($"{user.index},{user.UserId},{user.Email},{user.Phone}");
            }
        }

        Console.WriteLine("dotcumuser have been saved ");


    }

}
