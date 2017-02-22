<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvertDetails.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Techrepo.Web.AdvertDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <nav aria-label="whatever">
  <ul class="pager">
    <li class="previous"><a href="/adverts"><span aria-hidden="true">&larr;</span> Back to adverts</a></li>
  </ul>
</nav>
    <asp:FormView runat="server" 
        ID="FormViewAdvertDetails" 
        ItemType="Techrepo.Models.Advert" 
        SelectMethod="FormViewAdvertDetails_GetItem"
        UpdateMethod="UpdateAdvert"
        DataKeyNames="Id">
        <ItemTemplate>
            <h3 style="text-align: center"><%#: Item.Title %></h3>
            <div class="container">
                <div class="row">
                    <div class="col-md-4 control-panel">
                        <asp:Repeater runat="server" DataSource="<%# Item.Photos.TrimEnd(';').Split(';').ToList()%>">
                            <ItemTemplate>
                                <img src="<%# Container.DataItem %>" alt="Techrepo image" height="100" /></img>
                                    <hr />
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <div class="col-md-4 control-panel">
                        <h2>Advert info:</h2>
                        <h3><%#: Item.Description %></h3>
                        <h3><span class="glyphicon glyphicon-piggy-bank"></span> <%#: Item.Price %>лв.</h3>
                        <h3><span class="glyphicon glyphicon-road"></span> <%#: Item.Delivery %></h3>
                        <h3><span class="glyphicon glyphicon-tag"></span> <%#: Item.ProductState %></h3>
                        <h3><span class="glyphicon glyphicon-globe"></span> <%#: Item.City.Name %></h3>
                    </div>
                    <div class="col-md-4 control-panel">
                        <h2>Seller info:</h2>
                        <h3><span class="glyphicon glyphicon-user"></span> <%#: Item.Owner.UserName %></h3>
                        <h3><span class="glyphicon glyphicon-phone"></span> <%#: Item.OwnerPhone %></h3>
                        <h3><span class="glyphicon glyphicon-envelope"></span> <%#: Item.OwnerEmail %></h3>
                    </div>
                </div>
                <div class="col-md-6">
                    <asp:Button runat="server" Text="Edit" CommandName="Edit" CssClass="btn btn-warning" />
                </div> 
            </div>
        </ItemTemplate>
        <EditItemTemplate>
            <h3>Edit Advert</h3>
            <hr />
            
            <asp:Label runat="server" AssociatedControlID="EditTitle" Text="Title :"></asp:Label>
            <asp:TextBox runat="server" ID="EditTitle" Text="<%# BindItem.Title %>" CssClass="form-control"></asp:TextBox>
            <asp:RegularExpressionValidator Display="Dynamic" runat="server" ControlToValidate="EditTitle" 
                    CssClass="text-danger" ValidationExpression="^[\s\S]{3,50}$" Text="Minimum 3 and maximum 50 characters required." />

            <asp:Label runat="server" AssociatedControlID="EditDescription" Text="Description:"></asp:Label>
            <asp:TextBox TextMode="MultiLine" Rows="7" runat="server" ID="EditDescription" Text="<%# BindItem.Description %>" CssClass="form-control"></asp:TextBox>
            <asp:RegularExpressionValidator Display="Dynamic" runat="server" ControlToValidate="EditDescription" 
                    CssClass="text-danger" ValidationExpression="^[\s\S]{3,500}$" Text="Minimum 3 and maximum 500 characters required."  />
           
            <asp:Label runat="server" AssociatedControlID="EditPrice" Text="Price:"></asp:Label>
            <asp:TextBox runat="server" ID="EditPrice" Text="<%# BindItem.Price %>" CssClass="form-control"></asp:TextBox>
            
            <asp:Label runat="server" AssociatedControlID="EditPhone" Text="Phone number:"></asp:Label>
            <asp:TextBox runat="server" ID="EditPhone" Text="<%# BindItem.OwnerPhone %>" CssClass="form-control"></asp:TextBox>
            <asp:RegularExpressionValidator Display="Dynamic" runat="server" ControlToValidate="EditPhone" 
                    CssClass="text-danger" ValidationExpression="^[0-9]{3,15}$" Text="Minimum 3 and maximum 15 characters required." />


            <asp:Label runat="server" AssociatedControlID="EditEmail" Text="Email:"></asp:Label>
            <asp:TextBox runat="server" ID="EditEmail" Text="<%# BindItem.OwnerEmail %>" CssClass="form-control"></asp:TextBox>
            <asp:RegularExpressionValidator Display="Dynamic" runat="server" ControlToValidate="EditEmail" 
                    CssClass="text-danger" 
                ValidationExpression="^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?" 
                Text="Invalid email." />           
            <asp:Button runat="server" Text="Update" CommandName="Update" CssClass="btn btn-primary" />
            <asp:Button runat="server" Text="Cancel" CommandName="Cancel" CssClass="btn btn-danger" />
        </EditItemTemplate>

    </asp:FormView>

</asp:Content>
