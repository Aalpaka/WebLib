<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="allBks.aspx.cs" Inherits="Assignment3.allBks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="formPlaceHolder" runat="server">

    <div class="container">
        <div class="well-lg">
            <div class="center-block">
                <!-- table for the books to be displayed in -->
                <asp:Table ID="booksTable" runat="server"></asp:Table>
            </div>
        </div>
    </div>

</asp:Content>
