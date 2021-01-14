using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ValidaterPicture;
using Model;
using Bll;
namespace WebPages.Pages
{
    public partial class User_Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
      
        protected void ChectButton_Click(object sender, EventArgs e)
        {
            string UID = UIDTextBox.Text;
            string account = AccountTextBox.Text;
            string pwd = PwdTextBox.Text;
            string pwd_again = PwdTextBox_Check.Text;
            if(pwd != pwd_again)
            {
                Response.Write("<script>alert('两次密码输入不一致,请重试！')</script>");

            }
            else
            {
                 string ans = SendData1.Value.ToLower();
                string ipt = CheckText.Value.ToLower();
                 string str=ans.Replace(",", "");
            if(str == ipt)
            {
                    User_Login_1 ul = new User_Login_1();
                    ul.UID = UID;
                    ul.account = account;
                    ul.pwd = pwd;
                    BllLayer bll = new BllLayer();
                    int flag = bll.User_Register(ul);
                    if(flag == 1)
                    {

                        Response.Write("<script>alert('注册成功')</script>");
                    }
                    else
                    {
                        Response.Write(string.Format("<script>alert('出错，错误代码{0}')</script>",flag));
                    }
                
            }
            else
            {
                Response.Write("<script>alert('验证码错误')</script>");
            }
            }

        }

       protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string account = Login1.UserName;
            string pwd = Login1.Password;
            BllLayer bll = new BllLayer();
            int flag = bll.Check_Login(account, pwd);
            if (flag == 1)
            {
                Login1.DestinationPageUrl = "HomePage.aspx";
                Session.Add("UID", bll.Get_Userinfo(account).UID);
                e.Authenticated = true;
            }
            else if (flag == 0)
            {
                // Response.Write("<style>alert('账号或密码错误！')</style>");

                e.Authenticated = false;
            }
        }

    }
}