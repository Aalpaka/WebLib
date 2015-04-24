<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Assignment3._login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <div class="container">
        <div class="well-lg">
            <div class="center-block" style="width: 200px;">
                <!-- login form -->
                <h2>
                    <asp:Label ID="lbl1" Text="Please sign in" runat="server"></asp:Label>
                </h2>
                <asp:TextBox ID="userName" CssClass="form-control text-center" Placeholder="Enter email" TextMode="email" runat="server"></asp:TextBox>

                <asp:TextBox ID="password" CssClass="form-control text-center" Placeholder="Enter password" TextMode="password" runat="server"></asp:TextBox>

                <asp:Button ID="btnSgnIn" CssClass="btn btn-primary btn-block" Text="Sign in!" runat="server" OnClick="btnSgnIn_Click"></asp:Button>
            </div>
        </div>

    </div>
</asp:Content>
