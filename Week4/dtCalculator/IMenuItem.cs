namespace dtCalculator
{
    public interface IMenuItem {
        public string Name { get;}
        public int Id { get; }
        public IMethod Method {get; set;}
        public void DisplayOptionName();
    }
}