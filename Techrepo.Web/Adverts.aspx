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
                <asp:Image runat="server" ImageUrl="~/images/tech.png"/> 
                    </a>
                <br />
                <h3><span class=" glyphicon glyphicon-briefcase"></span><%#: Item.Price %>лв.</h3>
                <h3><span class="glyphicon glyphicon-tag"></span><%#: Item.ProductState %></h3>

                
                
                
                <%--<asp:ListView runat="server" ID="RepeaterAdverts" ItemType="Techrepo.Models.Advert" DataSource="<%# Item.Books %>">
                    <LayoutTemplate>
                        <ul>
                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li>
                            <asp:HyperLink NavigateUrl='<%# string.Format("~/bookdetails.aspx?id={0}", Item.Id) %>' runat="server" Text='<%# string.Format(@"""{0}"" by <i>{1}</i>", Item.Title, Item.Author) %>' />
                        </li>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        No books in this category.
                   
                    </EmptyDataTemplate>
                </asp:ListView>--%>
            </div>
        </ItemTemplate>
    </asp:ListView>

    </asp:Content>