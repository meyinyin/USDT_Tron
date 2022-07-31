using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using HDWallet.Secp256k1;
using HDWallet.Core;
using NBitcoin;
using NBitcoin.DataEncoders;
using HDWallet.Tron;
using NUnit.Framework;
using Newtonsoft.Json;
using System.Text;
using USDT_A01.Models;
using HDWallet.Secp256k1.Sample;
using static USDT_A01.Models.Common;

namespace USDT_A01.Controllers
{
    
    [ApiController]
    public class AccountController : ControllerBase
    {
        /// <summary>
        /// 账户信息类
        /// </summary>
        public class AccountInfo
        {
            public string AccountID { get; set; }
            public string AccountPwd { get; set; }
            public string Type { get; set; }
            public string Code { get; set; }
            public string Issuer { get; set; }
            public string Balance { get; set; }
            public string Image { get; set; }
        }

        /// <summary>
        /// 公共方法GetHttpOffer
        /// </summary>
        /// <param name="offerurl"></param>
        /// <returns></returns>
        public static async Task<string> GetHttpOffer(string offerurl)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("TRON-PRO-API-KEY", "9d6dd1cd-107b-4a18-9d50-1716b50fcd8c");
                    var jsonString = await client.GetStringAsync(offerurl);
                    if (jsonString != "" || jsonString != null)
                    {
                        return "" + jsonString;
                    }
                    return "" + jsonString;
                }
            }
            catch
            {
                return "";
            }
        }

        
        public static string PostHttpoffer()
        {
            var client = new RestClient("https://api.trongrid.io/v1/accounts/TR7NHqjeKQxGTCi8q8ZY4pL8otSzgjLj6t");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            IRestResponse response = client.Execute(request);
            return "" + response;
        }
        
        [HttpGet]
        [Route("api/sign")]
        public async Task<string> DDAsync()
        {
            //创建transaction对象
            //var client = new RestClient("https://api.shasta.trongrid.io/wallet/triggersmartcontract");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Accept", "application/json");
            //request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("TRON-PRO-API-KEY", "9d6dd1cd-107b-4a18-9d50-1716b50fcd8c");
            //request.AddParameter("application/json", "{\"owner_address\":\"41137fdf89d939772c0d885f51ff30f515d70e25de\",\"contract_address\":\"412a6c3779a4cb9831e40bf42507fffd6cfc09837d\",\"function_selector\":\"transfer('4181a286df52537f71d9e2b0645dc40c121d818008',uint256)\"}", ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);
            //return response.Content.ToString();
            //var transactions = response.Content.ToString();
            //Root root = new JsonConvert.DeserializeObject<Root>(transaction);

            //签名
            //Wallet.Sign();
            //IHDWallet<TronWallet> wallet = new TronHDWallet("助记词");
            //TronWallet wallet0 = wallet.GetAccount(0).GetExternalWallet(0);
            ////var transaction = JsonConvert.DeserializeObject<Root>(transactions);
            //var txId = "83dfeda2b08cdd5e20ff7f06691a5c7030fcdc0565cee5b87a0319e665cf29b6".FromHexToByteArray();
            //Signature signature = wallet0.Sign(txId);
            //TronSignature tronSignature = new TronSignature(signature);
            //var signatureHex = Helper.ToHexString(tronSignature.SignatureBytes);

            //Assert.AreEqual(signatureHex, signatureHex);
            //transaction.signature.Add(signatureHex);

            //IHDWallet<TronWallet> tronHDWallet = new TronHDWallet("私钥");
            //var account0 = tronHDWallet.GetAccount(0);
            //TronWallet wallet0 = account0.GetExternalWallet(0);
            //var txId = Helper.FromHexToByteArray("f9cda2510ca95eb35e2215833017f2f9c11606ff2b82fd3cd6e896dccae687e0");
            //Signature signature = wallet0.Sign(txId);
            //TronSignature tronSignature = new TronSignature(signature);
            //var signatureHex = Helper.ToHexString(tronSignature.SignatureBytes);
            //Assert.AreEqual("TMnesNKCH15XUKY5eW58WbNjtJdkpCfGHx", signatureHex);
            //var txId = Helper.FromHexToByteArray(transaction.txID);
            //Signature signature = wallet0.Sign(txId);
            //TronSignature tronSignature = new TronSignature(signature);
            //var signatureHex = Helper.ToHexString(tronSignature.SignatureBytes);
            //transaction.signature.Add(signatureHex);

            //IHDWallet<TronWallet> wallet = new TronHDWallet("密钥");
            //TronWallet wallet0 = wallet.GetAccount(0).GetExternalWallet(0);
            //string wallet0Address = wallet0.Address;

            //var url = "https://api.shasta.trongrid.io";

            // Create transaction
            //string resultContent;
            //using (var client = new HttpClient() { BaseAddress = new Uri(url) })
            //{
            //    var req = new
            //    {
            //        to_address = "TMnesNKCH15XUKY5eW58WbNjtJdkpCfGHx",
            //        owner_address = "TBkK2VLBKhWgHkzaFZKTbWebVjooodAEXU",
            //        amount = "555"
            //    };

            //    var serializedData = JsonConvert.SerializeObject(req);

            //    var requestData = new StringContent(
            //        serializedData,
            //        Encoding.UTF8,
            //        "application/json");

            //    var result = await client.PostAsync("wallet/createtransaction", requestData);
            //    resultContent = await result.Content.ReadAsStringAsync();
            //}

            //var transaction = JsonConvert.DeserializeObject<Transaction>(resultContent);

            //// Sign
            //var txId = Helper.FromHexToByteArray(transaction.txID);
            //Signature signature = wallet0.Sign(txId);
            //TronSignature tronSignature = new TronSignature(signature);
            //var signatureHex = Helper.ToHexString(tronSignature.SignatureBytes);
            ////transaction.signature.Add(signatureHex);
            //Assert.AreEqual("TMnesNKCH15XUKY5eW58WbNjtJdkpCfGHx", signatureHex);



            // Broadcast
            //using (var client = new HttpClient() { BaseAddress = new Uri(url) })
            //{
            //    var req = new
            //    {
            //        raw_data = JsonConvert.SerializeObject(transaction.raw_data),
            //        txID = transaction.txID,
            //        signature = new List<string>()
            //    };
            //    req.signature.Add(transaction.signature.First());

            //    var serializedData = JsonConvert.SerializeObject(req);

            //    var requestData = new StringContent(
            //        serializedData,
            //        Encoding.UTF8,
            //        "application/json");

            //    var result = await client.PostAsync("wallet/broadcasttransaction", requestData);
            //    resultContent = await result.Content.ReadAsStringAsync();
            //}


            //广播
            //var client = new RestClient("https://api.shasta.trongrid.io/wallet/broadcasttransaction");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Accept", "application/json");
            //request.AddHeader("Content-Type", "application/json");
            //request.AddParameter("application/json", "{\"raw_data\":\"{\\\"contract\\\":[{\\\"parameter\\\":{\\\"value\\\":{\\\"amount\\\":1000,\\\"owner_address\\\":\\\"41608f8da72479edc7dd921e4c30bb7e7cddbe722e\\\",\\\"to_address\\\":\\\"41e9d79cc47518930bc322d9bf7cddd260a0260a8d\\\"},\\\"type_url\\\":\\\"type.googleapis.com/protocol.TransferContract\\\"},\\\"type\\\":\\\"TransferContract\\\"}],\\\"ref_block_bytes\\\":\\\"5e4b\\\",\\\"ref_block_hash\\\":\\\"47c9dc89341b300d\\\",\\\"expiration\\\":1591089627000,\\\"timestamp\\\":1591089567635}\"}", ParameterType.RequestBody);
            //IRestResponse responses = client.Execute(request);


            return "";
        }
        /// <summary>
        /// 创建tron账户
        /// </summary>
        /// <param name="num">默认为1</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/createtronaccount")]
        public ResultModel<List<AccountInfo>> CreateTronAccount(int num = 1)
        {
            List<AccountInfo> list = new List<AccountInfo>();
            try
            {
                for (var i = 0; i < num; i++)
                {
                    var key = new Key();
                    var seed = key.PubKey.ToHex().Remove(0, 2);
                    var tronWallet = new TronWallet(seed);
                    var tronWalletaddress = tronWallet.Address;
                    list.Add(new AccountInfo
                    {
                        AccountID = tronWalletaddress,
                        AccountPwd = seed
                    });
                }
                return new ResultModel<List<AccountInfo>> { IsSuccess = true, Code = 200, Msg = "成功", Data = list };
            }
            catch
            {
                return new ResultModel<List<AccountInfo>> { IsSuccess = false, Code = 500, Msg = "网络波动" };
            }

        }

        /// <summary>
        /// 转TRX（shasta/trongrid）
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/transactionTRX")]
        public async Task<string> TransactionTRX(int amount)
        {
            //shasta
            //IHDWallet<TronWallet> wallet = new TronHDWallet("助记词");
            //tron
            IHDWallet<TronWallet> wallet = new TronHDWallet("助记词");
            TronWallet wallet0 = wallet.GetAccount(0).GetExternalWallet(0);
            //private key
            //var wallet0 = new TronWallet("密钥");
            string wallet0Address = wallet0.Address;
            var url = "https://api.trongrid.io";
            // Create transaction
            string resultContent;
            string resultContents;

            using (var client = new HttpClient() { BaseAddress = new Uri(url) })
            {
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("TRON-PRO-API-KEY", "9d6dd1cd-107b-4a18-9d50-1716b50fcd8c");
                var req = new
                {
                    //shasta
                    //to_address = "TMnesNKCH15XUKY5eW58WbNjtJdkpCfGHx",
                    //owner_address = "TBkK2VLBKhWgHkzaFZKTbWebVjooodAEXU",
                    //tron
                    to_address = "TYLTPDDyziPCrhEAZLnUn8YM4PfRL6pt5u",
                    owner_address = wallet0Address,
                    amount = amount,
                    visible = true
                };
                var serializedData = JsonConvert.SerializeObject(req);
                var requestData = new StringContent(
                    serializedData,
                    Encoding.UTF8,
                    "application/json");
                var result = await client.PostAsync("wallet/createtransaction", requestData);
                resultContent = await result.Content.ReadAsStringAsync();
            }
            var transactionInfo = JsonConvert.DeserializeObject<TransactionInfo>(resultContent);
            // Sign
            var txId = Helper.FromHexToByteArray(transactionInfo.txID);
            Signature signature = wallet0.Sign(txId);
            TronSignature tronSignature = new TronSignature(signature);
            var signatureHex = Helper.ToHexString(tronSignature.SignatureBytes);
            Assert.AreEqual(signatureHex, signatureHex);

            // Broadcast
            using (var client = new HttpClient() { BaseAddress = new Uri(url) })
            {
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("TRON-PRO-API-KEY", "9d6dd1cd-107b-4a18-9d50-1716b50fcd8c");
                var req = new
                {
                    raw_data = JsonConvert.SerializeObject(transactionInfo.raw_data),
                    txID = transactionInfo.txID,
                    signature = new List<string>(),
                    //raw_data_hex = transactionInfo.raw_data_hex
                    visible = true
                };
                req.signature.Add(signatureHex);

                var serializedData = JsonConvert.SerializeObject(req);

                var requestData = new StringContent(
                    serializedData,
                    Encoding.UTF8,
                    "application/json");

                var result = await client.PostAsync("wallet/broadcasttransaction", requestData);
                resultContents = await result.Content.ReadAsStringAsync();
            }

            return resultContents;
        }
        
        /// <summary>
        /// 转U
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/transactionUSDT")]
        public async Task<string> TransactionUSDT()
        {
            IHDWallet<TronWallet> wallet = new TronHDWallet("助记词");
            TronWallet wallet0 = wallet.GetAccount(0).GetExternalWallet(0);
            string wallet0Address = wallet0.Address;
            //private key
            //var wallet0 = new TronWallet("80776c3142b0a2425a086d31e2169a5d018114ea049722fcc2a7e679c55cfaef");
            //var wallet0Address = tronWallet.Address;
            var url = "https://api.trongrid.io";
            // Create transaction
            string resultContent;
            string resultContents;
            string toadress = "TBjxHVWBCWFfM6jLC5FfxitgBmWbXvqNzD";
            long amount = 1000000;
            string ABI = Models.Common.MakeABI(toadress, amount);
            using (var client = new HttpClient() { BaseAddress = new Uri(url) })
            {
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("TRON-PRO-API-KEY", "9d6dd1cd-107b-4a18-9d50-1716b50fcd8c");
                var req = new
                {
                    //shasta
                    //contract_address = "TR7NHqjeKQxGTCi8q8ZY4pL8otSzgjLj6t",
                    //owner_address = "TBkK2VLBKhWgHkzaFZKTbWebVjooodAEXU",
                    //tron
                    contract_address = "TR7NHqjeKQxGTCi8q8ZY4pL8otSzgjLj6t",
                    owner_address = "TThdx59AkXtzU2pToYjp7dom7d48NJKxvM",
                    //function_selector = $"transfer({adress},{amount})",
                    function_selector = "transfer(address,uint256)",
                    fee_limit = 50000000,
                    parameter = ABI,
                    visible = true
                };
                var serializedData = JsonConvert.SerializeObject(req);
                var requestData = new StringContent(
                    serializedData,
                    Encoding.UTF8,
                    "application/json");
                var result = await client.PostAsync("wallet/triggersmartcontract", requestData);
                resultContent = await result.Content.ReadAsStringAsync();
            }
            var responseClass = JsonConvert.DeserializeObject<ResponseClass>(resultContent);
            var transactiontxt = JsonConvert.SerializeObject(responseClass.transaction);
            var transactionInfo = JsonConvert.DeserializeObject<TransactionInfo>(transactiontxt);
            // Sign
            var txId = Helper.FromHexToByteArray(transactionInfo.txID);
            Signature signature = wallet0.Sign(txId);
            TronSignature tronSignature = new TronSignature(signature);
            var signatureHex = Helper.ToHexString(tronSignature.SignatureBytes);
            Assert.AreEqual(signatureHex, signatureHex);

            // Broadcast
            using (var client = new HttpClient() { BaseAddress = new Uri(url) })
            {
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("TRON-PRO-API-KEY", "9d6dd1cd-107b-4a18-9d50-1716b50fcd8c");
                var req = new
                {
                    raw_data = JsonConvert.SerializeObject(transactionInfo.raw_data),
                    txID = transactionInfo.txID,
                    signature = new List<string>(),
                    //raw_data_hex = transactionInfo.raw_data_hex
                    visible = true
                };
                req.signature.Add(signatureHex);

                var serializedData = JsonConvert.SerializeObject(req);

                var requestData = new StringContent(
                    serializedData,
                    Encoding.UTF8,
                    "application/json");

                var result = await client.PostAsync("wallet/broadcasttransaction", requestData);
                resultContents = await result.Content.ReadAsStringAsync();
            }

            return resultContents;
        }

        [HttpGet]
        [Route("api/test3")]
        public string Test3()
        {
            var ss = new Key().GetWif(Network.Main);
            var sss = ss.PubKey.ToHex();
            return sss;
        }

        [HttpGet]
        [Route("api/test4")]
        public string Test4()
        {
            //通过助记词创建HD钱包
            IHDWallet<TronWallet> wallet = new TronHDWallet("助记词");
            TronWallet tronWallet0 = wallet.GetAccount(0).GetExternalWallet(0);
            //通过密钥创建普通钱包
            var tronWallet1 = new TronWallet("密钥");
            var ss = tronWallet1.Address;
            //用实例化出来的tronWallet0和tronWallet1都可以进行签名，转U，转TRX都可以
            //tronWallet.Sign();

            return ss;
        }
        
        [HttpGet]
        [Route("api/accounts")]
        public  Task<string> Accounts()
        {
            var url = "https://api.trongrid.io/v1/accounts/TThdx59AkXtzU2pToYjp7dom7d48NJKxvM/transactions/trc20";
            var restxt = GetHttpOffer(url);
            return restxt;
        }
    }
}
