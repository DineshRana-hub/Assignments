class CriticalPatient(string n, DateTime dob, char g, string p, DateTime A ,string condition):Patient(n,dob,g,p,A)
{
    public string CriticalCondition=condition;
     public override void PrintDetails(){
    base.PrintDetails();
    Console.WriteLine($"\t\t{CriticalCondition}");
 }
 public static void PrintHeader()
    {
        var header = $"Name\t\tDate Of Birth\t\tGender\t\tAdmission Time\t\tProblem\t\tCritical Condition";
        Console.WriteLine(header);
    }

}