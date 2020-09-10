namespace dtCalculator
{
    public interface IMenuItem {
        public string Name { get;}
        public int Id { get; }
        public void DisplayOptionName();
    }
}