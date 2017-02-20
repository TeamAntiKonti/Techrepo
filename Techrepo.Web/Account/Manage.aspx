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
                
                <div class="form-group">
                    <div class="col-md-3">

                        <asp:Image Width="200" Height="200" CssClass="img-responsive control-label" ImageUrl="<%# this.AvatarUrl %>" runat="server" />
                    
                        <asp:Label runat="server" AssociatedControlID="Avatar" CssClass="control-label">Avatar</asp:Label>                    
                        <div>
                            <asp:FileUpload CssClass="control-label" runat="server" ID="Avatar"></asp:FileUpload>
                        </div>
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="ErrorMessage" />
                        </p>
                    </div>
                    <div class="col-md-3">
                        <asp:Label runat="server" AssociatedControlID="FirstName" CssClass="control-label">First name</asp:Label>
                        <div>
                            <asp:TextBox runat="server" ID="FirstName" CssClass="form-control"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="FIrstName"
                                CssClass="text-danger" ErrorMessage="The first name field is required." />
                        </div>
                        <asp:Label runat="server" AssociatedControlID="LastName" CssClass="control-label">Last name</asp:Label>
                        <div>
                            <asp:TextBox runat="server" ID="LastName" CssClass="form-control"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="LastName"
                                CssClass="text-danger" ErrorMessage="The last name field is required." />
                        </div>

                        <dl class="col-md-2 control-label">
                            <dt>Password:</dt>
                            <dd>
                                <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Change]" Visible="false" ID="ChangePassword" runat="server" />
                                <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Create]" Visible="false" ID="CreatePassword" runat="server" />
                            </dd>                                       
                        </dl>
                    </div>
                </div>
                
                
                <asp:Button CssClass="btn btn-success pull-left" Width="150" Text="Update" runat="server" OnClick="UpdateUserProfile" />
            </div>
        </div>
    </div>

</asp:Content>
