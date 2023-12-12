<%@ Page Title="" Language="C#" MasterPageFile="~/Administretor/admin3.Master" AutoEventWireup="true" CodeBehind="AddDriver.aspx.cs" Inherits="gogo_v0._3.Administretor.AddDriver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <section class="container-fluid" ">
        <div class="container h-100">
            <div class="row d-flex justify-content-center align-items-center h-100">
                <div class="col-lg-12 col-xl-11">
                    <div class="card text-black" style="border-radius: 25px;">
                        <div class="card-body p-md-5">
                            <div class="row justify-content-center">
                                <div class="col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1">

                                    <p class="text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4">Add Driver </p>

                               

                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <input type="text" id="Name" dir="rtl" class="form-control" runat="server" />
                                                <label class="form-label" dir="rtl" for="form3Example1c">Name</label>
                                            </div>
                                        </div>

                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-envelope fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <input type="email" aria-autocomplete="both" autocomplete="on" id="Email" class="form-control" runat="server" />
                                                <label class="form-label" for="form3Example3c">Email</label>
                                            </div>
                                        </div>



                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-envelope fa-lg me-3 fa-phone"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <input type="text" id="phone" autocomplete="on" aria-autocomplete="list" class="form-control" runat="server" />
                                                <label class="form-label" for="form3Example3c">טלפון</label>
                                            </div>
                                        </div>
                                        
                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-envelope fa-lg me-3  fa-location-arrow"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <input type="text"  id="Address" class="form-control" runat="server" />
                                                <label class="form-label" for="form3Example3c">City</label>
                                            </div>
                                        </div>

                                        

                                        <div class="d-flex justify-content-center mx-4 mb-3 mb-lg-4">
                                   
                              

                                           <asp:Button runat="server" ID="addDriver" CssClass="btn btn-primary btn-lg  btn-block col-12 m-2 p-2 " Text="Add" OnClick="addDriver_Click"   />       

                                        </div>

                         


                                </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>


</asp:Content>
