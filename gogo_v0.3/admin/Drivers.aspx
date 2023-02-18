<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="Drivers.aspx.cs" Inherits="gogo_v0._3.admin.Drivers" %>
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
                              <asp:Repeater ID="RtpCustomer" runat="server" >
                                  <ItemTemplate>

                             <tr>
                                  <td><%#Eval("D_name") %></td>

                            </tr>



                                  </ItemTemplate>                                
                              </asp:Repeater>

                          </tbody>
                    </table>

        </div>

    </div>





</asp:Content>
