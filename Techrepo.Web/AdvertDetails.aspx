<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvertDetails.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Techrepo.Web.AdvertDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="back-link">
        <a href="/adverts">Back to adverts</a>
    </div>

    <asp:FormView runat="server" ID="FormViewAdvertDetails" ItemType="Techrepo.Models.Advert" SelectMethod="FormViewAdvertDetails_GetItem">
        <ItemTemplate>
            
                <h3 ><%#: Item.Title %></h3>
                <div class="container">
                    <div class="row" >



                        <div class="col">
                            <asp:Repeater runat="server" DataSource="<%# Item.Photos.TrimEnd(';').Split(';').ToList()%>">
                                <ItemTemplate>
                                    <img src="<%# Container.DataItem %>" alt="Techrepo image" height="75" /></img>
                                    <br />
                                   

                                </ItemTemplate>
                               
                            </asp:Repeater>
                        </div>
                        <div class="col">
                            <h2 class="advert-title"><%#: Item.Description %></h2>
                            <h2 class="advert-title"><%#: Item.Price %>лв.</h2>
                            <h2><%#: Item.Delivery %></h2>
                            <h2><%#: Item.ProductState %></h2>
                            <h2><%#: Item.OwnerPhone %></h2>
                            <h2><%#: Item.OwnerEmail %></h2>
                            <h2><%#: Item.Owner.UserName %></h2>
                        </div>

                    </div>
                </div>
            
            
        </ItemTemplate>
    </asp:FormView>




</asp:Content>
