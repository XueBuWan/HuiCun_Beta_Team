using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class User_info
    {
        public string UID { get; set; }
        public string account { get; set; }
        public string pwd { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 用户余额
        /// </summary>
       public float Wallet { get; set; }
        /// <summary>
        /// 记录用户商品信息的xml的地址
        /// </summary>
       public  string My_goods { get; set; }
       public string Face { get; set; }
    }
}
