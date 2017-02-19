<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="Techrepo.Web.AdminPanel" %>

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
                <asp:TextBox runat="server" ID="CategoryName" CssClass="form-control"/>
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

   <%-- <div class="form-horizontal">
        <h4>Create a new city</h4>
        <hr />
        
         <div>
            <asp:PlaceHolder runat="server" ID="PlaceHolder1" Visible="false" ViewStateMode="Disabled">
                <p class="text-success"><%: SuccessMessage %></p>
            </asp:PlaceHolder>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="CityName" CssClass="col-md-2 control-label">Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="CityName" CssClass="form-control"/>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="CityName"
                    CssClass="text-danger" ErrorMessage="The name field is required." />
            </div>
        </div>
        
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateCity_Click" Text="Create" CssClass="btn btn-default" />
            </div>
        </div>
    </div>--%>

</asp:Content>