<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MichaelBaldwinLab1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FFFFFF;
            background-color: #FF3300;
        }
        .auto-style2 {
            width: 378px;
            background-color: #6699FF;
        }
    </style>
</head>
<body style="width: 100%; height: 275px;">
    <form id="form1" runat="server">
        <div style="text-align: center" class="auto-style1">
            Your Favorite States</div>
    <div style="width: 299px" >
        Enter Your Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="userTextBox" runat="server" Height="16px"></asp:TextBox>
    </div>
    <div style="width: 301px" >
        Enter Your Password:&nbsp;&nbsp;
        <asp:TextBox ID="passwordTextBox" runat="server" Height="16px"></asp:TextBox>
    </div>
    <div class="auto-style2" >
        <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" BorderWidth="1px" />
&nbsp;
        <asp:Button ID="clearButton" runat="server" Text="Clear" OnClick="clearButton_Click" BorderWidth="1px" />
&nbsp;
        <asp:Button ID="nextButton" runat="server" Text="Next" OnClick="nextButton_Click" Visible="False" BorderWidth="1px" />
    </div>
        <div style="height: 94px; text-align: center; width: 300px">
            <asp:Image ID="userImage" runat="server" Height="85px" style="text-align: center" Visible="False" Width="109px" />
        </div>
        <div style="width: 299px; text-align: center">
            <asp:Label ID="welcomeLabel" runat="server" Visible="False"></asp:Label>
        </div>
        <asp:CheckBox ID="infoCheckBox" runat="server" OnCheckedChanged="infoCheckBox_CheckedChanged" AutoPostBack="True" Text="Check to see info about the next page." Visible="False" />
        <p>
            <asp:Label ID="pageInfoLabel" runat="server" BorderColor="#3399FF" Text="On the next page you will see information about 3 different states." Visible="False" Width="100%"></asp:Label>
        </p>
    </form>
    </body>
</html>
