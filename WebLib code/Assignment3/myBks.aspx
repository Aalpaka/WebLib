<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="myBks.aspx.cs" Inherits="Assignment3.myBks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="formPlaceHolder" runat="server">

    <div class="container">
        <div class="well-lg">
            <div class="center-block">
                <asp:Table ID="booksTable" runat="server"></asp:Table>
            </div>
        </div>
    </div>

</asp:Content>
