﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Administretor/admin3.Master" AutoEventWireup="true" CodeBehind="Shipments.aspx.cs" Inherits="gogo_v0._3.Administretor.Shipments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <main>
        <div class="container-fluid px-4">

                </div>
            </div>
        <div class="container">
  
</div>
            <div class="card mb-4 p-5 m-5">
                <div class="card-header">
                    <i class="fas fa-table me-1"></i>
                    Shupments List
                </div>
                <div class="card-body">
                    <table id="datatablesSimple">

                            <thead>
                            <tr>
                                <th>Id</th>
                                <th>City</th>
                                <th>Street</th>
                                <th>Data start </th>
                                <th>Driver</th>
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
                                        <td><asp:Literal ID="ltl_Driver" runat="server" /></td>
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
                <a href="CreateRoute.aspx" onclick="return passData(this);" class="btn btn-outline-warning btn-sm">Create Route</a>

            </div>
        </div>
    </main>
    
    <script type="text/javascript">
    function passData(link) {
        var selectedIds = "";
        var checkboxes = link.parentNode.parentNode.getElementsByTagName("input");
        if (selectedIds == "") {
            for (var i = 0; i < checkboxes.length; i++) {
                if (checkboxes[i].type == "checkbox" && checkboxes[i].checked == true) {
                    selectedIds += checkboxes[i].value + ",";
                }
            }
        }
        if (selectedIds == "") {
            alert("Please select at least one shipment");
            return false;
        }
        link.href += "?Sid=" + selectedIds;
    }
    </script>


</asp:Content>
