<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="err3.aspx.cs" Inherits="Assignment3.err3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="formPlaceHolder" runat="server">

    <div class="container">
        <div class="well-lg">
            <div class="text-center">
                <!-- error if book entry failed -->
                <h1>A book with that title already exists.</h1>
            </div>
        </div>
    </div>

</asp:Content>
