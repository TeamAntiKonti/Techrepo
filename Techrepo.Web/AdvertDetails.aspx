<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvertDetails.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Techrepo.Web.AdvertDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:FormView runat="server" ID="FormViewAdvertDetails" ItemType="Techrepo.Models.Advert" SelectMethod="FormViewAdvertDetails_GetItem">
        <ItemTemplate>
            <header>
                <h1><%: Title %></h1>
                <p class="advert-title"><%#: Item.Title %></p>
                <%--<p class="advert-author"><i>by <%#: Item.Author %></i></p>
                <p class="advert-isbn"><i>ISBN <%#: Item.ISBN %></i></p>
                <p class="advert-isbn">
                    <i>Web site: 
                    <a href="<%#: Item.WebSite %>"><%#: Item.WebSite %></a></i>--%>
                </p>
            </header>
            <div class="row-fluid">
                <div class="span12 book-description">
                    <p><%#: Item.Description %></p>
                </div>
            </div>
        </ItemTemplate>
    </asp:FormView>

    <div class="back-link">
        <a href="/adverts">Back to adverts</a>
    </div>
</asp:Content>
