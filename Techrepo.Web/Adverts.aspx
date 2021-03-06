﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adverts.aspx.cs" Inherits="Techrepo.Web.Adverts" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">    
    <hr />    
    <div class="search-button">
        <div class="form-search">
            <div class="input-append">
                <asp:TextBox runat="server" ID="TextBoxSearchParam" type="text" name="q" CssClass="col-md-3 search-query" placeholder="Search by advert title or description"></asp:TextBox>
                <asp:LinkButton runat="server" ID="LinkButtonSearch"
                    OnClick="LinkButtonSearch_Click" CssClass="btn  btn-primary" Text="Search"></asp:LinkButton>
            </div>
        </div>
    </div>
   <hr />

    <asp:ListView runat="server"
        ID="ListViewAdverts"
        ItemType="Techrepo.Models.Advert"
        SelectMethod="ListViewAdverts_GetData"
        OnItemDataBound="ListView_ItemDataBound"
        GroupItemCount="3">
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>

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
                    <asp:Button runat="server" ID="BtnDel" CommandArgument='<%# Eval("Id") %>' CommandName="Del" Text="Delete" OnCommand="Delete_Click" CssClass="hidden"/>
                </div>
            </div>
        </ItemTemplate>
        <GroupSeparatorTemplate>
            <hr />
        </GroupSeparatorTemplate>
    </asp:ListView>

</asp:Content>
