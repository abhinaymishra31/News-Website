<%@ Page Language="C#" AutoEventWireup="true" CodeFile="latestnews.aspx.cs" Inherits="latestnews" enableEventValidation="false" %>

<%--<!DOCTYPE html>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
    
        <br />
        <br />
    
    </div>

       <%--***************************************--%>
        
        <div style="margin-left: 240px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="168px" Width="188px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label ID="ID" runat="server" Text='<%# Eval("id")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Image">
                        <ItemTemplate>
                            <asp:Image ID="newimage" runat="server" ImageUrl='<%# Eval("photo","~/img/{0}") %>' Width="100px" Height="100px"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="NEWS">
                        <ItemTemplate>
                            <asp:Label ID="news" runat="server" Text='<%# Eval("news")%>'>
                                </asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="COMMENT">
                        <ItemTemplate>
                            
                            <asp:TextBox ID="txtcomment" runat="server"></asp:TextBox>
                            <asp:Button ID="btnsubmit" runat="server" Text="SUBMIT" onclick="btnsubmit_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="SHARE">
                        <ItemTemplate>
                            <asp:Button ID="btnshare" runat="server" Text="Share" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>



        </div>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;<div style="margin-left: 280px">
        </div>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
