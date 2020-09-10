namespace dtCalculator{
    public class MenuItem : IMenuItem{
        public string Name { get;}
        public int Id { get; }

        public MenuItem(int id, string name){
            Id = id;
            Name = name;
        }
        public void DisplayOptionName(){
            System.Console.WriteLine("- [" + Id + "] " + Name);
        }
    }
}