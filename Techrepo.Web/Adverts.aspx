<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adverts.aspx.cs" Inherits="Techrepo.Web.Adverts" MasterPageFile="~/Site.Master" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <asp:ListView runat="server"
        ID="ListViewAdverts"
        ItemType="Techrepo.Models.Advert"
        SelectMethod="ListViewAdverts_GetData"
        GroupItemCount="3">
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>

        <ItemTemplate>
            <div class="col-md-4">
                <a href=""><h1><%#: Item.Title %></h1>
                    <!-- Yeah i know-->
                    <img src="<%#:Item.Photos.Split(';')[0].Substring(Item.Photos.Split(';')[0].IndexOf("images")) %>" height="100"/>
                    </a>
                <br />
                <h3><span class="glyphicon glyphicon-piggy-bank"> <%#: Item.Price %>лв.</span></h3>
                <h3><span class="glyphicon glyphicon-tag"></span> <%#: Item.ProductState %></h3>
                
            </div>
        </ItemTemplate>
    </asp:ListView>

    </asp:Content>