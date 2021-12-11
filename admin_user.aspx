<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_user.aspx.cs" Inherits="admin_user" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="center text-danger">
        <div class="col-lg-11 center" style="margin-top: 20px">
              <div class="col-lg-11 center" style="margin-bottom: 20px">
                    <asp:Button ID="brnadd" runat="server" class="btn btn-large btn-success" Height="40px" Width="180px" Text="ADD" OnClick="brnadd_Click" />
                    <asp:Button ID="btndelete" runat="server" class="btn btn-large btn-success" Height="40px" Width="180px" Text="DELETE" OnClick="btndelete_Click" />
                    <asp:Button ID="btnupdate" runat="server" class="btn btn-large btn-success" Height="40px" Width="180px" Text="UPDATE" OnClick="btnupdate_Click1" />
                    <asp:Button ID="btnblock" runat="server" class="btn btn-large btn-success" Height="40px" Width="180px" Text="BLOCK" />
                    <div class="col-md-5">
                        <asp:DropDownList ID="DropDownList2" runat="server" Visible="false">
                            <asp:ListItem>Select Criteria</asp:ListItem>
                            <asp:ListItem>uid</asp:ListItem>
                            <asp:ListItem>email</asp:ListItem>
                        </asp:DropDownList>
                        <asp:TextBox ID="txtdel" runat="server" class="form-control" placeholder="Enter the delete value" Visible="False"></asp:TextBox>
                        <asp:Button ID="btndelnow" runat="server" class="btn btn-large btn-success" Height="40px" Width="180px" Text="DELETE NOW" OnClick="txtdelnow_Click" Visible="False" />
                    </div>
                </div>
         </div>
        <div class="col-lg-11 center" >
            <asp:GridView ID="GridView1" runat="server" Visible="false" AutoGenerateColumns="False"  ShowFooter="True"  style="margin-top: 20px;margin-left:50px;" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" Width="235px">
            
         <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            
         <Columns>
         
             <asp:TemplateField HeaderText="id">
                 <HeaderTemplate><p style="text-align:center;margin-bottom:3px;margin-top:3px;">id</p></HeaderTemplate>
                   <ItemTemplate>
                       <asp:TextBox ReadOnly="true"  ID="id" runat="server" Text='<%#Eval("uid")%>'></asp:TextBox>
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

            <asp:TemplateField HeaderText="mob">
                <HeaderTemplate><p style="text-align:center;margin-bottom:3px;margin-top:3px;">mob</p></HeaderTemplate> 
                <ItemTemplate>
                       
                <asp:TextBox ReadOnly="true"  ID="mob" runat="server" Text='<%#Eval("mob")%>'></asp:TextBox>
              <%--         <asp:RequiredFieldValidator ID="EditLastNameRFV" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="EditLastNameTextBox" ValidationGroup="MUserEdit">
                           </asp:RequiredFieldValidator>
               --%>                                              
                   </ItemTemplate>
                     
                <ControlStyle Width="100px" />

            </asp:TemplateField>
      
             <asp:TemplateField HeaderText="country">
               <HeaderTemplate><p style="text-align:center;margin-bottom:3px;margin-top:3px;">Country</p></HeaderTemplate> 
                <ItemTemplate>
                       <asp:TextBox ReadOnly="true"  ID="country" runat="server" Text='<%#Eval("country")%>'></asp:TextBox>
          <%--                <asp:RequiredFieldValidator ID="PasswordRFV" runat="server" ErrorMessage="Password is Required" ControlToValidate="EditPasswordTextBox" ValidationGroup="MUserEdit">
                       </asp:RequiredFieldValidator>                                                                        
          --%>      </ItemTemplate>
             
                 <ControlStyle Width="100px" />
            </asp:TemplateField>
            
             <asp:TemplateField HeaderText="state">
               <HeaderTemplate><p style="text-align:center;margin-bottom:3px;margin-top:3px;">state</p></HeaderTemplate> 
                <ItemTemplate>
                       <asp:TextBox ReadOnly="true"  ID="state" runat="server" Text='<%#Eval("state")%>'></asp:TextBox>
        <%--                  <asp:RequiredFieldValidator ID="EmailRFV" runat="server" ErrorMessage="Email is Required" ControlToValidate="EditEmailTextBox" ValidationGroup="MUserEdit">
                       </asp:RequiredFieldValidator>                                                                        
         --%>   </ItemTemplate>
                     
             </asp:TemplateField>
           
             
             <asp:TemplateField HeaderText="pin">
               <HeaderTemplate><p style="text-align:center;margin-bottom:3px;margin-top:3px;">pin</p></HeaderTemplate> 
                <ItemTemplate>
                       <asp:TextBox ReadOnly="true"  ID="pin" runat="server" Text='<%#Eval("pin")%>'></asp:TextBox>
              <%--            <asp:RequiredFieldValidator ID="StatusRFV" runat="server" ErrorMessage="Status is Required" ControlToValidate="EditStatusTextBox" ValidationGroup="MUserEdit">
                       </asp:RequiredFieldValidator>                                                                        
              --%>  </ItemTemplate>
                     
                 <ControlStyle Width="60px" />
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
    </div>
</asp:Content>

