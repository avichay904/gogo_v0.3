<%@ Page Title="" Language="C#" MasterPageFile="~/Administretor/admin3.Master" AutoEventWireup="true" CodeBehind="Drivers.aspx.cs" Inherits="gogo_v0._3.Administretor.Drivers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


           <div class="container-fluid px-4">

            <div class="card mb-4">
                <div class="card-body">
                    DataTables is a third party plugin that is used to generate the demo table below. For more information about DataTables, please visit the
                    <a target="_blank" href="https://datatables.net/">official DataTables documentation</a>

                </div>
            </div>
            <div class="card mb-4">
                <div class="card-header">
                    <i class="fas fa-table me-1"></i>
                   Driver List
                </div>
                <div class="card-body">
                    <table id="datatablesSimple">


                        <thead>
                            <tr>
                                <th>Name</th>
                                <th>Phone</th>
                                <th>Address </th>
                                <th>Email</th>
                                <th>Edit</th>

                            </tr>
                        </thead>
                        <tbody>

                            <asp:Repeater ID="rpt" runat="server">
                                <ItemTemplate>

                                    <tr>
                                        <td><%#Eval("D_name") %></td>
                                        <td><%#Eval("D_phone") %></td>
                                        <td><%#Eval("D_address") %></td>
                                        <td><%#Eval("D_email") %></td>
                                          <td><a href="AddDriver.aspx?Did=<%#Eval("D_id") %>&op=del" class="btn btn-outline-warning btn-lg "></a> 
                                              <a href="AddDriver.aspx?Did=<%#Eval("D_id") %>&op=edit" class="btn btn-outline-warning btn-lg "></a> 
                                          </td>

                                    </tr>

                                </ItemTemplate>

                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>



</asp:Content>
