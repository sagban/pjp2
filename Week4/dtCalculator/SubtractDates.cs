using System;
using System.Collections.Generic;
namespace dtCalculator {
    public class SubtractDates: IMethod{
        public List<string> Inputs{set; get;}
        public string Result{get; set; }

        public SubtractDates() {
            Inputs = new List<string>();
        }
        public void Execute(){
            TakeInputs();
            var startDate = Inputs[0];
            var endDate = Inputs[1];
            var startDateValue = DateTime.ParseExact(startDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var endDateValue = DateTime.ParseExact(endDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Result = Convert.ToString((endDateValue - startDateValue).Days);
        }
        public void DisplayResults(){
            Console.WriteLine("There are {0} days between two dates", Result);
        }

        private void TakeInputs() {
            Console.WriteLine("Enter the start date (dd-MM-yyyy)");
            var sd = Console.ReadLine();
            Inputs.Add(sd);
            Console.WriteLine("Enter the end date (dd-MM-yyyy)");
            var ed = Console.ReadLine();
            Inputs.Add(ed);
        }
    }
}