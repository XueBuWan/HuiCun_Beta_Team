<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Login.aspx.cs" Inherits="WebPages.Pages.User_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   <script src="https://s3.pstatp.com/cdn/expire-1-M/jquery/3.1.1/jquery.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 228px;
            height: 274px;
        }
    </style>
</head>
   
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <th >
                        登录

                    </th>
                    <th >
                        
                    </th>
                    
                    <th>
                        <asp:Button ID="Button1" runat="server" Text="注册" OnClick="Button1_Click" />
                    </th>
                </tr>
                <tr>
                    <th>
                        <img src="../Pictures/商标.jpg" class="auto-style1"/>
                    </th>
                    <th>
                        <div>
                           
                            
                              
                       <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" TitleText=""></asp:Login>
                           
                               

                        </div>

                    </th>
                    
                </tr>
                
            </table>

        </div>
    </form>
</body>
</html>
