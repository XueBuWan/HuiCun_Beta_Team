using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPages.Pages
{
    public partial class User_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string account = Login1.UserName;
            string pwd = Login1.Password;
            BllLayer bll = new BllLayer();
            int flag=bll.Check_Login(account, pwd);
            if (flag == 1)
            {
                Login1.DestinationPageUrl = "HomePage.aspx";
                Session.Add("UID", bll.Get_Userinfo(account).UID);
                e.Authenticated = true;
            }
            else if(flag == 0)
            {
               // Response.Write("<style>alert('账号或密码错误！')</style>");
               
                e.Authenticated = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_Register.aspx");
        }
    }
}