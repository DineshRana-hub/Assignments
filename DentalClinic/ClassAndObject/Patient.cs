
class Patient(string n, DateTime dob, char g, string p, DateTime A):Person(n,dob,g),IMedicine
{
  public string Problem=p;
  public DateTime Admission=A;
  public override void PrintDetails(){
    base.PrintDetails();
    Console.WriteLine($"\t\t{Admission}\t\t{Problem}");
  }

    public static void PrintHeader()
    {
        var header = $"Name\t\tDate Of Birth\t\tGender\t\tAdmission Time\t\tProblem";
        Console.WriteLine(header);
    }

    public List<string> Medicines()
    {
        throw new NotImplementedException();
    }
}