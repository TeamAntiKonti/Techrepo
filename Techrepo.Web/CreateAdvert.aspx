<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAdvert.aspx.cs" Inherits="Techrepo.Web.CreateAdvert" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <h2>Create Advert</h2>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server">Title</asp:Label>
            <asp:TextBox ID="AdvertTitle" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" >Description</asp:Label>
            <asp:TextBox ID="AdvertDescription" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server">Price</asp:Label>
            <asp:TextBox ID="AdvertPrice" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server">Email</asp:Label>
            <asp:TextBox ID="OwnerEmail" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" >Phone</asp:Label>
            <asp:TextBox ID="OwnerPhone" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" >Category</asp:Label>
            <asp:DropDownList ID="Category" DataTextField="Name" DataValueField="Id" runat="server" ></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label ID="Label9" runat="server" >City</asp:Label>
            <asp:DropDownList ID="City" DataTextField="Name" DataValueField="Id" runat="server" ></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label ID="Label7" runat="server" >State</asp:Label>
            <asp:DropDownList ID="ProductState" runat="server" ></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label ID="Label8" runat="server" >Delivery</asp:Label>
            <asp:DropDownList ID="Delivery" runat="server" ></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="UploadedImages" CssClass="col-md-2 control-label">Images</asp:Label>
            <div class="col-md-3">
                <asp:FileUpload runat="server" ID="UploadedImages" AllowMultiple="true" CssClass="form-control"></asp:FileUpload>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateAdvert_Click" Text="Create" CssClass="btn btn-default" />
            </div>
        </div>
        <br />
        <asp:Label runat="server" ID="StatusLabel" Text="Create status: " />
    </div>
</asp:Content>
