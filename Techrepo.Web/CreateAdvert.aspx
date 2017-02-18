<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAdvert.aspx.cs" Inherits="Techrepo.Web.CreateAdvert" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <h2>Create Advert</h2>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server">Title</asp:Label>
            <asp:TextBox ID="textBoxTitle" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" >Description</asp:Label>
            <asp:TextBox ID="textBoxDescription" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server">Price</asp:Label>
            <asp:TextBox ID="textBox1" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server">Email</asp:Label>
            <asp:TextBox ID="textBox2" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" >Phone</asp:Label>
            <asp:TextBox ID="textBox3" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" >Category</asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" ></asp:DropDownList>
        </div>
    </div>
</asp:Content>
