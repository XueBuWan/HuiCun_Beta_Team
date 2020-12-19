
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Dal
{
    public class DalLayer
    {
    
    /// <summary>
    /// 登录验证
    /// </summary>
    /// <param name="account">账号或者UID（学号）</param>
    /// <param name="pwd">密码</param>
    /// <returns>1表示认证成功；-1表示访问数据库出错；0表示账号密码错误</returns>
        public int Login_Check(string account,string pwd)
        {
            string sql = "select * from User_info where (account=@account or UID=@account) and pwd=@pwd";
            SqlParameter[] paras = new SqlParameter[]
           {
                new SqlParameter("@account",account),
                new SqlParameter("@pwd",pwd)
           };
            DataTable dt;
            try
            {
                dt = SqlHelper.ExecuteDataTable(sql, paras);
            }
            catch(Exception ex)
            {
                //可以在此处添加错误信息记录
                return -1;
            }
           
            int i = 0;
            foreach(DataRow dr in dt.Rows)
            {
                i++;
            }
            if (i == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="ul">用户注册对象（account可以为空）</param>
        /// <returns>-1表示访问数据库出错（有可能是该学号已被注册）;1表示注册成功;0表示注册失败</returns>
        public int User_Register(User_Login_1 ul)
        {
            string sql = "insert into User_Login (UID,account,pwd) values(@UID,@account,@pwd)";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@UID",ul.UID),
                new SqlParameter("@account",ul.account),
                new SqlParameter("@pwd",ul.pwd)
            };
            int i = 0;
            try
            {
               i= SqlHelper.ExecuteNonQuery(sql, paras);
            }catch(Exception ex)
            {
                //此处可以添加错误信息记录
                return -1;
            }
            return i;
        }
        /// <summary>
        /// 获取商品信息的xml地址
        /// </summary>
        /// <param name="Serial_Num">商品的编号</param>
        /// <returns>"Error" 表示访问数据库出错;"None" 表示该物品不存在;其他则表示商品信息的xml文件地址</returns>
        public string Get_GoodInfo(int Serial_Num)
         {
            string sql = "select * from Goods_info where Serial_Num = @Serial_Num";
            SqlParameter para = new SqlParameter("@Serial_Num", Serial_Num);
            DataTable dt;
            try
            {
                dt = SqlHelper.ExecuteDataTable(sql, para);
            }
            catch (Exception ex)
            {
                //此处可以添加错误信息记录
                return "Error";
            }
            List < Goods_info > list  = DataTableToGoods_info(dt);
            if (list[0].count==0)
            {
                return "None";
            }
                
            return list[0].Description;
        }
       /// <summary>
       /// 获取相应页码的商品信息
       /// </summary>
       /// <param name="pageindex">页码索引</param>
       /// <returns>商品信息列表</returns>
        public List<Goods_info> Get_Goods(int pageindex)
        {
            string sql = "select * from (select *,ROW_NUMBER() over(order by count) as RowNumber from Goods_info)a where RowNumber between @start and @end";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@start",(pageindex-1)*16+1),
                new SqlParameter("@end",pageindex*16)
            };
            DataTable dt = new DataTable();
            try
            {
                dt = SqlHelper.ExecuteDataTable(sql);
            }catch(Exception ex)
            {
                Goods_info ur = new Goods_info();
                ur.name = "Error";
                List<Goods_info> list1 = new List<Goods_info>
                {
                    ur
                };
                return list1;
            }
            List<Goods_info> list = new List<Goods_info>();
            list=DataTableToGoods_info(dt);
            return list;
        }
        /// <summary>
        /// 根据账号或者UID获取用户信息
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public User_info Get_Userinfo(string account)
        {
            string sql = "select * from User_info where UID=@account or account=@account";
            SqlParameter para = new SqlParameter("@account", account);
            DataTable dt=new DataTable();
            try
            {
                dt=SqlHelper.ExecuteDataTable(sql, para);
            }catch(Exception ex)
            {
                User_info ur = new User_info();
                ur.UID = "Error";
            }
            List<User_info> list =   DataTableToUser_info(dt);
            return list[0];
           
        }
        /// <summary>
        /// DataTable转List<Goods_info>
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private List<Goods_info> DataTableToGoods_info(DataTable dt)
        {
            List<Goods_info> list = new List<Goods_info>();
           foreach(DataRow dr in dt.Rows)
            {
                Goods_info gi=new Goods_info();
                gi.Serial_Num = int.Parse(dr[0].ToString());
                gi.Owner = dr[1].ToString();
                gi.Description = dr[2].ToString();
                gi.Price = float.Parse(dr[3].ToString());
                gi.count = int.Parse(dr[4].ToString());
                list.Add(gi);
            }
            return list;
        }
        /// <summary>
        /// DataTable转list<User_info>
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private List<User_info> DataTableToUser_info(DataTable dt)
        {
            List<User_info> list = new List<User_info>();
            foreach(DataRow dr in dt.Rows)
            {
                User_info ur = new User_info();
                ur.UID = dr[0].ToString();
                ur.account = dr[1].ToString();
                ur.pwd = dr[2].ToString();
                ur.Name = dr[3].ToString();
                ur.Wallet = float.Parse(dr[4].ToString());
                ur.My_goods = dr[5].ToString();
                ur.Face = dr[6].ToString();
                list.Add(ur);
            }
            return list;
        }
    }
    
}