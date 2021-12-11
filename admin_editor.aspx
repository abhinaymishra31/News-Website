<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_editor.aspx.cs" Inherits="admin_editor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="center text-danger">
        <div class="col-lg-11 center" style="margin-top: 20px">
                <div class="col-lg-11 center" style="margin-bottom: 20px">
                <asp:Button ID="btnadd" runat="server" class="btn btn-large btn-success" Height="40px" Width="180px" Text="ADD" OnClick="btnadd_Click" />
                <asp:Button ID="btndelete" runat="server" class="btn btn-large btn-success" Height="40px" Width="180px" Text="DELETE" OnClick="btndelete_Click" />
                <asp:Button ID="btnupdate" runat="server" class="btn btn-large btn-success" Height="40px" Width="180px" Text="UPDATE" OnClick="btnupdate_Click" />
                <asp:Button ID="btnblock" runat="server" class="btn btn-large btn-success" Height="40px" Width="180px" Text="BLOCK" OnClick="btnblock_Click"/>
                <div class="col-md-5">
                    <asp:DropDownList ID="DropDownList1" runat="server" Visible="False">
                        <asp:ListItem>Select Criteria</asp:ListItem>
                        <asp:ListItem>id</asp:ListItem>
                        <asp:ListItem>email</asp:ListItem>
                        <asp:ListItem>aadhar</asp:ListItem>
                    </asp:DropDownList>
                <asp:TextBox ID="txtdel" runat="server" class="form-control" placeholder="Block value" Visible="False"></asp:TextBox>
                        <asp:Button ID="btndelnow" runat="server" class="btn btn-large btn-success" Height="40px" Width="180px" Text="DELETE NOW" OnClick="txtdelnow_Click" Visible="False" />
                <%--<asp:Button ID="btnupdatenow" runat="server" class="btn btn-large btn-success" Height="40px" Width="180px" Text="UPDATE NOW" OnClick="btndelnow_Click" Visible="False" />--%>
                <asp:Button ID="btneditblock" runat="server" class="btn btn-large btn-success" Height="40px" Width="180px" Text="BLOCK NOW" Visible="False" OnClick="btneditblock_Click" />
                </div>
         </div>
        </div>
       <%-- <div class="col-lg-12" style="margin-top: 20px; top: -4px; left: -8px; height: 114px; width: 988px;">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT [fname], [lname], [contact], [category], [expestatus], [password], [id] FROM [editor_details]" UpdateCommand="UPDATE [editor_details] SET [fname] = @fname, [lname] = @lname, [contact] = @contact, [category] = @category, [expestatus] = @expestatus, [password] = @password WHERE [id] = @id" DeleteCommand="DELETE FROM [editor_details] WHERE [id] = @id" InsertCommand="INSERT INTO [editor_details] ([fname], [lname], [contact], [category], [expestatus], [password]) VALUES (@fname, @lname, @contact, @category, @expestatus, @password)">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="fname" Type="String" />
                    <asp:Parameter Name="lname" Type="String" />
                    <asp:Parameter Name="contact" Type="Int64" />
                    <asp:Parameter Name="category" Type="String" />
                    <asp:Parameter Name="expestatus" Type="String" />
                    <asp:Parameter Name="password" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="fname" Type="String" />
                    <asp:Parameter Name="lname" Type="String" />
                    <asp:Parameter Name="contact" Type="Int64" />
                    <asp:Parameter Name="category" Type="String" />
                    <asp:Parameter Name="expestatus" Type="String" />
                    <asp:Parameter Name="password" Type="String" />
                    <asp:Parameter Name="id" Type="Int32" />
                </UpdateParameters>
             </asp:SqlDataSource>


      
        </div>--%>

        <div class="col-lg-11 center" >
            <asp:GridView ID="GridView1" runat="server" Visible="false" AutoGenerateColumns="False"  ShowFooter="True"  style="margin-top: 20px;margin-left:50px;" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" Width="235px">
            
         <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            
         <Columns>
         
             <asp:TemplateField HeaderText="id">
                 <HeaderTemplate><p style="text-align:center;margin-bottom:3px;margin-top:3px;">id</p></HeaderTemplate>
                   <ItemTemplate>
                       <asp:TextBox ReadOnly="true"  ID="id" runat="server" Text='<%#Eval("id")%>'></asp:TextBox>
                             <%--<asp:RequiredFieldValidator ID="EditUsernameRFV" runat="server" ErrorMessage="Username is Required" ControlToValidate="EditUsernameTextBox" ValidationGroup="APEdit">--%>

                             <%--</asp:RequiredFieldValidator>--%>
                    </ItemTemplate>
                <ControlStyle Width="30px" />
                     
            </asp:TemplateField>

            <asp:TemplateField HeaderText="fname">
                 <HeaderTemplate><p style="text-align:center;margin-bottom:3px;margin-top:3px;">fname</p></HeaderTemplate>
                   <ItemTemplate>
                       <asp:TextBox ReadOnly="true"  ID="fname" runat="server" Text='<%#Eval("fname")%>'></asp:TextBox>
                             <%--<asp:RequiredFieldValidator ID="EditUsernameRFV" runat="server" ErrorMessage="Username is Required" ControlToValidate="EditUsernameTextBox" ValidationGroup="APEdit">--%>

                             <%--</asp:RequiredFieldValidator>--%>
                    </ItemTemplate>
                <ControlStyle Width="100px" />
                     
            </asp:TemplateField>

            <asp:TemplateField HeaderText="lname">
                <HeaderTemplate><p style="text-align:center;margin-bottom:3px;margin-top:3px;">lname</p></HeaderTemplate>
                   <ItemTemplate>
                       <asp:TextBox ReadOnly="true"  ID="lname" runat="server" Text='<%#Eval("lname")%>'></asp:TextBox>
                     <%--    <asp:RequiredFieldValidator ID="FirstNameRFV" runat="server" ErrorMessage="First name is Required" ControlToValidate="EditFirstNameTextBox" ValidationGroup="MUserEdit">

                             </asp:RequiredFieldValidator>
                      --%>                                                               
                   </ItemTemplate>
                     
                 <ControlStyle Width="100px" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="contact">
                <HeaderTemplate><p style="text-align:center;margin-bottom:3px;margin-top:3px;">contact</p></HeaderTemplate> 
                <ItemTemplate>
                       
                <asp:TextBox ReadOnly="true"  ID="contact" runat="server" Text='<%#Eval("contact")%>'></asp:TextBox>
              <%--         <asp:RequiredFieldValidator ID="EditLastNameRFV" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="EditLastNameTextBox" ValidationGroup="MUserEdit">
                           </asp:RequiredFieldValidator>
               --%>                                              
                   </ItemTemplate>
                     
                <ControlStyle Width="100px" />

            </asp:TemplateField>

             <asp:TemplateField HeaderText="category">
                <HeaderTemplate><p style="text-align:center;margin-bottom:3px;margin-top:3px;">category</p></HeaderTemplate> 
                <ItemTemplate>
                       
                <asp:TextBox ReadOnly="true"  ID="category" runat="server" Text='<%#Eval("category")%>'></asp:TextBox>
              <%--         <asp:RequiredFieldValidator ID="EditLastNameRFV" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="EditLastNameTextBox" ValidationGroup="MUserEdit">
                           </asp:RequiredFieldValidator>
               --%>                                              
                   </ItemTemplate>
                     
                <ControlStyle Width="100px" />

            </asp:TemplateField>

             <asp:TemplateField HeaderText="aadhar">
                <HeaderTemplate><p style="text-align:center;margin-bottom:3px;margin-top:3px;">aadhar</p></HeaderTemplate> 
                <ItemTemplate>
                       
                <asp:TextBox ReadOnly="true"  ID="aadhar" runat="server" Text='<%#Eval("aadhar")%>'></asp:TextBox>
              <%--         <asp:RequiredFieldValidator ID="EditLastNameRFV" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="EditLastNameTextBox" ValidationGroup="MUserEdit">
                           </asp:RequiredFieldValidator>
               --%>                                              
                   </ItemTemplate>
                     
                <ControlStyle Width="120px" />

            </asp:TemplateField>
      
             
             <asp:TemplateField HeaderText="email" Visible="false">
               <HeaderTemplate><p style="text-align:center;margin-bottom:3px;margin-top:3px;">email</p></HeaderTemplate> 
                <ItemTemplate>
                       <asp:TextBox ReadOnly="true"  ID="email" runat="server" Text='<%#Eval("email")%>'></asp:TextBox>
              <%--            <asp:RequiredFieldValidator ID="StatusRFV" runat="server" ErrorMessage="Status is Required" ControlToValidate="EditStatusTextBox" ValidationGroup="MUserEdit">
                       </asp:RequiredFieldValidator>                                                                        
              --%>  </ItemTemplate>
                     
                 <ControlStyle Width="60px" />
            </asp:TemplateField>
                        
              <asp:TemplateField HeaderText="Edit">
                <HeaderTemplate><p style="text-align:center;margin-bottom:3px;margin-top:3px;">Edit</p></HeaderTemplate> 
                    <ItemTemplate>
                          <asp:LinkButton ID="EditLinkButton"   runat="server" OnClick="EditLinkButton_Click" ><p style="text-align:center;margin-top:30px;">Edit</p></asp:LinkButton>
                          <asp:LinkButton ID="UpdateLinkButton" runat="server" Visible="false" OnClick="UpdateLinkButton_Click" >Update</asp:LinkButton>
                          <asp:LinkButton ID="CancelLinkButton" runat="server" Visible="false" OnClick="CancelLinkButton_Click" >Cancel</asp:LinkButton>
                   </ItemTemplate>
                      
                  <ControlStyle Width="80px" />
            </asp:TemplateField>
           
            <asp:TemplateField HeaderText="Delete">
                 <HeaderTemplate><p style="text-align:center;margin-bottom:3px;margin-top:3px;">Delete</p></HeaderTemplate> 
                    <ItemTemplate>
                          <asp:LinkButton ID="DeleteLinkButton" runat="server"  OnClick="DeleteUserLinkButton_Click" ><p style="text-align:center;margin-top:30px;">Delete</p></asp:LinkButton>
                    </ItemTemplate>
                     
                <ControlStyle Width="60px" />
             </asp:TemplateField>
        </Columns>
            
         <EditRowStyle BackColor="#999999" />
            
         <FooterStyle BackColor="#F7F6F3" ForeColor="#333399" Font-Bold="True" />
         <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
         <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#284775" />
         <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
         <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
         <SortedAscendingCellStyle BackColor="#E9E7E2" />
         <SortedAscendingHeaderStyle BackColor="#506C8C" />
         <SortedDescendingCellStyle BackColor="#FFFDF8" />
         <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            
        </asp:GridView>

            
        </div>

 <%--            <asp:GridView ID="GridView2" runat="server" Visible="false" AutoGenerateColumns ="False" AutoGenerateEditButton="True" DataSourceID="SqlDataSource1" Width="600px" DataKeyNames="id">
                <Columns>
                    <asp:BoundField DataField="fname" HeaderText="fname" SortExpression="fname" />
                    <asp:BoundField DataField="lname" HeaderText="lname" SortExpression="lname" />
                    <asp:BoundField DataField="contact" HeaderText="contact" SortExpression="contact" />
                    <asp:BoundField DataField="category" HeaderText="category" SortExpression="category" />
                    <asp:BoundField DataField="expestatus" HeaderText="expestatus" SortExpression="expestatus" />
                    <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" Visible="false" SortExpression="id" />
                </Columns>
            </asp:GridView>--%>
    </div>
</asp:Content>

