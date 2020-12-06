using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Goods_info
    {
        public int Serial_Num { get; set; }
        /// <summary>
        /// 商品的主人的UID
        /// </summary>
        public string Owner { get; set; }
        /// <summary>
        /// 商品信息所在的xml的地址
        /// </summary>
        public string Description { get; set; }
       public  float Price { get; set; }

        public bool is_exist { get; set; }

    }
}
