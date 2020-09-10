using System.Collections.Generic;
namespace dtCalculator {
    public interface IMethod {
        public List<string> Inputs{set; get;}
        public string Result{get;}
        public void Execute();
        public void DisplayResults();
    }
}