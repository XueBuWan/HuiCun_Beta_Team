﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebPages.Pages.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="../Css/SideGuide.css"/>
      <script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-3.5.1.min.js"></script>
    <script type="text/javascript" src="../js/Guidejs.js"></script>
    <style type="text/css">
    #Page{

        background-color:red
    }
    #Logo{
        width: 20em;
        height:10em;
       background-color:blue;
       position:absolute;
       left:10em;
       top:5em;

    }
    #SearchBox{
        width:30em;
        height:2em;
        background-color:#00ff21;
        position:absolute;
        left:35em;
        top:6em;
    }
    #RecordsBox{
        width:35em;
        height:5em;
        background-color:#96f341;
        position:absolute;
        left:34em;
        top:10em;

    }
    #ShowBox{
        width:50em;
        height:auto;
        background-color:#29e3d3;
        position:absolute;
        left:13em;
        top:18em;
    }
        #SearchButton {
            width: 52px;
            margin-top: 0px;
        }
    </style>
</head>
<body>
        <div id="side">
            <ul id="sideul">
                <li class="sideli" id="sideliface">
                     <img id="face" runat="server" src="../Pictures/facetest.jpg" />
                    
                </li>  
                <li class="sideli">
                     <a href="Self_Info.aspx" class="SideLink" runat="server" id="SelfInfo">个人信息</a>
                </li>
                <li class="sideli">
                     <a href="" class="SideLink" runat="server" id="ShoppingCart">购物车</a>
                </li>
            </ul>
               <input id="opt" runat="server" type="image" src="../Pictures/left.jpg"  onclick="move()"/>
           
           
        </div> 
    <form id="form1" runat="server">
        
        <div id="Page" >
            <div id="Logo" >
               
                <img src="../Pictures/商标.jpg"  style="width: 350px; height: 226px"/>
            </div>
            <div id="SearchBox">
               
              
                <asp:TextBox id="SearchBox1" runat="server" Height="29px" Width="491px"></asp:TextBox>
                <button id="SearchButton" runat="server">搜索</button>
            </div>
            <div id="RecordsBox">
                <asp:TextBox ID="RecordsBox1" runat="server" Height="92px" Width="694px"></asp:TextBox>
            </div>
            <div id="ShowBox">
                ShowBox
                <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>我是脑袋<table></HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <th>
                                <img src="<%#Eval("picture[0]")%>"/>
                            </th>
                            <th>
                                <div>
                                <label id="label3" class="showlable" runat="server" text="" ><%#Eval("name")%></label>
                                <br />
                                <label id="label1" class="showlable" runat="server" text="">价格：</label><%#Eval("prince")%>
                                <br />
                                    <asp:Button ID="Button1" runat="server" Text="查看" />
                                     <asp:Button ID="Button2" runat="server" Text="购买" />
                                </div>
                                
                            </th>
                        </tr>
                    </ItemTemplate>
                <FooterTemplate></table></FooterTemplate>
                </asp:Repeater>

            </div>
        </div>
        <div style="height:10000px;background-color:aqua"></div>
    </form>
</body>
</html>
