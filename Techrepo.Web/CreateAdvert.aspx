<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAdvert.aspx.cs" Inherits="Techrepo.Web.CreateAdvert" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Create Advert</h2>
    <hr />  
    <div class="form-group col-md-4">
    <div class="form-horizontal">              
        <div class="form-group">
            <asp:Label ID="Label1" AssociatedControlID="AdvertTitle" CssClass="control-label" runat="server">Title: </asp:Label>
            <asp:TextBox Width="180" ID="AdvertTitle" runat="server"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <asp:Label ID="Label3" AssociatedControlID="AdvertPrice" CssClass="control-label" runat="server">Price: </asp:Label>
            <asp:TextBox Width="180" ID="AdvertPrice" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" AssociatedControlID="OwnerEmail" CssClass="control-label" runat="server">Email: </asp:Label>
            <asp:TextBox Width="180" ID="OwnerEmail" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" AssociatedControlID="OwnerPhone" CssClass="control-label" runat="server" >Phone: </asp:Label>
            <asp:TextBox Width="180" ID="OwnerPhone" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label AssociatedControlID="Category" ID="Label6" CssClass="control-label" runat="server" >Category: </asp:Label>
            <asp:DropDownList Width="180" CssClass="btn btn btn-default btn-sm" ID="Category" DataTextField="Name" DataValueField="Id" runat="server" ></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label ID="Label9" AssociatedControlID="City" CssClass="control-label" runat="server" >City :</asp:Label>
            <asp:DropDownList Width="180" CssClass="btn btn btn-default btn-sm" ID="City" DataTextField="Name" DataValueField="Id" runat="server" ></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label ID="Label7" AssociatedControlID="ProductState" CssClass="control-label" runat="server" >State: </asp:Label>
            <asp:DropDownList Width="180" CssClass="btn btn btn-default btn-sm" ID="ProductState" runat="server" ></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label ID="Label8" AssociatedControlID="Delivery" CssClass="control-label" runat="server" >Delivery: </asp:Label>
            <asp:DropDownList Width="180" CssClass="btn btn btn-default btn-sm" ID="Delivery" runat="server" ></asp:DropDownList>
        </div>               
    </div>
    </div>
    <div class="form-group col-md-4">
        <div class="form-group col-md-10">
            <asp:Label ID="Label2" AssociatedControlID="AdvertDescription" CssClass="col-md-10 control-label" runat="server" >Description: </asp:Label>
            <asp:TextBox Width="300" TextMode="MultiLine" CssClass="col-md-10" Rows="7" ID="AdvertDescription" runat="server"></asp:TextBox>            
        </div>
        <div class="form-group col-md-10">
            <asp:Label runat="server" AssociatedControlID="UploadedImages" CssClass="col-md-10 control-label">Images: </asp:Label>
            <div>
                <asp:FileUpload runat="server" ID="UploadedImages" AllowMultiple="true" CssClass="col-md-12"></asp:FileUpload>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <asp:Button runat="server" OnClick="CreateAdvert_Click" Text="Create" CssClass="btn btn-default" Width="200" />
            <asp:Label runat="server" ID="StatusLabel" Text="" />
        
        </div>
    </div>
</asp:Content>
