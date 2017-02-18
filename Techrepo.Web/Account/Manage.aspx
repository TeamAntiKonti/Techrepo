<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="Techrepo.Web.Account.Manage" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    
    <div>
        <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
            <p class="text-success"><%: SuccessMessage %></p>
        </asp:PlaceHolder>
    </div>
        
    <div class="row">
        <div class="col-md-12">
            <div class="form-horizontal">
                <h4>Change your account settings</h4>
                <hr />
                
                <img class="col-md-3" src="<%# this.defaultAvatar%>" alt="<%#: this.defaultAvatar%>" />
                    

                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Avatar" CssClass="col-md-2 control-label">Avatar</asp:Label>
                    <div class="col-md-3">
                        <asp:FileUpload runat="server" ID="Avatar" CssClass="form-control"></asp:FileUpload>
                    </div>
                </div>
                <p class="text-danger">
                    <asp:Literal runat="server" ID="ErrorMessage" />
                </p>
                <dl class="dl-horizontal">
                    <dt>Password:</dt>
                    <dd>
                        <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Change]" Visible="false" ID="ChangePassword" runat="server" />
                        <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Create]" Visible="false" ID="CreatePassword" runat="server" />
                    </dd>                   
                    
                </dl>
                <asp:Button Text="Save" runat="server" OnClick="UpdateUserProfile" />
            </div>
        </div>
    </div>

</asp:Content>
