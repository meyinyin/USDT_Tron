using HDWallet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USDT_A01.Models
{
    public class ResponseClass
    {
        public Result result { get; set; }
        public TransactionInfo transaction { get; set; }
    }
    public class Result
    {
        public string result { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class  TransactionInfo
    {
        public bool visible { get; set; }
        public string txID { get; set; }
        public object raw_data { get; set; }
        public string raw_data_hex { get; set; }
        public Signature signature { get; set; }
    }
    //public class ResponseAccounts
    //{
    //    public List<DataItem> data { get; set; }
    //}
    
}
