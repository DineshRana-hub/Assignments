using System.Numerics;

public class Person(int i,string Ui,string fn,string ln,string Sex,string Email,  string ph,DateTime dob,string Jb)
{
   public int index{get;set;}=i;
   public string UserId{get;set;}=Ui;
   public string FirstName{get;set;}=fn;
  public  string LastName{get;set;}=ln;
 public   string Sex{get;set;}=Sex;
   public string Email{get;set;}=Email;
  public  string Phone{get;set;}=ph;
   public DateTime DateOfBirth{get;set;}=dob;
   public string JobTitle{get;set;}=Jb;

}
 