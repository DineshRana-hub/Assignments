using System.Numerics;

public class Person(int i,string Ui,string fn,string ln,string sex,string Email,  string ph,DateTime dob,string Jb)
{
   public int index=i;
   public string UserId=Ui;
   public string FirstName=fn;
  public  string Lastname=ln;
 public   string Sex=sex;
   public string Email=Email;
  public  string phone=ph;
   public DateTime DateOfBirth=dob;
   public string JobTitle=Jb;
  public static List<Person> PeopleList = new List<Person>();
}
 