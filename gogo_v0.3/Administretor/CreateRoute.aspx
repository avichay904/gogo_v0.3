<%@ Page Title="" Language="C#" MasterPageFile="~/Administretor/admin3.Master" AutoEventWireup="true" CodeBehind="CreateRoute.aspx.cs" Inherits="gogo_v0._3.Administretor.CreateRoute" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid m-5">
        <div class="container m-5">


            <div class="card m-5">
  <div class="card-header">
    <h1 class="text-center">create Route</h1>
  </div>
  <div class="card-body mb-5">
  

    <div class="row">
          <div class="col">
                    <label class="form-label" for="form3Example4cd">origin addrcs</label>
                    <input class="form-control" id="user_input_autocomplete_address2" name="user_input_autocomplete_address">
                </div>
                <div class="col">
                    <label class="form-label" for="form3Example4cd">phone</label>
                    <input class="form-control" id="phone" runat="server">
                </div>
                <div class="col">
                    <label class="form-label" for="form3Example4cd">end addrcs</label>
                    <input class="form-control" id="user_input_autocomplete_address" name="user_input_autocomplete_address">
                </div>
                <div class="col">
                    <label class="form-label" for="form3Example4cd">Data start</label>
                    <input class="form-control datatable-table" type="date" id="dataEnd" runat="server">
                </div>
            </div>
      <div class="row-cols-xxl-4">
                                <select class="form-select">
                                    <option selected>Driver</option>

                                    <asp:Repeater ID="Repiter" runat="server">
                                        <ItemTemplate>
                                            <option value="1" "><%#Eval("D_name") %></option>

                                        </ItemTemplate>

                                    </asp:Repeater>

                                </select>
        
                                       <div class="">
                                    <a class="btn btn-outline-info m-4" href="Shipments.aspx">Back</a>

                                </div>
                                <div class="col bs-tether-element-attached-right">
                                    <a class="btn btn-outline-info m-4" href="Shipments.aspx">Creat</a>

                                </div>
                                </div>
  
                 </div>
                  </div>

    

           <%--<iframe width="560" height="315" src="http://localhost:5173/" frameborder="0" allowfullscreen="true"></iframe>--%>

        </div>
   

                    <!-- Include Google Maps JS API -->
                <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?libraries=places&amp;key=AIzaSyAdb8PCEpJNc-q-ojME4uQRdOEV-Kp2UkU "></script>

                <script type="text/javascript"



                <script type="text/javascript" src="dist/js/GoogleApi/GoogleApiKey.js"></script>

                <!-- Custom JS code to bind to Autocomplete API -->
                <script type="text/javascript" src="dist/js/GoogleApi/autocomplete.js"></script>
</asp:Content>
