<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Result.aspx.cs" Inherits="Result" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="Button11" runat="server" BackColor="Black" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="35px" Text="PSC Result" Width="359px" />
<br />
<br />
<asp:Button ID="Button12" runat="server" BackColor="#33CC33" BorderColor="Black" BorderStyle="Groove" BorderWidth="3px" Font-Bold="True" Font-Size="Large" ForeColor="White" OnClick="Button12_Click" Text="2017" />
<br />
<br />
<asp:Button ID="Button13" runat="server" BackColor="#33CC33" BorderColor="Black" BorderStyle="Groove" BorderWidth="3px" Font-Bold="True" Font-Size="Large" ForeColor="White" OnClick="Button13_Click" Text="2016" />
<br />
<br />
<asp:Button ID="Button14" runat="server" BackColor="#33CC33" BorderColor="Black" BorderStyle="Groove" BorderWidth="3px" Font-Bold="True" Font-Size="Large" ForeColor="White" OnClick="Button14_Click" Text="2015" />
<br />
<br />
<asp:Button ID="Button15" runat="server" BackColor="#33CC33" BorderColor="Black" BorderStyle="Groove" BorderWidth="3px" Font-Bold="True" Font-Size="Large" ForeColor="White" OnClick="Button15_Click" Text="2014" />
<br />
<br />
<asp:Button ID="Button16" runat="server" BackColor="#33CC33" BorderColor="Black" BorderStyle="Groove" BorderWidth="3px" Font-Bold="True" Font-Size="Large" ForeColor="White" OnClick="Button16_Click" Text="2013" />
<br />
<asp:GridView ID="GridView1" runat="server">
</asp:GridView>
<br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

