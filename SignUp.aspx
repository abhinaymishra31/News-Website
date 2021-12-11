<%@ Page Title="" Language="C#" MasterPageFile="admin.master" enableEventValidation="false" AutoEventWireup="true" EnableViewStateMac="false" CodeFile="SignUp.aspx.cs" Inherits="_Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<form  id="form1" runat="server">--%>
        <div class="center text-danger">
            <label class="col-lg-11">First Name :</label>
            <div class="col-md-5">
                <asp:TextBox ID="txtfname" runat="server" class="form-control" placeholder="Enter First Name"></asp:TextBox>
            </div>
            <label class="col-lg-11">Last Name :</label>
            <div class="col-md-5">
                <asp:TextBox ID="txtlname" runat="server" class="form-control" placeholder="Enter First Name"></asp:TextBox>
            </div>
            <label class="col-lg-11">D . O . B :</label>
            <div class="col-md-5">
                <asp:TextBox ID="txtdob" runat="server" class="form-control" placeholder="dd/mm/yyyy"></asp:TextBox>
            </div>
            <label class="col-lg-11">Email ID :</label>
            <div class="col-md-5">
                <asp:TextBox ID="txtemail" runat="server" class="form-control" placeholder="Enter Email ID"></asp:TextBox>
            </div>
            <label class="col-lg-11">Contact No :</label>
            <div class="col-md-5">
                <asp:TextBox ID="txtmob" runat="server" class="form-control" placeholder="Enter Contact Number"></asp:TextBox>
            </div>
            <label class="col-lg-11">Upload Photo :</label>
            <div class="col-md-5">
                <asp:FileUpload ID="PhotoUpload" runat="server" class="form-control" />
            </div>
            <label class="col-lg-11">Select Cuntory :</label>
            <div class="col-md-5">
                <asp:DropDownList ID="country" runat="server" class="form-control">
                    <asp:ListItem>India</asp:ListItem>
                </asp:DropDownList>
            </div>
            <label class="col-lg-11">State :</label>
            <div class="col-md-5">
                <asp:DropDownList ID="state" runat="server" class="form-control">
                    <asp:ListItem>JAMMU &amp; KASHMIR</asp:ListItem>
                    <asp:ListItem>HARYANA</asp:ListItem>
                    <asp:ListItem>ANDHRA PRADESH</asp:ListItem>
                    <asp:ListItem>ARUNACHAL PRADESH</asp:ListItem>
                    <asp:ListItem>ASSAM</asp:ListItem>
                    <asp:ListItem>BIHAR</asp:ListItem>
                    <asp:ListItem>CHHATISGARH</asp:ListItem>
                    <asp:ListItem>GOA</asp:ListItem>
                    <asp:ListItem>GUJRAT</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </div>
            <label class="col-lg-11">Pincode :</label>
            <div class="col-md-5">
                <asp:TextBox ID="txtpin" runat="server" class="form-control" placeholder="Enter the pincode" MaxLength="6"></asp:TextBox>
            </div>
            <label class="col-lg-11">Password :</label>
            <div class="col-md-5">
                <asp:TextBox ID="txtpassword" runat="server" class="form-control" placeholder="Enter Password"></asp:TextBox>
            </div>
            <label class="col-xs-11">Confirm Password :</label>
            <div class="col-md-5">
                <asp:TextBox ID="txtconpassword" runat="server" class="form-control" placeholder="Enter Contact Number"></asp:TextBox>
            </div>
            <div class="col-lg-11" style="margin-top: 20px">
                <asp:Button ID="btnsignup" runat="server" class="btn btn-success" Height="40px" Width="180px" Text="Submit" OnClick="btnsignup_Click1" />
                <asp:Button ID="btnreset" runat="server" class="btn btn-success" Height="40px" Width="180px" Text="Reset" />
            </div>
        </div>
    <%--</form>--%>
</asp:Content>

