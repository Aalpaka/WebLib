<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="err2.aspx.cs" Inherits="Assignment3.err2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="formPlaceHolder" runat="server">


    <div class="container">
        <div class="well-lg">
            <div class="center-block">
                <!-- error if login failed -->
                <h1 class="text-center">Sorry, your username or password are wrong. Please <a href="login.aspx">try again</a>, or <a href="reg2.aspx"> register here</a>.</h1>
            </div>
        </div>
    </div>
</asp:Content>
