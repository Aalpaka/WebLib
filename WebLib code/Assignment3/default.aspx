<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Assignment3._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="well-lg">
                    <!-- home page, with bootstrap grid elements and some description text -->
                    <h1>Hello, dear readers! <span class="glyphicon glyphicon-bullhorn"/></h1>
                    <p>Welcome to the brand new, revolutionary WebLib online library. If you are already an user, please log in. If not, register! It will take you only 23 seconds, it is completely free and you will be able to borrow books!</p>
                    
                </div>
            </div>
        </div>


        <!-- Example row of columns -->
        <div class="row">
            <div class="col-md-4">
                <h2>Books <span class="glyphicon glyphicon-book"/></h2>
                <p>By clicking on the button below you can see all the books we currently have. You can do the same by clicking in the dropdown menu! </p>
                <p>
                   <a href="allBks.aspx"> <span class="btn btn-primary">Check it out!</span></a>
                </p>
            </div>
            <div class="col-md-4">
                <h2>Available books <span class="glyphicon glyphicon-ok"/></h2>
                <p>If you still dont know if you want to register, here you can see which books could be yours with just one click!</p>
                <p>
                    <a href="avlbBks.aspx"> <span class="btn btn-primary">Check it out!</span></a>
                </p>
            </div>
            <div class="col-md-4">
                <h2>Borrowed books <span class="glyphicon glyphicon-remove"/></h2>
                <p>Unfortunately, these are currently not available, but we are sure that they will be returned in no time!</p>
                <p>
                    
                    <a href="brwBks.aspx"> <span class="btn btn-primary">Check it out!</span></a>
                </p>
            </div>

        </div>
    </div>
    <hr />
</asp:Content>
