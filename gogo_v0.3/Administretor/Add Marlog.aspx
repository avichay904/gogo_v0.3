<%@ Page Title="" Language="C#" MasterPageFile="~/Administretor/admin3.Master" AutoEventWireup="true" CodeBehind="Add Marlog.aspx.cs" Inherits="gogo_v0._3.Administretor.AddMarlog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container-fluid">
        <div class="container">


            <section class="vh-100 bg-image">
                <div class="mask d-flex align-items-center h-100 gradient-custom-3">
                    <div class="container h-100">
                        <div class="row d-flex justify-content-center align-items-center h-100">
                            <div class="col-12 col-md-9 col-lg-7 col-xl-6">
                                <div class="card" style="border-radius: 15px;">
                                    <div class="card-body p-5 m-3">
                                        <h2 class="text-uppercase text-center mb-5 p-5">Create a Marlog </h2>


                                        <div class="form-outline mb-4">
                                            <input type="text" id="name" runat="server" class="form-control form-control-lg" />
                                            <label class="form-label" for="form3Example1cg">Marlog Name</label>
                                        </div>

                                        <div class="form-outline mb-4">
                                            <input type="email" id="email" runat="server" class="form-control form-control-lg" />
                                            <label class="form-label" for="form3Example3cg">marlog Email</label>

                                            <div class="form-outline mb-4">
                                                <input type="text" id="phone" runat="server" class="form-control form-control-lg" />
                                                <label class="form-label" for="form3Example3cg">phone</label>
                                            </div>

                                            <div class="form-outline mb-4">
                                                <input type="text" id="city" runat="server" class="form-control form-control-lg" />
                                                <label class="form-label" for="form3Example3cg">city</label>
                                            </div>
                                            <div class="form-outline mb-4">
                                                <input type="text" id="street" runat="server" class="form-control form-control-lg" />
                                                <label class="form-label" for="form3Example3cg">street</label>
                                            </div>
                                            <div class="form-outline mb-4">
                                                <input type="text" id="nHome" runat="server" class="form-control form-control-lg" style="z-index: 9999" />
                                                <label class="form-label" for="form3Example3cg">street nume</label>
                                            </div>

                                            <div class="d-flex justify-content-center">
                                                <asp:Button ID="btnAdd" Style="z-index: 9999" CssClass="btn btn-warning myCss  btn-lg gradient-custom-4 text-body" OnClick="btnAdd_Click" Text="Add marlog" runat="server" />

                                            </div>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </div>


</asp:Content>
