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
                
                            <asp:HyperLink NavigateUrl='<%# string.Format("~/advertdetails.aspx?id={0}", Item.Id) %>' runat="server">
                                
                       
                    <h1><%#: Item.Title %></h1>
                                
                    <!-- Yeah i know-->
                   
                                <p><%#:Item.Photos.Split(';')[0] %></p>
                                <img src="<%#:Item.Photos.Split(';')[0] %>" height="100" alt="Techrepo advert"/>

                    </asp:HyperLink>
                                </a>
                <br />
                <h3><span class="glyphicon glyphicon-piggy-bank"> <%#: Item.Price %>лв.</span></h3>
                <h3><span class="glyphicon glyphicon-tag"></span> <%#: Item.ProductState %></h3>
                
            </div>
        </ItemTemplate>
    </asp:ListView>

    </asp:Content>