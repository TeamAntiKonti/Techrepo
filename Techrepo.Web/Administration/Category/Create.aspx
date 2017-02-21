<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Techrepo.Web.Administration.Category.Create" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView ID="ListView1" runat="server" 
        ItemType="Techrepo.Models.AdvertCategory"
        SelectMethod="ListView1_GetData" 
        InsertMethod="ListView1_InsertItem"
        DeleteMethod="ListView1_DeleteItem" 
        UpdateMethod="ListView1_UpdateItem" 
        InsertItemPosition="LastItem"
        DataKeyNames="Id">
        <LayoutTemplate>
            <table class="gridview" cellspacing="0" rules="all" border="1" id="MainContent_GridViewCategories" style="border-collapse: collapse;">
                <tbody>
                    <tr>
                        <th scope="col">
                            <asp:LinkButton Text="Category Name" runat="server" ID="LinkButtonSortByCategoryName" CommandName="Sort" CommandArgument="Name" />
                        </th>
                        <th scope="col">Action</th>
                    </tr>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                    <tr>
                        <td colspan="2">
                            <asp:DataPager runat="server" ID="DataPagerCategories" PageSize="5">
                                <Fields>
                                    <asp:NumericPagerField />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </tbody>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%#: Item.Name %></td>
                <td>
                    <asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Edit" CommandName="Edit" />
                    <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Delete" CommandName="Delete" />
                </td>
            </tr>
        </ItemTemplate>
        <EditItemTemplate>
            <tr>
                <td>
                    <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Name %>" />
                </td>
                <td>
                    <asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Save" CommandName="Update" />
                    <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Cancel" CommandName="Cancel" />
                </td>
            </tr>
        </EditItemTemplate>
        <InsertItemTemplate>
            <tr>
                <td>
                    <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Name %>" />
                </td>
                <td>
                    <asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Insert" CommandName="Insert" />
                    <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Cancel" CommandName="Cancel" />
                </td>
            </tr>
        </InsertItemTemplate>
    </asp:ListView>
</asp:Content>

