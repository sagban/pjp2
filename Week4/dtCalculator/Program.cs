using System;

namespace dtCalculator {
    class Program {
        
        static private string lang {get; set;}
        static private string[] languages = {"en", "ge"};

        public Program(){
        
        }
        static void Main(string[] args) {

            Program.lang = "en";
            Console.WriteLine("Welcome to the Datsy - Your Personal Date Time Calculator");
            System.Console.WriteLine("Default configured language is English.\n Do you want to change it? (Y/N)");
            string isChange = Console.ReadLine();
            Console.WriteLine("What's your Name?");
            if(isChange.ToUpper() == "Y")Program.ChangeLanguage();
            string userName = Console.ReadLine();
            Console.WriteLine("Thank You, " + userName);
        }

        static void ChangeLanguage(){
            System.Console.WriteLine("Please the select your language:");
            System.Console.WriteLine("[en] English");
            System.Console.WriteLine("[ge] German");
            string langChange = Console.ReadLine();
            if(langChange == "en" || langChange == "ge")Program.lang = langChange;
        }
    }
}
