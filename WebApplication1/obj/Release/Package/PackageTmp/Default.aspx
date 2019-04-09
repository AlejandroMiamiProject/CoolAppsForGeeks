<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Code Behind Example</h1>
    <asp:TextBox ID="txtVendors" CssClass="form-control" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Button" OnClick="Button1_Click" />
    <asp:Label ID="lblVendors" runat="server" Text=""></asp:Label>

</asp:Content>
