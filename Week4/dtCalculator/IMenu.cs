using System.Collections.Generic;
namespace dtCalculator {
    public interface IMenu {
        public List<IMenuItem> MenuItems { get;}
        public void Add(IMenuItem menuItem);
        public void DisplayMenu();

        
    }
}