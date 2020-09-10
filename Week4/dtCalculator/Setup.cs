using System;
namespace dtCalculator {
    public class Setup {
        
        static private string userName {get; set;}
        static private string language {get; set;}
        public Setup(string lang = "en") {
            language = lang;
        }

        static public Tuple<string, string, Menu> Init(){
            Welcome();
            var n = GetUserName();
            var l = GetLanguage();
            DisplayPersonalMessage(n);
            var m =  MakeMenuList();
            return Tuple.Create(l, n, m);
        }

        static private void Welcome(){
            Console.WriteLine("Welcome to the Datsy - Your Personal Date Time Calculator");
        }
        static private string GetLanguage(){
            System.Console.WriteLine("Default configured language is English.\n Do you want to change it? (Y/N)");
            var opt = Console.ReadLine();
            if(opt.ToUpper() == "Y")ChangeLanguage();
            return language;
        }

        static private void ChangeLanguage(){
            System.Console.WriteLine("Please the select your language:");
            System.Console.WriteLine("[en] English");
            System.Console.WriteLine("[ge] German");
            string langChange = Console.ReadLine();
            if(langChange == "en" || langChange == "ge")language = langChange;
        }

        static private string GetUserName(){
            Console.WriteLine("What's your Name?");
            return Console.ReadLine();
        }
        static private void DisplayPersonalMessage(string name){
            System.Console.WriteLine("Thank You, " + name + ". For providing your Name.");
        }

        static private Menu MakeMenuList(){
            var menu = new Menu();

            var menuItem1 = new MenuItem(1,
             "Subtract between two dates",
              new SubtractDates());
            menu.Add(menuItem1);

            var menuItem2 = new MenuItem(2,
             "Add, Subtract 'n' Days, Months, Weeks to the given date",
             new AddSubToDate());
            menu.Add(menuItem2);

            var menuItem3 = new MenuItem(3,
             "Determine the Day of the Week for a given a date",
             new WeekDay());
            menu.Add(menuItem3);

            var menuItem4 = new MenuItem(4,
             "Determine the Week number for a given a date",
             new WeekNumber());
            menu.Add(menuItem4);

            var menuItem5 = new MenuItem(5,
             "Try Natural Language Phase",
             new TryNLP());
            menu.Add(menuItem5);

            var menuItem6 = new MenuItem(6,
             "Show My History",
             new MyHistory());
            menu.Add(menuItem6);

            var menuItem7 = new MenuItem(7,
             "Show Full History",
             new FullHistory());
            menu.Add(menuItem7);

            var menuItem8 = new MenuItem(8,
             "Exit",
             new Exit());
            menu.Add(menuItem8);
            return menu;
        }
    }
}