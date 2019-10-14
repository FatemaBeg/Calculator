using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
   public  class Result
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double CalculatedResult { get; set; }

        public double add()
        {
           CalculatedResult= FirstNumber + SecondNumber;
            return CalculatedResult;
        }
        public double Subtract()
        {
            CalculatedResult = FirstNumber - SecondNumber;
            return CalculatedResult;
        }
        public double Multiply()
        {
            CalculatedResult = FirstNumber * SecondNumber;
            return CalculatedResult;
        }
        public double Divide()
        {
            CalculatedResult = FirstNumber / SecondNumber;
            return CalculatedResult;
        }



    }
}
