<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="avlbBks.aspx.cs" Inherits="Assignment3.avlbBks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="formPlaceHolder" runat="server">

       <div class="container">
        <div class="well-lg">
            <div class="center-block">
                <!-- table for displaying the books in -->
                <asp:Table ID="booksTable" runat="server"></asp:Table>
            </div>
        </div>
    </div>

</asp:Content>
