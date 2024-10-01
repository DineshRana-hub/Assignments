
public class PeopleReport(){
     public static List<Person> PeopleList = new List<Person>();
   
    public  static List<Person> SaveMales(){

    string path=@"C:\C#\Assignments\PeopleManagement\males.csv";
 
    File.WriteAllText(path, "Male"); 
    return PeopleList.Where(p => p.Sex.ToLower() == "male").ToList();


    }
     public void SaveFemales(){

    }
     public void SaveDotComUsers(){

    }

}
