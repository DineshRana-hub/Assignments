class CalculateBill{
      int unit;
      
 public CalculateBill(int unit)
    {
       this.unit = unit;  
    }
    public void Calculate(){
        int sum=0;

    // if else method
    //     if(unit>=1 && unit<=20){
    //        sum=100;
    //     }
    //     else if (unit>20 && unit<=25){
    //          sum = unit * 5;
    //    ;

    //     }
    //     else if (unit>25 && unit<=50){
    //          sum = unit * 10;
    

    //     }
    //     else{
    //           sum = 2000;
       
    //     }


  //swich case method
        switch (unit){
        case int n when (n>=1  && n<=20):
        sum=100;
        break;
           
           case int n when (n>=21 && n<=25):
        sum=unit*5;
        break;

        case int n when (n>=26 && n<=50):
        sum=unit*10;
        break;

        case int n when (n>50 ):
        sum=2000;
        break;

        default:
        Console.WriteLine("Invalid value");
        break;
       }
        Console.WriteLine($"Electricity Bill = {sum} RS");
    }
   
}