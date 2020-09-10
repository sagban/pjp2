namespace dtCalculator{
    public class MenuItem : IMenuItem{
        public string Name { get;}
        public int Id { get; }
        public IMethod Method {get; set;}

        public MenuItem(int id, string name, IMethod method){
            Id = id;
            Name = name;
            Method = method;
        }
        public void DisplayOptionName(){
            System.Console.WriteLine("- [" + Id + "] " + Name);
        }
    }
}