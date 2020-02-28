using System;

namespace assignment_one{
    class Program{
        
        static void Main(string[] args){
            estimate one= new estimate();
            estimate.Greeting();
            //dogOwner
            Console.WriteLine("Enter the Dog Owner's Name");
            one.dogOwner=Console.ReadLine();
            //dogName
            Console.WriteLine("Enter the Dog's Name");
            one.dogName=Console.ReadLine();
            //dogWeight
            Console.WriteLine("Enter the Dog's Weight in lbs");
            one.dogWeight=Convert.ToInt32(Console.ReadLine());
            //stayDuration
            Console.WriteLine("Enter the amount of days, If staying overnight enter 1 and N for the Addon Code");
            one.stayDuration=Convert.ToInt32(Console.ReadLine());
            //addOnCode
            Console.WriteLine("Enter the Addon Code, N for Overnight stay at $75.00 per day, A for bathing and grooming at $169.00 per day, and C for bathing only at 112.00 per day.");
            one.addOnCode=Console.ReadLine();
            //totalAmount
            if (one.addOnCode =="N"){
                one.totalAmount=(one.stayDuration * 75);
            }
            else if(one.addOnCode == "A"){
                one.totalAmount=(one.stayDuration * 169);
            }
            else if(one.addOnCode == "C"){
                one.totalAmount=(one.stayDuration * 112);
            }
            else{
                Console.WriteLine("Invalid Addon Code");
            };
            Console.WriteLine("Estimate for {1} under {0} weighing at {2}lbs for {3} day(s), using Addon Code {4} will cost ${5}", one.dogOwner, one.dogName, one.dogWeight, one.stayDuration, one.addOnCode, one.totalAmount);
            //estimate.ToString();
            estimate.Farewell();
        }
            
        
    }
    class estimate{
        public string dogOwner {get; set;}
        public string dogName {get; set;}
        public int dogWeight {get; set;}
        public int stayDuration {get; set;}
        public string addOnCode {get; set;}
        public double totalAmount {get; set;}
        
        public static void Greeting(){
            Console.WriteLine("\nWelcome to the MPLS Dog Boarding Price Estimate Calculator\n");
        }
        public static void Farewell(){
            Console.WriteLine("\nThank you for using the MPLS Dog Boarding Price Estimate Calculator\n");
        }
        /**public override String ToString(){
            return String.Format("Estimate for {1} under {0} weighing at {2} for {3} day(s), using Addon Code {4} will cost $ {5}", this.dogOwner, this.dogName, this.dogWeight, this.stayDuration, this.addOnCode, this.totalAmount);
        }**/
    }
}
