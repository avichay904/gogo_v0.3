<%@ Page Title="HOME" Language="C#" MasterPageFile="~/Administretor/admin3.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="gogo_v0._3.Administretor.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid ">
        <h1 class="mt-4"></h1>
        <ol class="breadcrumb mb-4">
            <li class="breadcrumb-item active"></li>
        </ol>
        <div class="row  p-5    ">
            <div class=" col-3">
                <div class="card bg-primary text-white mb-4">
                    <div class="card-body">Shipments</div>
                    <div class="card-footer d-flex align-items-center justify-content-between">
                        <a class="small text-white stretched-link" href="Shipments.aspx">View Details</a>
                        <div class="small text-white">
                            <svg class="svg-inline--fa fa-angle-right" aria-hidden="true" focusable="false" data-prefix="fas" data-icon="angle-right" role="img" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 256 512" data-fa-i2svg="">
                                <path fill="currentColor" d="M246.6 233.4c12.5 12.5 12.5 32.8 0 45.3l-160 160c-12.5 12.5-32.8 12.5-45.3 0s-12.5-32.8 0-45.3L178.7 256 41.4 118.6c-12.5-12.5-12.5-32.8 0-45.3s32.8-12.5 45.3 0l160 160z"></path></svg><!-- <i class="fas fa-angle-right"></i> Font Awesome fontawesome.com --></div>
                    </div>
                </div>
            </div>
            <div class=" col-3">
                <div class="card bg-primary text-white mb-4">
                    <div class="card-body">Driver</div>
                    <div class="card-footer d-flex align-items-center justify-content-between">
                        <a class="small text-white stretched-link" href="Drivers.aspx">View Details</a>
                        <div class="small text-white">
                            <svg class="svg-inline--fa fa-angle-right" aria-hidden="true" focusable="false" data-prefix="fas" data-icon="angle-right" role="img" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 256 512" data-fa-i2svg="">
                                <path fill="currentColor" d="M246.6 233.4c12.5 12.5 12.5 32.8 0 45.3l-160 160c-12.5 12.5-32.8 12.5-45.3 0s-12.5-32.8 0-45.3L178.7 256 41.4 118.6c-12.5-12.5-12.5-32.8 0-45.3s32.8-12.5 45.3 0l160 160z"></path></svg><!-- <i class="fas fa-angle-right"></i> Font Awesome fontawesome.com --></div>
                    </div>
                </div>
            </div>
            <div class=" col-3">
                <div class="card bg-primary text-white mb-4">
                    <div class="card-body">marlog</div>
                    <div class="card-footer d-flex align-items-center justify-content-between">
                        <a class="small text-white stretched-link" href="Marlogs.aspx">View Details</a>
                        <div class="small text-white">
                            <svg class="svg-inline--fa fa-angle-right" aria-hidden="true" focusable="false" data-prefix="fas" data-icon="angle-right" role="img" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 256 512" data-fa-i2svg="">
                                <path fill="currentColor" d="M246.6 233.4c12.5 12.5 12.5 32.8 0 45.3l-160 160c-12.5 12.5-32.8 12.5-45.3 0s-12.5-32.8 0-45.3L178.7 256 41.4 118.6c-12.5-12.5-12.5-32.8 0-45.3s32.8-12.5 45.3 0l160 160z"></path></svg><!-- <i class="fas fa-angle-right"></i> Font Awesome fontawesome.com --></div>
                    </div>
                </div>
            </div>

        </div>
    </div>
    
             <div class="row">
                 <div class="col">
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
                                          <td><a href="AddDriver.aspx?Did=<%#Eval("D_id") %>&op=del" class="btn btn-outline-dark btn-lg ">Delete</a> 
                                              <a href="AddDriver.aspx?Did=<%#Eval("D_id") %>&op=edit" class="btn btn-outline-warning btn-lg ">Edit</a> 
                                          </td>

                                    </tr>

                                </ItemTemplate>

                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
                     </div>




                 <div class="col">

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

                            <asp:Repeater ID="Repeater1" runat="server">
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


                 <div class="col">

                 </div>
        </div>
</asp:Content>
