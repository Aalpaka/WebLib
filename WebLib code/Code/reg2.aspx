<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="reg2.aspx.cs" Inherits="Assignment3.reg2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="formPlaceHolder" runat="server">

    <div class="container">
        <div class="well-lg">
            <div class="center-block" style="width: 40%;">
                <h2 class="text-center">
                    <asp:Label ID="lbl2" Text="Enter your data" runat="server"></asp:Label>
                </h2>
                <!-- registration form -->
                <asp:TextBox ID="emailReg" MaxLength="40" CssClass="form-control text-center" Placeholder="Enter a valid email" runat="server"></asp:TextBox>

                <asp:TextBox ID="passwordReg" MaxLength="20" CssClass="form-control text-center" Placeholder="Enter a password" TextMode="password" runat="server"></asp:TextBox>
                <asp:TextBox ID="passwordRep" MaxLength="20" CssClass="form-control text-center" Placeholder="Please repeat password" TextMode="password" runat="server"></asp:TextBox>
               
                <asp:Button ID="btnReg" CssClass="btn btn-primary btn-block" Text="Register!" runat="server" OnClick="btnReg_Clic"></asp:Button>
              
                <input id="Reset" type="reset" value="Clear" class="btn btn-danger btn-block" />
                <p>
                    <asp:RequiredFieldValidator ID="RequiredEmail" CssClass="text-danger" ControlToValidate="emailReg" runat="server" ErrorMessage="You must enter an email!"></asp:RequiredFieldValidator></p>
                <p>
                    <asp:RequiredFieldValidator ID="RequiredPassword" CssClass="text-danger" ControlToValidate="passwordReg" runat="server" ErrorMessage="You must enter a password!"></asp:RequiredFieldValidator></p>
                <p>
                    <asp:RequiredFieldValidator ID="RequiredConfirm" CssClass="text-danger" ControlToValidate="passwordRep" runat="server" ErrorMessage="You must confirm your password!"></asp:RequiredFieldValidator></p>
                
                   <p> <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="text-danger" ValidationExpression="^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$" runat="server" ControlToValidate="emailReg" ErrorMessage="Not valid e-mail format"></asp:RegularExpressionValidator></p>
                  <p>  <asp:CompareValidator ID="ComparePass" CssClass="text-danger" ControlToValidate="passwordReg" ControlToCompare="passwordRep" Operator="Equal" runat="server" ErrorMessage="The passwords don't match!"></asp:CompareValidator></p>
                
            </div>
        </div>

    </div>
</asp:Content>
