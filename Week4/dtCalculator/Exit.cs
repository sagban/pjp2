using System.Collections.Generic;
namespace dtCalculator {
    public class Exit: IMethod {
        public List<string> Inputs{set; get;}
        public string Result{get; set;}
        public void Execute(){
            System.Console.WriteLine("Thank you for using Datsy.");
        }
        public void DisplayResults(){
            System.Console.WriteLine("Bye Bye!");
        }
    }
}