<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rigister.aspx.cs" Inherits="own.Rigister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
            font-size: medium;
        }
        .auto-style2 {
            font-size: medium;
        }
        .auto-style3 {
            height: 750px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style3" style="background-color: #99FF99">
        <div>
            <strong><span class="auto-style2">user name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" CssClass="auto-style2" ErrorMessage="*Must enter username" ForeColor="Red"></asp:RequiredFieldValidator>
            <br class="auto-style2" />
            <span class="auto-style2">password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" CssClass="auto-style2" ErrorMessage="*Must enter password" ForeColor="Red"></asp:RequiredFieldValidator>
            <span class="auto-style2">&nbsp; </span>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox1" ControlToValidate="TextBox2" CssClass="auto-style2" ErrorMessage="*password and username must not be same" ForeColor="Red" Operator="NotEqual"></asp:CompareValidator>
            <br class="auto-style2" />
            <span class="auto-style2">confirm pwd&nbsp; </span>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style1"></asp:TextBox>
            </strong>&nbsp;<strong><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" CssClass="auto-style2" ErrorMessage="*Must enter confirm password" ForeColor="Red"></asp:RequiredFieldValidator>
            <span class="auto-style2">&nbsp; </span>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" CssClass="auto-style2" ErrorMessage="*password and must be same" ForeColor="Red"></asp:CompareValidator>
            <br class="auto-style2" />
            <span class="auto-style2">gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:RadioButton ID="RadioButton1" runat="server" CssClass="auto-style2" GroupName="v" Text="Male" />
            <span class="auto-style2">&nbsp; </span>
            <asp:RadioButton ID="RadioButton2" runat="server" CssClass="auto-style2" GroupName="v" Text="Female" />
            <br class="auto-style2" />
            <span class="auto-style2">Language&nbsp;&nbsp; </span>
            <asp:CheckBox ID="CheckBox1" runat="server" CssClass="auto-style2" Text="Tel" />
            </strong>&nbsp;<strong><asp:CheckBox ID="CheckBox2" runat="server" CssClass="auto-style2" Text="Eng" />
            <span class="auto-style2">&nbsp; </span>
            <asp:CheckBox ID="CheckBox3" runat="server" CssClass="auto-style2" Text="Hin" />
            <br class="auto-style2" />
            <span class="auto-style2">state&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style1" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            </strong>&nbsp;<strong><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" CssClass="auto-style2" ErrorMessage="*Must select state" ForeColor="Red"></asp:RequiredFieldValidator>
            <br class="auto-style2" />
            <span class="auto-style2">city&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style1">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DropDownList2" CssClass="auto-style2" ErrorMessage="*Must select city" ForeColor="Red"></asp:RequiredFieldValidator>
            <br class="auto-style2" />
            <span class="auto-style2">Blood group&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:DropDownList ID="DropDownList3" runat="server" CssClass="auto-style1">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DropDownList3" CssClass="auto-style2" ErrorMessage="*Must select blood group" ForeColor="Red"></asp:RequiredFieldValidator>
            <br class="auto-style2" />
            <span class="auto-style2">phno&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style1"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" CssClass="auto-style2" ErrorMessage="*Enter valid phone number" ForeColor="Red" ValidationExpression="[6-9]{1}[0-9]{9}"></asp:RegularExpressionValidator>
            <br class="auto-style2" />
            <span class="auto-style2">Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style1"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox5" CssClass="auto-style2" ErrorMessage="*must enter valid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style1" Text="Register" OnClick="Button1_Click" />
            <span class="auto-style2">&nbsp;&nbsp;&nbsp; </span>
            <asp:Button ID="Button2" runat="server" CssClass="auto-style1" Text="clear" OnClick="Button2_Click" />
            <br />
            </strong>
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
