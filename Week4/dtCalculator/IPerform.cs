using System;
using System.Collections.Generic;
namespace dtCalculator{
    public interface IPerform{
        public List<string> Inputs{set; get;}
        public string Result{get;}

        public void Execute();


    }
}