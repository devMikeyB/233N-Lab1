<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="States.aspx.cs" Inherits="MichaelBaldwinLab1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
        }
        .auto-style2 {
            width: 243px;
            height: 100%;
        }
        .auto-style3 {
            width: 1049px;
            text-align: left;
        }
        .auto-style4 {
            width: 243px;
            height: 190px;
        }
        .auto-style5 {
            width: 1049px;
            height: 190px;
            text-align: center;
        }
        .auto-style6 {
            height: 190px;
        }
        .auto-style7 {
            height: 296px;
            width: 100%;
        }
        .auto-style8 {
            width: 100%;
            height: 193px;
        }
        .auto-style9 {
            width: 243px;
            height: 58px;
        }
        .auto-style10 {
            width: 1049px;
            height: 58px;
        }
        .auto-style11 {
            height: 58px;
        }
        .auto-style12 {
            width: 100%;
            height: 100%;
        }
    </style>
</head>
<body style="width: 100%; height: 343px;">
    <form id="form1" runat="server">
        <div class="auto-style1" style="text-align: center; font-size: large; font-weight: 700">
            Three Recommended States</div>
        <div style="height: 100%; width: 100%" class="auto-style7">
            <table class="auto-style8" style="height: 100%">
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <div style="border-style: solid">
                            <asp:RadioButtonList ID="stateRadioButtonList" runat="server" OnSelectedIndexChanged="stateRadioButtonList_SelectedIndexChanged" Width="235px" AutoPostBack="True">
                                <asp:ListItem>State of Oregon</asp:ListItem>
                                <asp:ListItem>State of Colorado</asp:ListItem>
                                <asp:ListItem>State of Utah</asp:ListItem>
                                <asp:ListItem>Clear</asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                    </td>
                    <td class="auto-style5">
                        <asp:Image ID="stateImage" runat="server" Height="178px" Width="193px" />
                    </td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <div class="auto-style12">
                            <asp:DropDownList ID="populationDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="populationDropDownList_SelectedIndexChanged" Width="60%">
                                <asp:ListItem>State Population</asp:ListItem>
                                <asp:ListItem>Oregon</asp:ListItem>
                                <asp:ListItem>Colorado</asp:ListItem>
                                <asp:ListItem>Utah</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </td>
                    <td class="auto-style3"style="height: 100%">
                        <div id="stateInfoDiv" runat="server" style="width: 100%; height: 100%;">
                            <asp:Label ID="stateInfoLabel" runat="server" Height="100%" Width="100%"></asp:Label>
                            </div>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:Button ID="prevButton" runat="server" OnClick="prevButton_Click" Text="Previous Page" Width="118px" />
    </form>
</body>
</html>
