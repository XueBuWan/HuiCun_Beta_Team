using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Model;

namespace Bll
{
    public class BllLayer
    {
        DalLayer dal = new DalLayer();
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="account">账号（或学号）</param>
        /// <param name="pwd">密码</param>
        /// <returns>1表示认证成功；-1表示访问数据库出错；0表示账号密码错误</returns>
        public int Check_Login(string account ,string pwd)
        {
           return  dal.Login_Check(account, pwd);
           
        }
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="ul">用户注册对象（account可以为空）</param>
        /// <returns>-1表示访问数据库出错（有可能是该学号已被注册）;1表示注册成功;0表示注册失败</returns>
        public int User_Register(User_Login_1 ul)
        {
            return dal.User_Register(ul);
        }
        /// <summary>
        /// 获取商品信息xml文件的地址
        /// </summary>
        /// <param name="Serial_Num">商品编号</param>
        /// <returns>"Error" 表示访问数据库出错;"None" 表示该物品不存在;其他则表示商品信息的xml文件地址</returns>
        public string Get_Goodinfo(int Serial_Num)
        {
            return dal.Get_GoodInfo(Serial_Num);
        }

        public List<Goods_info> Get_Goods(int pageindex)
        {
            return dal.Get_Goods(pageindex);
        }
        public User_info Get_Userinfo(string account)
        {
            return dal.Get_Userinfo(account);
        }
    }
}
