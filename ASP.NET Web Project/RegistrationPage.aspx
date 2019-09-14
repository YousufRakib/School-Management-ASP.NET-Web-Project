<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistrationPage.aspx.cs" Inherits="RegistrationPage" %>

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
                <asp:Button ID="Button2" runat="server" BackColor="#33CC33" BorderStyle="None" Font-Bold="True" Font-Names="Arial Black" Font-Size="X-Large" ForeColor="White" Height="63px" Text="Registration Page" Width="378px" />
                <br />
                <br />
                <asp:Label ID="Label2" CssClass="lbl1 lblstyle" runat="server" Text="First Name" Font-Bold="True" Font-Names="Aharoni"></asp:Label><br />
                <asp:TextBox ID="TxtFName" CssClass="txtstyle" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" CssClass="lbl1 lblstyle" runat="server" Text="Last Name" Font-Bold="True" Font-Names="Aharoni"></asp:Label><br />
                <asp:TextBox ID="TxtLName" CssClass="txtstyle" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label4" CssClass="lbl1 lblstyle" runat="server" Text="Student Id" Font-Bold="True" Font-Names="Aharoni"></asp:Label><br />
                <asp:TextBox ID="TxtSId" CssClass="txtstyle" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label11" runat="server" Font-Bold="False" Font-Names="Aharoni" Font-Size="Large" Text="Class Name"></asp:Label>
                <br />
                <asp:TextBox ID="TxtCName" runat="server" TextMode="Number"> </asp:TextBox>
                <br />
                <asp:Label ID="Label5" CssClass="lbl1 lblstyle" runat="server" Text="Username" Font-Bold="True" Font-Names="Aharoni"></asp:Label><br />
                <asp:TextBox ID="TxtUName" CssClass="txtstyle" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label6" CssClass="lbl1 lblstyle" runat="server" Text="Email" Font-Bold="True" Font-Names="Aharoni"></asp:Label><br />
                <asp:TextBox ID="TxtEmail" CssClass="txtstyle" runat="server" TextMode="Email"></asp:TextBox>
                <br />
                <asp:Label ID="Label7" runat="server" CssClass="lbl2 lblstyle" Text="Password" Font-Bold="True" Font-Names="Aharoni"></asp:Label><br />
                <asp:TextBox ID="TxtPassword" CssClass="txtstyle" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <asp:Label ID="Label8" CssClass="lbl1 lblstyle" runat="server" Text="Mobile" Font-Bold="True" Font-Names="Aharoni"></asp:Label><br />
                <asp:TextBox ID="TxtMobile" runat="server" TextMode="Phone"></asp:TextBox>
                <br />
                <asp:Label ID="Label9" CssClass="lbl1 lblstyle" runat="server" Text="Age" Font-Bold="True" Font-Names="Aharoni"></asp:Label><br />
                <asp:TextBox ID="TxtAge" CssClass="txtstyle" runat="server" TextMode="Number"></asp:TextBox>
                <br />
                <asp:Label ID="Label10" CssClass="lbl1 lblstyle" runat="server" Text="Present Address" Font-Bold="True" Font-Names="Aharoni"></asp:Label><br />
                <asp:TextBox ID="TxtAddress" CssClass="txtstyle" runat="server"></asp:TextBox><br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Sign Up" BackColor="#66FF33" BorderColor="White" BorderStyle="Inset" Font-Bold="True" OnClick="Button1_Click" />  

            </div>
            </div>
           
    </form>
</body>
</html>
