<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="gogo_v0._3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl" >
<head runat="server">
   
   
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="CoreUI Bootstrap 4 Admin Template">
    <meta name="author" content="Lukasz Holeczek">
    <meta name="keyword" content="CoreUI Bootstrap 4 Admin Template">
    <!-- <link rel="shortcut icon" href="assets/ico/favicon.png"> -->
    <title>Login | gogo</title>
    <!-- Icons -->
    <link href="admin/css/font-awesome.min.css" rel="stylesheet">
    <link href="admin/css/simple-line-icons.css" rel="stylesheet">
    <!-- Main styles for this application -->
    <link href="admin/dest/style.css" rel="stylesheet">

</head>

   <form id="form1" runat="server">
        <div>

        
  <body class=""> 

    
    <div class="container">
        <div class="row">
            <div class="col-md-8 m-x-auto pull-xs-none vamiddle">
                <div class="card-group ">
                    <div class="card p-a-2">
                        <div class="card-block">
                            <h1>התחברות</h1>
                            <p class="text-muted">אנא הזן שם משתמש וסיסמה</p>
                            <div class="input-group m-b-1">
                                <span class="input-group-addon"><i class="icon-user"></i>
                                </span>

                                <asp:TextBox  ID="Email" AutoCompleteType="Email" CssClass="form-control en " placeholder="email" runat="server" />
                                
                            </div>
                            <div class="input-group m-b-2">
                                <span class="input-group-addon"><i class="icon-lock"></i>
                                </span>
                                <asp:TextBox ID="Pass" TextMode="Password" runat="server" placeholder="pass" CssClass="form-control en" Text="סיסמה" />
                                
                            </div>
                            <div class="row">
                                <div class="col-xs-6">


                                    <asp:Button ID="Btn_Login" Text="Login" OnClick="Btn_login" runat="server" CssClass="btn btn-primary p-x-2" />
                                    <i class="icon-login"></i>
        
                                    
                                </div>
                                <div class="col-xs-6 text-xs-right">
                                    <a type="button" href="forgot Pass.aspx" class="btn btn-link p-x-0">שכחתי את הסיסמה</a>
                                        <a  class="btn btn-link p-x-0" href="forgot Pass.aspx" Text="שכחתי את הסיסמה"  ></a>
                                    
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="card card-inverse card-primary p-y-3" style="width:44%">
                        <div class="card-block text-xs-center">
                            <div>
                                <h2>GoGo</h2>
                                <p>ניהול מרלוגים ושליחויות</p>
                                <a type="button" href="Register.aspx" class="btn btn-primary active m-t-1">הירשם</a>

                                   <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="Invalid email address" ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$" Display="Dynamic"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>












    <!-- Bootstrap and necessary plugins -->
    <script src="admin/js/libs/jquery.min.js"></script>
    <script src="admin/js/libs/tether.min.js"></script>
    <script src="admin/js/libs/bootstrap.min.js"></script>
    <script>
        function verticalAlignMiddle() {
            var bodyHeight = $(window).height();
            var formHeight = $('.vamiddle').height();
            var marginTop = (bodyHeight / 2) - (formHeight / 2);
            if (marginTop > 0) {
                $('.vamiddle').css('margin-top', marginTop);
            }
        }
        $(document).ready(function () {
            verticalAlignMiddle();
        });
        $(window).bind('resize', verticalAlignMiddle);
    </script>
    <!-- Grunt watch plugin -->
    <script src="//localhost:35729/livereload.js"></script>
    
    

</body>



      </div>
    </form>


</html>
