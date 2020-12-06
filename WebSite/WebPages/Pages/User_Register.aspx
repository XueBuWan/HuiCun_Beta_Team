<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Register.aspx.cs" Inherits="WebPages.Pages.User_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>注册</title>
   <script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-3.5.1.min.js"></script>
    <script type="text/javascript" src="../js/Check.js"></script>
</head>
<body>
    <form id="form1" runat="server">
      <table border="0">
          <tr>
              <th style="width:10px;height:10px;border:solid"><div style="top:0">
                  <asp:ImageButton ID="Lg" runat="server" src="../Pictures/商标.jpg" Height="20px" Width="44px" OnClick="Lg_Click"  />
                  </div>
              </th>
              
              <th rowspan="2" style="border:solid"> <div>
            <asp:Label id="UIDLabel" CssClass="RegLabel" runat="server" Text="学&nbsp&nbsp号："></asp:Label>
            <asp:TextBox ID="UIDTextBox" CssClass="RegTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label id="AccountLable" CssClass="RegLabel" runat="server" Text="账&nbsp&nbsp号："></asp:Label>
             <asp:TextBox ID="AccountTextBox" CssClass="RegTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label id="PwdLable" CssClass="RegLabel" runat="server" Text="密&nbsp&nbsp码："></asp:Label>
             <asp:TextBox ID="PwdTextBox" CssClass="RegTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label id="PwdLable_Check" CssClass="RegLabel" runat="server" Text="确认密码："></asp:Label>
            <asp:TextBox ID="PwdTextBox_Check" CssClass="RegTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label id="CheckLabel" CssClass="RegLabel" runat="server" Text="验证码："></asp:Label>
            <input type="text" id="CheckText" runat="server" value="" placeholder="（不区分大小写）" />
             <canvas id="canvas" width="100" height="30"></canvas>
             <br />

            <asp:Button ID="ChectButton" runat="server" Text="确认" OnClick="ChectButton_Click" />
         </div></th>
              
          </tr>
          <tr>
              <th></th>
          </tr>
          
          
          </table>
       
             <input id="SendData1" type="hidden" runat="server" />
    </form>
</body>
</html>
