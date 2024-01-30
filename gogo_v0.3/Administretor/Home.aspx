<%@ Page Title="HOME" Language="C#" MasterPageFile="~/Administretor/admin3.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="gogo_v0._3.Administretor.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid m-5">
        <div class="container-md p-5">

   <div class="row">

                        <!-- Earnings (Monthly) Card Example -->
                        <div class="col-xl-3 col-md-6 mb-4">
                            <div class="card border-left-primary shadow h-100 py-2">
                                <div class="card-body">
                                    <div class="row no-gutters align-items-center">
                                        <div class="col mr-2">
                                            <div class="text-xs font-weight-bold text-primary text-uppercase mb-1">
                                               מספר נהגים</div>
                                            <div class="h5 mb-0 font-weight-bold text-gray-800">  <%= Session["cnt_Driver"] %></div>
                                        </div>
                                        <div class="col-auto">
                                            <i class="fas fa-calendar fa-2x text-gray-300"></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Earnings (Monthly) Card Example -->
                        <div class="col-xl-3 col-md-6 mb-4">
                            <div class="card border-left-success shadow h-100 py-2">
                                <div class="card-body">
                                    <div class="row no-gutters align-items-center">
                                        <div class="col mr-2">
                                            <div class="text-xs font-weight-bold text-success text-uppercase mb-1">
                                                מספר מרלוגים </div>
                                            <div class="h5 mb-0 font-weight-bold text-gray-800"><%= Session["cnt_marlog"] %></div>
                                        </div>
                                        <div class="col-auto">
                                            <i class="fas fa-dollar-sign fa-2x text-gray-300"></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Earnings (Monthly) Card Example -->
                        <div class="col-xl-3 col-md-6 mb-4">
                            <div class="card border-left-info shadow h-100 py-2">
                                <div class="card-body">
                                    <div class="row no-gutters align-items-center">
                                        <div class="col mr-2">
                                            <div class="text-xs font-weight-bold text-info text-uppercase mb-1">מספר משלוחים פתוחים
                                            </div>
                                            <div class="row no-gutters align-items-center">
                                                <div class="col-auto">
                                                    <div class="h5 mb-0 mr-3 font-weight-bold text-gray-800"><%= Session["cnt_Shipment"] %></div>
                                                </div>
                                                <div class="col">
                                                    <div class="progress progress-sm mr-2">
                                                        <div class="progress-bar bg-info" role="progressbar" style="width: <%=Session["cnt_Shipment"]%>%" aria-valuenow="<%= Session["cnt_Shipment"] %>" aria-valuemin="0" aria-valuemax="100"></div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-auto">
                                            <i class="fas fa-clipboard-list fa-2x text-gray-300"></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Pending Requests Card Example -->
                        <div class="col-xl-3 col-md-6 mb-4">
                            <div class="card border-left-warning shadow h-100 py-2">
                                <div class="card-body">
                                    <div class="row no-gutters align-items-center">
                                        <div class="col mr-2">
                                            <div class="text-xs font-weight-bold text-warning text-uppercase mb-1">
                                                משלוחים סגורים</div>
                                            <div class="h5 mb-0 font-weight-bold text-gray-800"><%= Session["lest_Id"] %></div>
                                        </div>
                                        <div class="col-auto">
                                            <i class="fas fa-comments fa-2x text-gray-300"></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>




           <div class="card mb-4 p-5 m-5">
                <div class="card-header">
                    <i class="fas fa-table me-1"></i>
                    Shupments List
                </div>
                <div class="card-deck">
                    <table id="datatablesSimple">

                            <thead>
                            <tr>
                                <th>Id</th>
                                <th>City</th>
                                <th>Street</th>
                                <th>Data start </th>
                              
                                <th>Start end</th>
                                <th>Phone</th>
                                <th>Box</th>
                                <th>edit</th>
                                <th>Select</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="rpt" runat="server" OnItemDataBound="rpt_ItemDataBound">
                         
                                <ItemTemplate>

                                    <tr>
                                         <td><%#Eval("S_id") %></td>
                                        <td><%#Eval("S_city") %></td>
                                        <td><%#Eval("S_street") %></td>
                                        <td><%#Eval("S_dataStart") %></td>
                                        
                                        <td><%#Eval("S_dataEnd") %></td>
                                        <td><%#Eval("S_phone") %></td>
                                         <td><%#Eval("S_sumBox") %></td>
                                        <td><a href="AddShipments.aspx?Sid=<%#Eval("S_id") %>&op=del" class="btn btn-outline-warning btn-sm">delete</a> 
                                        <a href="UpdataShipment.aspx?Sid=<%#Eval("S_id") %>&op=edit" class="btn btn-outline-warning btn-sm">Edit</a>
                                        </td>
                                        <td>    <input class="form-check-input" type="checkbox" name="Shpment" value='<%# Eval("S_id") %>' id="Checks" checked="checked" />
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
