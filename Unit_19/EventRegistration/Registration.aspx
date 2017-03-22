<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="EventRegistration.Registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>登录界面</title>
    <style type="text/css">
        table{background-color:#646464; color:White;}
        tr{height:30px;width:180px;}
        #dropDownListEvents{width:100%;}
        input{width:98%;padding:0px;}
        #buttonSubmit
        {
        }
        .style1
        {
            width: 136px;
        }
        .style2
        {
            width: 348px;
        }
        .style3
        {
            height: 97px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style=" margin:30px auto;" cellspacing="0">
        
            <tr>
                <td class="style1">
                    <asp:Label ID="labelEvent" runat="server" Text="Event:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:DropDownList ID="dropDownListEvents" runat="server" >
                        <asp:ListItem>Introduce to ASP.NET</asp:ListItem>
                        <asp:ListItem>Introduce to MYNAME</asp:ListItem>
                        <asp:ListItem>Introduce to HELLOWORLD</asp:ListItem>
                        <asp:ListItem>Introduce to WINDOWS</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td class="style1">
                    <asp:Label ID="labelFirstName" runat="server" Text="First Name:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="textFirstName" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td class="style1">
                    <asp:Label ID="labelLastName" runat="server" Text="Last Name:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="textLastName" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="style1">
                    <asp:Label ID="labelEmail" runat="server" Text="Email:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="textEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td colspan="2">
                    <asp:Button ID="buttonSubmit" runat="server" Text="Submit" Height="40px" 
                        onclick="buttonSubmit_Click" Width="485px" PostBackUrl="~/ResultsPage.aspx"></asp:Button>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="style3">
                    <asp:Label ID="labelResult" runat="server"></asp:Label>
                </td>
            </tr>
            
        </table>
    
    </div>
    </form>

</body>
</html>
