<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Techrepo.Web.Administration.City.Create" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div class="form-horizontal">
        <h4>Create a new city</h4>
        <hr />
        
         <div>
            <asp:PlaceHolder runat="server" ID="PlaceHolder1" Visible="false" ViewStateMode="Disabled">
                <%--<p class="text-success"><%: SuccessMessage %></p>--%>
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
    </div>

</asp:Content>
