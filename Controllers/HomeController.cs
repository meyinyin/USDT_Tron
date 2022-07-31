using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using USDT_A01.Models;
using Nethereum.Web3.Accounts;
using Nethereum.Web3;

namespace USDT_A01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult>  Privacy()
        {
            //私钥解析
            //Account account = new Account("privateKey");
            //通过keystore解析
            //var keystoreJson = File.ReadAllText("keystore file path");
            //Account account = Account.LoadFromKeyStore(keystoreJson, password);
            //Web3 web3 = new Web3(account, "infura connect url");

            var web3 = new Web3("https://mainnet.infura.io/v3/7238211010344719ad14a89db874158c");
            var balance = await web3.Eth.GetBalance.SendRequestAsync("0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae");
            Console.WriteLine($"Balance in Wei: {balance.Value}");

            var etherAmount = Web3.Convert.FromWei(balance.Value);
            Console.WriteLine($"Balance in Ether: {etherAmount}");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
