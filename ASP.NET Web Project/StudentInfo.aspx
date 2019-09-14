<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="StudentInfo.aspx.cs" Inherits="StudentInfo" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="Button2" runat="server" BackColor="#333300" BorderColor="Lime" BorderStyle="Ridge" BorderWidth="4px" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="Class 1" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" BackColor="#333300" BorderColor="Lime" BorderStyle="Ridge" BorderWidth="4px" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="Class 2" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" BackColor="#333300" BorderColor="Lime" BorderStyle="Ridge" BorderWidth="4px" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="Class 3" OnClick="Button4_Click" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button5" runat="server" BackColor="#333300" BorderColor="Lime" BorderStyle="Ridge" BorderWidth="4px" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="Class 4" OnClick="Button5_Click" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button6" runat="server" BackColor="#333300" BorderColor="#00CC00" BorderStyle="Ridge" BorderWidth="4px" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="Class 5" OnClick="Button6_Click" />
&nbsp;
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" BackColor="#009900" BorderColor="#006600" BorderStyle="Groove" BorderWidth="4px" Font-Bold="True" Font-Names="Arial Black" Font-Size="Large" ForeColor="White" Text="If You Want To Delete Or Update Your Details Please Click Below"></asp:Label>
    <br />
    <asp:Button ID="Button11" runat="server" BackColor="#006600" BorderColor="Red" BorderStyle="Double" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" OnClick="Button11_Click" Text="Click here" />
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Lime" Text="It's only for student"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
 </asp:Content> 

 

