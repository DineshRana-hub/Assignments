// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Patient.PrintHeader();
var Patient1= new Patient("gopal", new DateTime(2000,2,5),'M',"TeethAche",new DateTime(2024,9,28));
Patient1.PrintDetails();

Dentist.PrintHeader();
var dentist= new Dentist("Ram", new DateTime(2000,2,5),'M',4,"dhangadi");
dentist.PrintDetails();

CriticalPatient.PrintHeader();
var Patientcr= new CriticalPatient("gopal", new DateTime(2000,2,5),'M',"Teeth worm",new DateTime(2024,9,28),"Urgent Operation");
Patientcr.PrintDetails();