<%@ Page Title="" Language="C#" MasterPageFile="admin.master" AutoEventWireup="true" EnableViewStateMac="false" CodeFile="Editor.aspx.cs" Inherits="Editor" %>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="CONTENT_MENU" runat="server" ContentPlaceHolderID="MENU"></asp:Content>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<form runat="server">--%>
        <div class="center text-danger">
            <label class="col-lg-11">First Name :</label>  
            <div class="col-md-5">
                <asp:TextBox ID="txtfname" runat="server" class="form-control" placeholder="Enter First Name"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RV_fname" runat="server" ErrorMessage="First Name is Required." CssClass="alert-danger" ControlToValidate="txtfname"></asp:RequiredFieldValidator>
            </div>
            <label class="col-lg-11">Last Name :</label>
            <div class="col-md-5">
                <asp:TextBox ID="txtlname" runat="server" class="form-control" placeholder="Enter Last Name"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RV_lname" runat="server" ErrorMessage="Last Name is Required." CssClass="alert-danger" ControlToValidate="txtlname"></asp:RequiredFieldValidator>
            </div>
            <label class="col-lg-11">D . O . B :</label>
            <div class="col-md-5">
                <asp:TextBox ID="txtdob" runat="server" class="form-control" type="date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RV_dob" runat="server" ErrorMessage="DOB is Required." CssClass="alert-danger" ControlToValidate="txtdob"></asp:RequiredFieldValidator>
            </div>
            <label class="col-lg-11">Select Category:</label>
            <div class="col-md-5">
                <asp:DropDownList ID="category" runat="server" class="form-control" OnSelectedIndexChanged="category_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem>Select Category</asp:ListItem>
                    <asp:ListItem>Sport</asp:ListItem>
                    <asp:ListItem>Sci-Tech</asp:ListItem>
                    <asp:ListItem>Books</asp:ListItem>
                    <asp:ListItem>Life Style </asp:ListItem>
                    <asp:ListItem>Entertainment</asp:ListItem>
                    <asp:ListItem>Culture </asp:ListItem>
                    <asp:ListItem>Business</asp:ListItem>
                    <asp:ListItem>Classified</asp:ListItem>
                    <asp:ListItem>Others</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RV_Cat" runat="server" ErrorMessage="Category is Required" CssClass="alert-danger" ControlToValidate="category" InitialValue="Select Category"></asp:RequiredFieldValidator>
            </div>
            <label class="col-lg-11">Select Sub Category:</label>
            <div class="col-md-5">
            <asp:DropDownList ID="subcategory" runat="server" CssClass="form-control" OnSelectedIndexChanged="subcategory_SelectedIndexChanged">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            </div>
            <label class="col-lg-11">Contact No : :</label>
            <div class="col-md-5">
                <asp:TextBox ID="txtc_no" runat="server" class="form-control" placeholder="Enter Contact Number" EnableViewState="False" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RV_txtc_no" runat="server" ErrorMessage="Contact number is Required" CssClass="alert-danger" ControlToValidate="txtc_no"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_cno" runat="server" ErrorMessage="ContactNo must be 10 digits" ValidationExpression="[0-9]{10}" ControlToValidate="txtc_no"></asp:RegularExpressionValidator>
            </div>
            <label class="col-lg-11">Email ID :</label>
            <div class="col-md-5">
                <asp:TextBox ID="txteid" runat="server" class="form-control" placeholder="Enter Email ID"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RV_txteid" runat="server" ErrorMessage="Email-ID is required" CssClass="alert-danger" ControlToValidate="txteid"></asp:RequiredFieldValidator>
                <%--<asp:RegularExpressionValidator ID="CV_eid" runat="server" ErrorMessage="Email form must be sample@gmail.com" CssClass="alert-danger" ValidationExpression="" ControlToValidate="txteid"></asp:RegularExpressionValidator>--%>
            </div>
            <label class="col-lg-11">Adhar Carn Number :</label>
            <div class="col-md-5">
                <asp:TextBox ID="txtadhar" runat="server" class="form-control" placeholder="Enter the Adhar Card Number" MaxLength="12"></asp:TextBox>
                <asp:RequiredFieldValidator ID="VC_adhar" runat="server" ErrorMessage="adhar is Required" CssClass="alert-danger" ControlToValidate="txtadhar"></asp:RequiredFieldValidator>
            </div>
            <label class="col-lg-11" id="lblexpi">Are You Experienced ? </label>
                <div class="col-md-5">
                    <asp:RadioButtonList ID="IsExperienced" class="col-lg-11" runat="server" AutoPostBack="True" OnSelectedIndexChanged="IsExperienced_SelectedIndexChanged">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
           <label id="lblhow" class="col-lg-11" runat="server" visible="false">How many years ?</label>
            <div class="col-md-5">
                <asp:TextBox ID="txthow" runat="server" class="form-control" placeholder="Enter Experienced years" OnTextChanged="txthow_TextChanged" Visible="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="CV_how" runat="server" ErrorMessage="input is Required" CssClass="alert-danger" ControlToValidate="txthow"></asp:RequiredFieldValidator>
            </div>
            <label id="lblfrom" class="col-lg-11" runat="server" visible="false">From which company ?</label>
            <div class="col-md-5">
                <asp:TextBox ID="txtfrom" runat="server" class="form-control" placeholder="Enter Company Name" Visible="false"></asp:TextBox>
                <asp:RequiredFieldValidator ID="CV_from" runat="server" ErrorMessage="Company Name Required" CssClass="alert-danger" ControlToValidate="txtfrom"></asp:RequiredFieldValidator>
            </div>
                <label class="col-lg-11">Password :</label>
                <div class="col-md-5">
                    <asp:TextBox ID="txtpass" runat="server" class="form-control" placeholder="Enter Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="CV_pass" runat="server" ErrorMessage="Password is Required" CssClass="alert-danger" ControlToValidate="txtpass"></asp:RequiredFieldValidator>
                </div>
                <label class="col-lg-11">Confirm Password :</label>
                <div class="col-md-5">
                    <asp:TextBox ID="txtcompass" runat="server" class="form-control" placeholder="Re-enter Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="CV_compass" runat="server" ErrorMessage="Password not matched" CssClass="alert-danger" ControlToValidate="txtcompass"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="Compare_comass" runat="server" ErrorMessage="password not matched with the password" CssClass="alert-danger" ControlToCompare="txtpass" ControlToValidate="txtcompass"></asp:CompareValidator>
                </div>
                <label class="col-lg-11">Upload Photo :</label>
                <div class="col-md-5">
                    <asp:FileUpload ID="PhotoUpload" runat="server" class="form-control" />
                    <asp:RequiredFieldValidator ID="CV_photoyupload" runat="server" ErrorMessage="Upload a photo" CssClass="alert-danger" ControlToValidate="PhotoUpload"></asp:RequiredFieldValidator>
                </div>
                <label class="col-lg-11">Upload Signature :</label>
                <div class="col-md-5">
                    <asp:FileUpload ID="SignUpload" runat="server" class="form-control" />
                    <asp:RequiredFieldValidator ID="CV_signupload" runat="server" ErrorMessage="Select Signature" CssClass="alert-danger" ControlToValidate="SignUpload"></asp:RequiredFieldValidator>
                </div>
                <div class="col-lg-11" style="margin-top:20px">
                    <asp:Button ID="btnregi" runat="server" class="btn btn-large btn-success" Height="40px" Width="180px" Text="Register" OnClick="btnregi_Click" />
                    <asp:Button ID="btnreset" runat="server" class="btn btn-large btn-success" Height="40px" Width="180px" Text="Reset" OnClick="btnreset_Click" />

                </div>
            </div>
    <%--</form>--%>
</asp:Content>