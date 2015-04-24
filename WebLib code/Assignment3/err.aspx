<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="err.aspx.cs" Inherits="Assignment3.err" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="formPlaceHolder" runat="server">

    <div class="container">
        <div class="well-lg">
            <div class="center-block">
                <!-- error if registration failed -->
                <h1>Unfortunately, an user with that email already exists. Plese <a href="reg2.aspx">try again</a>.</h1>
            </div>
        </div>
    </div>

</asp:Content>
