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

                                    <form class="mx-1 mx-md-4">

                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <input type="text" id="Name" value="dcd" dir="rtl" class="form-control" runat="server" />
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
                                                <label class="form-label" for="form3Example3c">Address</label>
                                            </div>
                                        </div>

                                        

                                        <div class="d-flex justify-content-center mx-4 mb-3 mb-lg-4">
                                   

                                           <asp:Button runat="server" ID="addDriver" CssClass="btn btn-primary btn-lg  btn-block col-12 m-2 p-2 " Text="Add" OnClick="addDriver_Click"   />       

                                        </div>

                                    </form>


                                </div>
                                <div class="col-md-10 col-lg-6 col-xl-7 d-flex align-items-center order-1 order-lg-2">

                                    <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-registration/draw1.webp"
                                        class="img-fluid" alt="Sample image">
                                    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
                                    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>


</asp:Content>
