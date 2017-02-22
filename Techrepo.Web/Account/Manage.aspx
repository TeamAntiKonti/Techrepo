<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="Techrepo.Web.Account.Manage" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
        <asp:FormView runat="server" ID="UserForm"
        SelectMethod="GetUserInfo"       
        UpdateMethod="UpdateUserProfile"
        ItemType="Techrepo.Models.User"            
        DataKeyNames="Id">
        <ItemTemplate>
            <h3>Profile Information</h3>
            <hr />
            <div class="col-md-6">
                <label >Full name: </label>
                <strong><asp:Label Text="<%#:Item.FirstName %>" runat="server" /></strong>
                <strong><asp:Label Text="<%#:Item.LastName %>" runat="server" /></strong>
            </div>
            <div class="col-md-10">
                <label >Username: </label>
                <strong><asp:Label  Text="<%#:Item.UserName %>" runat="server" /></strong>

            </div>
            <div class="col-md-6">
                <label>Email: </label>
                <strong><asp:Label Text="<%#:Item.Email %>" runat="server" /></strong>
            </div>
            
            <div class="col-md-10">
                <asp:Image Width="200" Height="200" CssClass="img-responsive control-label" ImageUrl="<%# Item.AvatartPath %>" runat="server" />
            </div>  
            <div class="col-md-6">
                <asp:Button runat="server" Text="Edit" CommandName="Edit" CssClass="btn btn-warning" />
            </div> 
        </ItemTemplate>
        <EditItemTemplate>
            <h3>Edit Profile</h3>
            <hr />
            <asp:Label runat="server" AssociatedControlID="EditFirstName" Text="First name:"></asp:Label>
            <asp:TextBox runat="server" ID="EditFirstName" Text="<%# BindItem.FirstName %>" CssClass="form-control"></asp:TextBox>
            <asp:RegularExpressionValidator Display="Dynamic" runat="server" ControlToValidate="EditFirstName" 
                    CssClass="text-danger" ValidationExpression="^[\s\S]{3,30}$" Text="Minimum 3 and maximum 20 characters required." />

            <asp:Label runat="server" AssociatedControlID="EditLastName" Text="Last name:"></asp:Label>
            <asp:TextBox runat="server" ID="EditLastName" Text="<%# BindItem.LastName %>" CssClass="form-control"></asp:TextBox>
            <asp:RegularExpressionValidator Display="Dynamic" runat="server" ControlToValidate="EditLastName" 
                    CssClass="text-danger" ValidationExpression="^[\s\S]{3,30}$" Text="Minimum 3 and maximum 500 characters required."  />
           
            <asp:Label runat="server" AssociatedControlID="EditUsername" Text="Username:"></asp:Label>
            <asp:TextBox runat="server" ID="EditUsername" Text="<%# BindItem.UserName %>" CssClass="form-control"></asp:TextBox>
            <asp:RegularExpressionValidator Display="Dynamic" runat="server" ControlToValidate="EditUsername" 
                    CssClass="text-danger" ValidationExpression="^[\s\S]{3,20}$" Text="Minimum 3 and maximum 500 characters required."  />
           
            <dl class="col-md-2 control-label">
                <dt>Password:</dt>
                <dd>
                    <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Change]" Visible="true" ID="ChangePassword" runat="server" />
                </dd>                                       
            </dl>

            <div>
                <asp:FileUpload CssClass="control-label" runat="server" ID="Avatar"></asp:FileUpload>
            </div>
            <p class="text-danger">
                <asp:Literal runat="server" ID="ErrorMessage" />
            </p>

            <asp:Button runat="server" Text="Update" CommandName="Update" CssClass="btn btn-primary" />
            <asp:Button runat="server" Text="Cancel" CommandName="Cancel" CssClass="btn btn-danger" />
        </EditItemTemplate>
        
    </asp:FormView>

</asp:Content>
