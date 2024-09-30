class Dentist(string n, DateTime dob, char g, int exp, string ad):Person(n,dob,g),IMedicine
{
 public int ExperienceYear=exp;
 public string Address=ad;
 public override void PrintDetails(){
    base.PrintDetails();
    Console.WriteLine($"\t\t{ExperienceYear}\t\t{Address}");
 }
 public static void PrintHeader(){
   var header = $"Name\t\tDate Of Birth\t\tGender\t\tExperience Year\t\tAddress";
        Console.WriteLine(header);
 }

 public List<string> Medicines()=>["Medicine Name"];
 public void DoseTime(){
   Console.WriteLine($"Dose time .....");
 }
}