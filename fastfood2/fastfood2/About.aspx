<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="fastfood2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>my cart is</h2>
    <h3>thts what your chose.</h3>
    <p>
        <asp:GridView ID="GridView1" runat="server" Width="581px">
        </asp:GridView>
    </p>
    <h2>the total price is:<asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="delete cart" />
    </h2>
    
</asp:Content>
