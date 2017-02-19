<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Techrepo.Web.Administration.Category.Create" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <h4>Create a new category</h4>
        <hr />

        <div>
            <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
                <p class="text-success"><%: SuccessMessage %></p>
            </asp:PlaceHolder>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="CategoryName" CssClass="col-md-2 control-label">Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="CategoryName" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="CategoryName"
                    CssClass="text-danger" ErrorMessage="The name field is required." />
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateCategory_Click" Text="Create" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>

