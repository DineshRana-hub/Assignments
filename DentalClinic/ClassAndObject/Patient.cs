class Patient(string n, DateTime dob, char g, string d):Person(n,dob,g)
{
  public string diseases=d;
  public override void PrintDetails(){
    base.PrintDetails();
    Console.WriteLine($"/t/t{diseases}")
  }

    public static void PrintHeader()
    {
        var header = $"Name\t\tDate Of Birth\t\tGender\t\tDiseases";
        Console.WriteLine(header);
    }

}