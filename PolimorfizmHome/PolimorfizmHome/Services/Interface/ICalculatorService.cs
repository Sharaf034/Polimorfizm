using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmHome.Services.Interface
{
    internal interface ICalculatorService
    {
        void Calculate();
        public decimal Calculator(decimal num1, string operation, decimal num2);
    }
}
