using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using CsvHelper.TypeConversion;

class CSVParser(){
     string filePath = @"C:\C#\Assignments\PeopleManagement\People.csv";
          FileInfo FInfo=>new(filePath);
    public void ParserCsv(){
         
           var csvPath = Path.Combine(FInfo.DirectoryName, "People.csv");
        var lines = File.ReadAllLines(csvPath);
    
       
        var header = lines[0];
        var headerParts = header.Split(",");
        Console.WriteLine($"{headerParts[0]}\t\t{headerParts[1]}\t\t{headerParts[2]}\t\t{headerParts[3]}\t\t{headerParts[4]}\t\t{headerParts[5]}\t\t{headerParts[6]}\t\t{headerParts[7]}\t\t{headerParts[8]}");

         List<Person> people=[];
        foreach(var dataline in lines.Skip(1)){
            var dataParts = dataline.Split(",");
            var index = int.Parse(dataParts[0]);
            
            var dob=DateTime.Parse(dataParts[7]);
           var person = new Person(index,dataParts[1],dataParts[2],dataParts[3],dataParts[4],dataParts[5],dataParts[6],dob,dataParts[8]);
            people.Add(person);
        }
        
    }
}