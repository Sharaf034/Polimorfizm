using PolimorfizmHome.Services;
using PolimorfizmHome.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmHome.Controller
{
    internal class CalculatorController
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController()
        {
            _calculatorService = new CalculatorService();
        }

        public void Calculate()
        {
            Console.WriteLine("Add first number: --");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Add operation: (+, -, *, / )");
            string operation = Console.ReadLine();

            Console.WriteLine("Add second number: --");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("-----------");

            Console.WriteLine(_calculatorService.Calculator(num1, operation, num2));



        }
    }
}