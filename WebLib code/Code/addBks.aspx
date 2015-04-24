<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addBks.aspx.cs" Inherits="Assignment3.addBks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="formPlaceHolder" runat="server">

    <div class="container">
        <div class="well-lg">
            <div class="center-block" style="width: 40%;">
                <h2 class="text-center">
                    <asp:Label ID="lbl3" Text="Enter the book data" runat="server"></asp:Label>
                </h2>
                <!-- Form for entering book information -->
                <asp:TextBox ID="Ttl" CssClass="form-control text-center" MaxLength="50" Placeholder="Enter the title of the book" runat="server"></asp:TextBox>

                <asp:TextBox ID="Auth" CssClass="form-control text-center" MaxLength="30" Placeholder="Enter the author" runat="server"></asp:TextBox>
                <asp:TextBox ID="ISBN" CssClass="form-control text-center" MaxLength="13" Placeholder="Enter book ISBN (without dashes)" runat="server"></asp:TextBox>
               <asp:DropDownList ID="cat" CssClass="form-control text-center" runat="server"/>
                <asp:Button ID="btnAdd" CssClass="btn btn-primary btn-block" Text="Add!" runat="server" OnClick="btnAdd_Click"></asp:Button>
              
                <input id="Reset" type="reset" value="Clear" class="btn btn-danger btn-block" />
                <p>
                    <asp:RequiredFieldValidator ID="ReqTitle" CssClass="text-danger" ControlToValidate="Ttl" runat="server" ErrorMessage="You must enter a book title!"></asp:RequiredFieldValidator></p>
                <p>
                    <asp:RequiredFieldValidator ID="ReqAuth" CssClass="text-danger" ControlToValidate="Auth" runat="server" ErrorMessage="You must enter an author!"></asp:RequiredFieldValidator></p>
                <p>
                    <asp:RequiredFieldValidator ID="ReqISBN" CssClass="text-danger" ControlToValidate="ISBN" runat="server" ErrorMessage="You enter an ISBN!"></asp:RequiredFieldValidator></p>
                <p>
                    <asp:RegularExpressionValidator ID="RegExVal" CssClass="text-danger" runat="server" ErrorMessage="Invalid ISBN format!" ControlToValidate="ISBN" ValidationExpression="^(97(8|9))?\d{9}(\d|X)$"></asp:RegularExpressionValidator>
                </p>
                 <!-- --------------------------- End of form ------------------------------------------- -->   
            </div>
        </div>

    </div>

</asp:Content>
