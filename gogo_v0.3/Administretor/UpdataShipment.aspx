<%@ Page Title="" Language="C#" MasterPageFile="~/Administretor/admin3.Master" AutoEventWireup="true" CodeBehind="UpdataShipment.aspx.cs" Inherits="gogo_v0._3.Administretor.UpdataShipment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container ">
            <div class="card shadow mb-4 p-5 m-5">
                <div class="card-header py-3">
                    <h6 class="m-0 font-weight-bold text-primary text-center">הוספת משלוח</h6>
                </div>
                <div class="card-body">
                    <div class="container text-center p-5 m-4 ">
   
                       
                        <div class="row">
                            <div class="col">
                                <label class="form-label" for="form3Example4cd">City</label>
                                <asp:TextBox CssClass="form-control" ClientIDMode="Static" ID="locality" SkinID="locality" runat="server" />

                            </div>
                            <div class="col">
                                <label class="form-label" for="form3Example4cd">Sreet</label>
                                <asp:TextBox CssClass="form-control" ClientIDMode="Static" ID="route" SkinID="route" runat="server" />

                            </div>
                            <div class="col">
                                <label class="form-label" for="form3Example4cd">Nume Street</label>
                                <asp:TextBox CssClass="form-control" ClientIDMode="Static" ID="street_number" SkinID="street_number" runat="server" />
                            </div>

                        </div>

                        <div class="row">
                            <div class="col">
                                <label class="form-label" for="form3Example4cd">phone</label>
                                <input class="form-control" id="phone" runat="server">
                            </div>
                            <div class="col">
                                <label class="form-label" for="form3Example4cd">Nume Box</label>
                                <input class="form-control" type="number" id="numBox" runat="server">
                            </div>
                            <div class="col">
                                <label class="form-label" for="form3Example4cd">Data end</label>
                                <input class="form-control datatable-table" type="date"  id="dataEnd" runat="server">
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label class="visually-hidden" for="autoSizingSelect">Preference</label>

                                <select class="form-select">
                                    <option selected id="Cname" runat="server">Marlog</option>
                                    <asp:Repeater ID="rpt" runat="server">
                                        <ItemTemplate>
                                            <option value="1" id="Op" runat="server"><%#Eval("C_name") %></option>

                                        </ItemTemplate>
                                    </asp:Repeater>

                                </select>
                            </div>

                            <div class="col">
                                <label class="visually-hidden" for="autoSizingSelect">Preference</label>

                                <select class="form-select">
                                    <option selected>Driver</option>

                                    <asp:Repeater ID="Repiter" runat="server">
                                        <ItemTemplate>
                                            <option value="1" "><%#Eval("D_name") %></option>

                                        </ItemTemplate>

                                    </asp:Repeater>

                                </select>
                            </div>

                        </div>

                        <div class="col">
                            <label class="form-label" for="form3Example4cd">mesegess</label>
                            <input class="form-control" type="text" id="msg" runat="server">
                        </div>                       


                        <asp:Button  ID="Btn" CssClass="btn btn-primary btn-lg btn-block col-12 m-2 p-2" Text="Add" runat="server" OnClick="Btn_Click" />

                    </div>
                </div>
              
        </div>
    
</asp:Content>
