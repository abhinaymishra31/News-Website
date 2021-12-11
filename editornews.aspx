<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="editornews.aspx.cs" Inherits="editornews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="center text-danger">
        <div class="col-md-5">
           <label class="col-lg-11">CATEGORY</label>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="40px" Width="550px">

                <asp:ListItem>Select Category</asp:ListItem>
                <asp:ListItem>world news</asp:ListItem>
                <asp:ListItem>sports</asp:ListItem>
                <asp:ListItem>entertainment</asp:ListItem>
                <asp:ListItem>tech</asp:ListItem>
                <asp:ListItem>state</asp:ListItem>
                <asp:ListItem>books</asp:ListItem>
            </asp:DropDownList>
        </div>
        <label class="col-lg-11">NEWS</label>
        <div class="col-md-5">
            <asp:TextBox ID="txtnews" runat="server" TextMode="MultiLine" Width="800px"></asp:TextBox>
        </div>
        <label class="col-lg-11">FEEDBACK</label>
        <div class="col-md-5">
            <asp:TextBox ID="txtfeed" runat="server" MaxLength="1" Width="800px"></asp:TextBox>
        </div>
        <label class="col-lg-11">IMAGE</label>
        <div class="col-md-5">
            <asp:FileUpload ID="FileUpload1" runat="server" Width="800px" />
        </div>
        <label class="col-lg-11">COMMENT</label>
        <div class="col-md-5">
            <asp:TextBox ID="txtcomment" runat="server" TextMode="MultiLine" Width="800px"></asp:TextBox>
        </div>
        <label class="col-lg-11">DESCRIPTION</label>
        <div class="col-md-5">
            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="800px"></asp:TextBox>
        </div>
    </div>
</asp:Content>

