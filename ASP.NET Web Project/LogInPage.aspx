<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogInPage.aspx.cs" Inherits="LogInPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>

        body {
            background-image: url('../Images/25.jpg');
            background-repeat: no-repeat;
            background-size: cover;
            width: 100vw;
            height: 200vh;
            display: flex;
            align-items: flex-start;
            justify-content: center;
        }                           
        .lblstyle{
            font-size:2vw;
            font-family: 'Righteous', cursive;
            color:#000000 ;
        }
        input
        {
            background:#ffffff;
        }
        .auto-style1 {
            width: 1186px;
            height: 97px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width:1100px;margin :0 auto">
            <tr style="width:1100px;">
                <td class="auto-style10">
                    <img src="Images/17.png" class="auto-style1" />    
                </td>
                </tr>
            </table>
    <div class="formclass">
            <div class="inner animated fadeInDown">
                                               
                &nbsp;
                <br />
                <br />
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" BackColor="#33CC33" BorderStyle="None" Font-Bold="True" Font-Names="Arial Black" Font-Size="X-Large" ForeColor="White" Height="63px" Text="Login Page" Width="378px" />
                <br />
                <br />
                <asp:Label ID="Label5" CssClass="lbl1 lblstyle" runat="server" Text="Username" Font-Bold="True" Font-Names="Aharoni"></asp:Label>&nbsp;<br />
                <asp:TextBox ID="uname" CssClass="txtstyle" runat="server" TextMode="Password" Width="136px"></asp:TextBox>
                <br />
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Aharoni" Text="Password"></asp:Label>
                <br />
                <asp:TextBox ID="password" runat="server" TextMode="Password" Width="136px"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Log in" BackColor="#66FF33" BorderColor="White" BorderStyle="Inset" Font-Bold="True" OnClick="Button1_Click" />  

            </div>
            </div>
    </form>
</body>
</html>
