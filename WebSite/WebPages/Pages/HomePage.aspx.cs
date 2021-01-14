using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Bll;
using Model;
namespace WebPages.Pages
{
    public partial class HomePage : System.Web.UI.Page
    {
        BllLayer bll = new BllLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UID"] is null)
                {
                     Response.Write("<script>alert('请登录')</script>");
                    Response.Redirect("User_Register.aspx");
                   
                }
                else
                {
                    Response.Write(string.Format("<script>alert('欢迎您,{0}')</script>", Session["UID"].ToString()));
                }
            }
        }
        private void Goods_Load(int pageindex)
        {   
            XmlDocument xml = new XmlDocument();
            List<Goods_info> list = new List<Goods_info>();
            list = bll.Get_Goods(pageindex);
            foreach(Goods_info gi in list)
            {
                xml.Load(gi.Description);
                XmlElement good = xml.DocumentElement;
                gi.name = good.GetElementsByTagName("name")[0].InnerText;
                gi.count = int.Parse(good.GetElementsByTagName("count")[0].InnerText);
                foreach (string str in good.GetElementsByTagName("label"))
                {
                    gi.lable.Add(str);
                }
                foreach (string str in good.GetElementsByTagName("picture"))
                {
                    gi.picture.Add(str);
                }
                gi.filemd = good.GetElementsByTagName("filemd")[0].InnerText;

            }
            Repeater1.DataSource = list;


        }
    }
}