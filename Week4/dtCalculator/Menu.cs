using System;
using System.Collections.Generic;
namespace dtCalculator {
    public class Menu: IMenu {
        public List<IMenuItem> MenuItems { get; }

        public Menu(){
            MenuItems = new List<IMenuItem>();
        }

        public void Add(IMenuItem menuItem){
            MenuItems.Add(menuItem);
        }

        public void DisplayMenu(){
            System.Console.WriteLine("Which opertation do you want me to perform?");
            foreach (var menuItem in MenuItems)menuItem.DisplayOptionName();
        }
        public void Start(){
            DisplayMenu();
            var input = UserInput();
            if(input > 8 || input < 1) throw new InvalidInputExeption("Please Select the valid option");
            var item = MenuItems[input - 1];
            item.Method.Execute();
            item.Method.DisplayResults();
            if(input != 8)Restart();
        }
        private static int UserInput(){
            return Convert.ToInt32(Console.ReadLine());
        }

        private void Restart() {
            Console.WriteLine("Do you want to continue? (Y/N)");
            var o = Console.ReadLine();
            if (o != null && o.ToUpper() == "Y") Start();
        }
    }
}