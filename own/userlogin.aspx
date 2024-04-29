<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="own.userlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
            font-size: large;
        }
        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            height: 1068px;
        }
        .auto-style4 {
            width: 833px;
            height: 437px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style3" style="background-color: #FFCCFF">
        <div>
            <strong>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Text="Label" Visible="False"></asp:Label>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <span class="auto-style2">user name&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1"></asp:TextBox>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <span class="auto-style2">password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style1" TextMode="Password"></asp:TextBox>
            </strong>&nbsp;<strong><br class="auto-style2" />
            <br class="auto-style2" />
            <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style1" OnClick="Button1_Click" Text="Login" />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <img alt="" class="auto-style4" src="Models/pics/Blood5.jpg" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </strong>
        </div>
    </form>
</body>
</html>
