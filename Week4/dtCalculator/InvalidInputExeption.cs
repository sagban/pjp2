using System;
namespace dtCalculator{
    public class InvalidInputExeption: Exception{

        public InvalidInputExeption(string message){
            System.Console.WriteLine(message);
        }
        
    }
}