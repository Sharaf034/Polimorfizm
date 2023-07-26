//using Polimorfizm.Services.Interface;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Polimorfizm.Services.Interface;

//namespace Polimorfizm.Services
//{
//    internal class CustomMathService : ICustomMathService
//    {
//        public int GetNumbersOfSum(int[] nums)
//        {
//            int sum = 0;
//            foreach (var item in nums)
//            {
//                sum += item;
//            }
//            return sum;
//        }

//        public double SquareOfNum(int num)
//        {
//            var result = Math.Pow(num,2);
//            return result;
//        }

//        public void Sum(int a, int b)
//        {
//            int sum = a + b;
//            Console.WriteLine(sum);
//        }
//    }
//}
