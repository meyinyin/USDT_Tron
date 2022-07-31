using HDWallet.Core;
using NBitcoin;
using NBitcoin.DataEncoders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace USDT_A01.Models
{
    public class Common
    {
        /// <summary>
        /// 通用返回1
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class ResultModel<T>
        {
            public bool IsSuccess { get; set; }
            public int Code { get; set; }
            public T Data { get; set; }
            public string Msg { get; set; }
            public string Hash { get; set; }

        }
        /// <summary>
        /// 通用返回2
        /// </summary>
        public class ResultCode
        {
            public bool IsSuccess { get; set; }
            public int Code { get; set; }
            public string Msg { get; set; }
            public string Hash { get; set; }
            public string Data { get; set; }
        }

        /// <summary>
        /// 序列化
        /// </summary>
        public class ResultToJson
        {
            public static HttpResponseMessage toJson(Object obj)
            {
                String str;
                if (obj is String || obj is Char)
                {
                    str = obj.ToString();
                }
                else
                {
                    str = JsonConvert.SerializeObject(obj);
                }
                HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };
                return result;
            }
        }


        /// <summary>
        /// 转HEX地址
        /// </summary>
        /// <param name="base58"></param>
        /// <returns></returns>
        public static string ToHex(string base58)
        {
            var HexAdress = Helper.ToHexString(Encoders.Base58Check.DecodeData(base58));
            return HexAdress;
        }
        /// <summary>
        /// 转Base58地址
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static string ToBase58(string hex)
        {
            return "";
        }

        /// <summary>
        /// 制作ABI参数
        /// </summary>
        /// <param name="base58"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static string MakeABI(string base58, long amount)
        {
            var HexAdress = Helper.ToHexString(Encoders.Base58Check.DecodeData(base58));
            string newHexAdress = "";
            string newamount = "";
            //byte[] ll = new byte[] { 0};
            if (HexAdress.Length < 64) {
                byte[] HexAdressbyteArray = System.Text.Encoding.Default.GetBytes(HexAdress);
                byte[] byteArray = new byte[64- HexAdress.Length];
                for(var i = 0; i < 64 - HexAdress.Length; ++i)
                {
                    byteArray[i] = 48;
                }
                byte[] newHexAdressbyteArray = new byte[64];
                //byteArray.Length + HexAdressbyteArray.Length
                byteArray.CopyTo(newHexAdressbyteArray, 0);
                HexAdressbyteArray.CopyTo(newHexAdressbyteArray, byteArray.Length);
                newHexAdress = System.Text.Encoding.ASCII.GetString(newHexAdressbyteArray);
            }
            var amount16 = Convert.ToString(amount, 16);
            if(amount16.Length < 64)
            {
                byte[] amount16byteArray = System.Text.Encoding.Default.GetBytes(amount16);
                byte[] byteArray1 = new byte[64-amount16.Length];
                for (var i = 0; i < 64-amount16.Length; ++i)
                {
                    byteArray1[i] = 48;
                }
                byte[] newamount16byteArray = new byte[byteArray1.Length + amount16byteArray.Length];
                byteArray1.CopyTo(newamount16byteArray, 0);
                amount16byteArray.CopyTo(newamount16byteArray, byteArray1.Length);
                newamount = System.Text.Encoding.ASCII.GetString(newamount16byteArray);
            }
            string ABI = newHexAdress + newamount;
            return ABI;
        }


    }
}
