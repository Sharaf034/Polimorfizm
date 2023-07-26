using PolimorfizmHome.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmHome.Services
{
    internal class CalculatorService : ICalculatorService
    {
        public void Calculate()
        {
            throw new NotImplementedException();
        }

        public decimal Calculator(decimal num1, string operation, decimal num2)
        {
            decimal result = 0;

            switch (operation)
            {
                    case "+":
                    result = num1+num2;
                    break;
                    case "-":
                    result = num1 - num2;
                    break;
                    case "*":
                    result = num1 * num2;
                    break;
                    case "/":
                    result = num1 / num2;
                    break;
            }
            return result;
        }
    }
}
