<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="Editor_Update.aspx.cs" Inherits="Editor_Update1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="col-lg-11 center" >
            <asp:GridView ID="GridView1" Visible="true" runat="server" AutoGenerateColumns="False"  ShowFooter="True"  style="margin-top: 20px;margin-left:50px;" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" Width="235px">
            
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
</asp:Content>

