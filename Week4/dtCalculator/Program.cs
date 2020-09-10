using System;

namespace dtCalculator {
    class Program {
        static void Main(string[] args) {
            var config = Setup.Init();
            var name = config.Item2;
            var menu = config.Item3;
            menu.Start();
        }
    }
}
