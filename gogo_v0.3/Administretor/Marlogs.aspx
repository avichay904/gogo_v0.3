﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Administretor/admin3.Master" AutoEventWireup="true" CodeBehind="Marlogs.aspx.cs" Inherits="gogo_v0._3.Administretor.Marlogs" %>
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
                                        <td><%#Eval("C_name") %></td>
                                        <td><%#Eval("C_phone") %></td>
                                        <td><%#Eval("C_city") %></td>
                                        <td><%#Eval("C_email") %></td>
                                          <td>
                                              <a href="Add Marlog.aspx?Sid=<%#Eval("C_id") %>&op=del" class="btn btn-outline-warning btn-lg ">delat</a>
                                              <a href="Add Marlog.aspx?Sid=<%#Eval("C_id") %>&op=edit" class="btn btn-outline-warning btn-lg ">edit</a>

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
