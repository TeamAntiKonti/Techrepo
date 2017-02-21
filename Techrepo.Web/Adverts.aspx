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
                    <asp:Button runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="Del" Text="Delete" OnCommand="Delete_Click" CssClass="btn btn-danger"/>
                </div>
            </div>


            <!-- ************************** -->
            <%-- <div class="col-md-4">

                <asp:HyperLink NavigateUrl='<%# string.Format("~/advertdetails.aspx?id={0}", Item.Id) %>' runat="server">
                               <h1><%#: Item.Title %></h1>
                                  
                                <img src="<%#:Item.Photos.Split(';')[0] %>" height="100" alt="Techrepo advert"/>
                </asp:HyperLink>
                <br />
                <h3><span class="glyphicon glyphicon-piggy-bank"> <%#: Item.Price %>лв.</span></h3>
                <h3><span class="glyphicon glyphicon-tag"></span> <%#: Item.ProductState %></h3>


            </div>--%>
        </ItemTemplate>
        <GroupSeparatorTemplate>
            <hr />
        </GroupSeparatorTemplate>
    </asp:ListView>

</asp:Content>
