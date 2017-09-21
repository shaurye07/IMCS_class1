<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="WebApplication1.WebUserControl1" %>
<asp:Panel ID="Panel1" runat="server" Height="93px" Width="357px">
    <asp:Label ID="Label1" runat="server" Text="State: "></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="List" Height="20px" Width="156px">
        <asp:ListItem Value="3">Burmingham</asp:ListItem>
        <asp:ListItem Value="1">Arlington</asp:ListItem>
        <asp:ListItem Value="2">Boston</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    Zip Code:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="175px"></asp:TextBox>
</asp:Panel>

