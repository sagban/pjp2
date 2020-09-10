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
            byte input = UserInput();
            if(input > 5 || input < 1) throw new InvalidInputExeption("Please Select the valid option");

        }
        private byte UserInput(){
            return Convert.ToByte(Console.ReadLine());
        }
        
    }
}