<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adminlogin.aspx.cs" Inherits="own.Adminlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            height: 871px;
        }
        .auto-style3 {
            width: 714px;
            height: 310px;
            margin-left: 86px;
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style2" style="background-color: #99CCFF">
        <div>
            <strong>
            <br class="auto-style1" />
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False" CssClass="auto-style1"></asp:Label>
            <br />
            <br class="auto-style1" />
            <span class="auto-style1">user Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1"></asp:TextBox>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <span class="auto-style1">password&nbsp;
            &nbsp;
            </span>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style1" TextMode="Password"></asp:TextBox>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </span>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" CssClass="auto-style1" />
            <br />
            <br />
            <br />
            <img alt="" class="auto-style3" src="Models/pics/Blood4.jpg" /><br />
            <br />
            <br />
            <br />
&nbsp;</strong></div>
    </form>
</body>
</html>
