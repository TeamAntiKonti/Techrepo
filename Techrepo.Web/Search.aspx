<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Techrepo.Web.Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <hr />
    <div class="col-md-12">
        <h1><%: Title %>
            <asp:Literal runat="server" ID="LiteralSearchQuery" Mode="Encode"></asp:Literal></h1>
    </div>

    <nav aria-label="whatever">
      <ul class="pager">
        <li class="previous"><a href="/adverts"><span aria-hidden="true">&larr;</span> Back to adverts</a></li>
      </ul>
    </nav>

    <asp:Repeater runat="server" ID="repeater" ItemType="Techrepo.Models.Advert" SelectMethod="Repeater_GetData">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            <div class="card col-md-4">
                <asp:HyperLink NavigateUrl='<%# string.Format("~/advertdetails.aspx?id={0}", Item.Id) %>' runat="server">
                    <img class="card-img-top" src="<%#:Item.Photos.Split(';')[0] %>" alt="Techrepo advert" height="100">
                </asp:HyperLink>
                <div class="card-block">
                    <h4 class="card-title"><%#: Item.Title %></h4>
                    <p class="card-text">
                        <h3><span class="glyphicon glyphicon-piggy-bank"> <%#: Item.Price %>лв.</span></h3>
                        <h3><span class="glyphicon glyphicon-tag"></span> <%#: Item.ProductState %></h3>

                    </p>
                    <a href="<%# string.Format("/advertdetails.aspx?id={0}", Item.Id) %>" class="btn btn-primary">View Details</a>
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>