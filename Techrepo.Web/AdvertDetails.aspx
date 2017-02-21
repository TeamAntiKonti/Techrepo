<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvertDetails.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Techrepo.Web.AdvertDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="back-link">
        <a href="/adverts">Back to adverts</a>
    </div>

    <asp:FormView runat="server" ID="FormViewAdvertDetails" ItemType="Techrepo.Models.Advert" SelectMethod="FormViewAdvertDetails_GetItem">

        <ItemTemplate>

            <h3 style="text-align: center"><%#: Item.Title %></h3>

            <div class="container">
                <div class="row">


                    <div class="col-md-4">
                        <asp:Repeater runat="server" DataSource="<%# Item.Photos.TrimEnd(';').Split(';').ToList()%>">
                            <ItemTemplate>

                                <img src="<%# Container.DataItem %>" alt="Techrepo image" height="100" /></img>
                                    <hr />


                            </ItemTemplate>

                        </asp:Repeater>
                    </div>

                    <div class="col-md-4">
                        <h2>Advert info:</h2>
                        <h3><%#: Item.Description %></h3>
                        <h3><span class="glyphicon glyphicon-piggy-bank"></span> <%#: Item.Price %>лв.</h3>
                        <h3><span class="glyphicon glyphicon-road"></span> <%#: Item.Delivery %></h3>
                        <h3><span class="glyphicon glyphicon-tag"></span> <%#: Item.ProductState %></h3>
                        <h3><span class="glyphicon glyphicon-globe"></span> <%#: Item.City.Name %></h3>

                    </div>

                    <div class="col-md-4">
                        <h2>Seller info:</h2>
                        <h3><span class="glyphicon glyphicon-user"></span> <%#: Item.Owner.UserName %></h3>
                        <h3><span class="glyphicon glyphicon-phone"></span> <%#: Item.OwnerPhone %></h3>
                        <h3><span class="glyphicon glyphicon-envelope"></span> <%#: Item.OwnerEmail %></h3>

                    </div>


                </div>
            </div>

        </ItemTemplate>

    </asp:FormView>

</asp:Content>
