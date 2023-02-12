<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="Shipments.aspx.cs" Inherits="gogo_v0._3.admin.Shipments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <!-- Bootstrap Core CSS -->


    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    
    <div class="col-lg-12">
                        <div class="card">
                            <div class="card-header">
                                <i class="fa fa-align-justify"></i> Combined All Table
                            </div>
                            <div class="card-block">
                                <table class="table table-bordered table-striped table-condensed">
                                    <thead>
                                        <tr>
                                            <th>Username</th>
                                            <th>Date registered</th>
                                            <th>Role</th>
                                            <th>Status</th>
                                        </tr>
                                    </thead>
                                    <tbody>
       
                                        <asp:Repeater ID="Rpt" runat="server">
                                            <ItemTemplate>
                                            <tr>
                                            <td><%#Eval("S_id") %></td>
                                            <td><%#Eval("S_city") %></td>
                                            <td><%#Eval("S_dataStart") %></td>
                                                <td><%#Eval("S_id") %></td>
                                            <td><%#Eval("S_city") %></td>
                                            <td><%#Eval("S_dataStart") %></td>
                                                <td><%#Eval("S_id") %></td>
                                            <td><%#Eval("S_city") %></td>
                                            <td><%#Eval("S_dataStart") %></td>
                                                <td><%#Eval("S_id") %></td>
                                            <td><%#Eval("S_city") %></td>
                                            <td><%#Eval("S_dataStart") %></td>
                                            
                                                <span class="tag tag-danger">Banned</span>
                                            </td>
                                        </tr>

                                            </ItemTemplate>
                                        </asp:Repeater>
                                       
                                        
                                <nav>
                                    <ul class="pagination">
                                        <li class="page-item"><a class="page-link" href="#">Prev</a>
                                        </li>
                                        <li class="page-item active">
                                            <a class="page-link" href="#">1</a>
                                        </li>
                                        <li class="page-item"><a class="page-link" href="#">2</a>
                                        </li>
                                        <li class="page-item"><a class="page-link" href="#">3</a>
                                        </li>
                                        <li class="page-item"><a class="page-link" href="#">4</a>
                                        </li>
                                        <li class="page-item"><a class="page-link" href="#">Next</a>
                                        </li>
                                    </ul>
                                </nav>
                            </div>
                        </div>
                    </div>
     
</asp:Content>
