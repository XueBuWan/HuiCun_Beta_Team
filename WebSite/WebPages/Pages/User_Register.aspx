<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Register.aspx.cs" Inherits="WebPages.Pages.User_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录/注册</title>
   <script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-3.5.1.min.js"></script>
    <script type="text/javascript" src="../js/Check.js"></script>
<script>
    function register() {
        $("#Register").animate({
            left: '500px',
            opacity: 1
        });
        $("#Login").animate({
            left: '1000px',
            opacity:0
        })
    }
    function login() {
        $("#Register").animate({
            left: '-200px',
            opacity: 0
        });
        $("#Login").animate({
            left: '500px',
            opacity: 1
        })
    }
    
    $(document).keypress(function (event) {
        console.log("123");
        var keycode = (event.keyCode ? event.keyCode : event.which);
        if (keycode == 13) {
            console.log("1777");
            console.log(document.activeElement.tagName);
            console.log(document.activeElement.parentElement);
            var x = document.activeElement;
            x = x.parentElement;
            console.log(x.tagName);

         
            while (x.tagName != 'DIV') {
                x = x.parentElement;
                console.log(x.tagName);
            }

            if (x.className == 'login') {
                $("#Login1_LoginButton").focus();
            } else if (x.className == 'reg') {

            }
            return false;
        }
      
    });
</script>
    <style>

        #Register{
            position:absolute;
            left:-1000px;
            top:100px;
            opacity:0
        }
        #Login{

            position:absolute;
            left:500px;
            top:100px;
            opacity:1
        }
         .auto-style1 {
            width: 228px;
            height: 274px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server"> 
        <div id="Register">
      <table border="0" id="regtable">
          <tr>
              <th style="width:10px;height:10px;border:solid"><div style="top:0">
                 <input type="button" onclick="login()" value="登录"/>
                  </div>
              </th>
              
              <th rowspan="2" style="border:solid"> 
             <div id="reg">
                  <p>注册</p>
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
            <input type="text" id="CheckText" runat="server" value="" placeholder="（不区分大小写）" autofocus="autofocus" />
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

        </div>


         
      <div id="Login" class="login">
   
        <div>
            <table border="1">
                <tr>
                    <th >登录 </th>
                    <th > </th>
                    <th>
                        <input type="button" onclick="register()" value="注册"/>
                    </th>
                </tr>
                <tr>
                    <th>
                        <img src="../Pictures/商标.jpg" class="auto-style1"/>
                    </th>
                    <th>
                        <div class="login">                       
                       <asp:Login ID="Login1" CssClass="login" runat="server" OnAuthenticate="Login1_Authenticate" TitleText="" TabIndex="0"></asp:Login>                        
                        </div>
                    </th>
                    
                </tr>
                
            </table>

        </div>

</div>
    
    </form>
  
</body>
</html>
