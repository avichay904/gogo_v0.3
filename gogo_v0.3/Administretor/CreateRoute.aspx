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
                    <label class="form-label" for="form3Example4cd">Data start Route</label>
                    <input class="form-control datatable-table" type="date" id="dataEnd" runat="server">
          
              </div>      
    
    
        <div class="col"
                             
                                  <label class="form-label" for="form3Example4cd">Driver</label>
                               <asp:DropDownList ID="Dname" runat="server" CssClass="form-select col" />
            </div>

        <div class="col"
                                  <label class="form-label" for="form3Example4cd">Marlog</label>
                              <asp:DropDownList ID="Cname" runat="server" CssClass="form-select col" />
   
                                    </div>
                
        </div>

     
                        

      <div class="card-body">
                    <table  class="table table-success table-striped">


                        <thead class="">
                            <tr>
                                <th>City</th>
                                <th>Street</th>
                                <th>Data start </th>
                                <th>meseges</th>
                                <th>Data end</th>
                        
                            </tr>
                        </thead>
                        <tbody>

                            <asp:Repeater ID="rpt" runat="server" >
                                <ItemTemplate>

                                    <tr>
                                        <td><%#Eval("S_city") %></td>
                                        <td><%#Eval("S_street") %></td>
                                        <td><%#Eval("S_dataStart") %></td>
                                   
                                        <td><%#Eval("S_msg") %></td>
                                        <td><%#Eval("S_dataEnd") %></td>
                                
                                        </td>
                                 
                                       
                                    </tr>

                                </ItemTemplate>

                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
      </div>
      
                                     <div class="d-flex justify-content-center mx-4 mb-3 mb-lg-4">
                                   

                                           <asp:Button runat="server" ID="creatRout" CssClass="btn btn-primary btn-lg  btn-block col-12 m-2 p-2 " Text="Add" OnClick="creatRout_Click" />       

                                  \
</div>
                

                </div>
            </div>












        <%--<iframe width="560" height="315" src="http://localhost:5173/" frameborder="0" allowfullscreen="true"></iframe>--%>

        </div>
   

          
</asp:Content>
