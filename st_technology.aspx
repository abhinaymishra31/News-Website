<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="st_technology.aspx.cs" Inherits="st_technology" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#666666" BorderWidth="8px" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" GridLines="Vertical" RepeatColumns="3" RepeatDirection="Horizontal" OnItemCommand="DataList1_ItemCommand" OnItemDataBound="DataList1_ItemDataBound" Height="1767px" >
            <FooterStyle BackColor="#8C4510" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="#F7DFB5" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Size="Large" Font-Strikeout="False" Font-Underline="False" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
            <HeaderTemplate>
                Latest News
            </HeaderTemplate>
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label1" runat="server" BackColor="Silver" BorderColor="#FF9900" Font-Bold="True" Font-Size="Large" Font-Underline="True" Text='<%# Eval("news") %>'></asp:Label>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("nid") %>' Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Image ID="Image1" runat="server"  ImageUrl='<%# Eval("photo","~/img/{0}") %>' Width="200px" Height="500px"/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" BackColor="#CCCCCC" Font-Size="Medium" Text='<%# Eval("description") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" >Please login first!</asp:TextBox>
                            
                            <asp:Button ID="Button1" runat="server" BackColor="#7AC1FF" Enabled="False" ForeColor="#333333" Text="COMMENT" CommandName="Comment" />
                           
    
       
                            <asp:Label ID="Label4" runat="server" BackColor="#FFFF66" BorderColor="Red" BorderStyle="Dotted" Text="How you want to rate this news?"></asp:Label>
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="53px" RepeatDirection="Horizontal" Width="110px">
                                <asp:ListItem Selected="True">1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:ImageButton ID="ImageButton1" runat="server" AlternateText="Give feedback" Height="100px" ImageUrl="~/Feedback.png" Width="100px" CommandName="Feedback"/>
                            <asp:ImageButton ID="ImageButton2" runat="server" Height="100px" ImageUrl="~/share.jpg" Width="100px" CommandName="Share" Enabled="False"/>
                            <asp:TextBox ID="TextBox2" runat="server" BackColor="#FF9900" Visible="False">Plz enter e-mail of the recepient</asp:TextBox>
                            <asp:ImageButton ID="ImageButton3" runat="server" Height="50px" ImageUrl="~/share.png" Width="50px" Visible="False" CommandName="Mail"/>
       <br /><br /><br />
                            
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
</asp:Content>

