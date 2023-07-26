//using Polimorfizm.Services;
//using Polimorfizm.Services.Interface;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Channels;
//using System.Threading.Tasks;

//namespace Polimorfizm.Controllers
//{
//    internal class AccountController
//    {
//        private readonly IAccountService _accountService;

//        public AccountController()
//        {
//            _accountService = new AccountService();
//        }

//        public void Login()
//        {
//            Console.WriteLine("Add email: ");
//            string email =Console.ReadLine();

//            Console.WriteLine("Add password: ");
//            string password = Console.ReadLine();

//            string result = _accountService.Login(email, password);
//            Console.WriteLine(result);
//        }
//    }
//}
