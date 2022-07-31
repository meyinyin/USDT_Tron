using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USDT_A01.Models
{
    public class ResponseAccountsClass
    {

    }
    public class Token_info
    {
        /// <summary>
        /// 
        /// </summary>
        public string symbol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int decimals { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
    }

    public class DataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string transaction_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Token_info token_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int block_timestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string @from { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string to { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string value { get; set; }
    }

    public class Meta
    {
        /// <summary>
        /// 
        /// </summary>
        public int at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int page_size { get; set; }
    }

    public class ResponseAccounts
    {
        /// <summary>
        /// 
        /// </summary>
        public List<DataItem> data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Meta meta { get; set; }
    }
}
