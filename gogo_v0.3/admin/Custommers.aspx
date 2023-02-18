<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="Custommers.aspx.cs" Inherits="gogo_v0._3.admin.Custommers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container-fluid">

        <div class="container">


                    <table class="table table-striped">
                         <thead>
                           <tr>
                          <th scope="col">שם</th>
                          <th scope="col">טלפון</th>
                          <th scope="col">מייל</th>
                          <th scope="col">עיר</th>
                         </tr>
                         </thead>
                          <tbody>
                              <asp:Repeater ID="RtpCustomer" runat="server" OnItemDataBound="RtpCustomer_ItemDataBound">
                                  <ItemTemplate>

                             <tr>
                                  <td><%#Eval("C_id") %></td>
                                 <td> <asp:Literal ID="Lit" /></td>

                                            
                                            
                            </tr>



                                  </ItemTemplate>                                
                              </asp:Repeater>

                          </tbody>
                    </table>

        </div>

    </div>


</asp:Content>
