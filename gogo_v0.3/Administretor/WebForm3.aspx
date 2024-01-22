<%@ Page Title="" Language="C#" MasterPageFile="~/Administretor/admin3.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="gogo_v0._3.Administretor.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAdb8PCEpJNc-q-ojME4uQRdOEV-Kp2UkU&callback=initMap"></script>
    <script type="text/javascript" src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
    <script type="text/javascript">
        function initMap() {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(showUserLocation);
            } else {
                alert("הדפדפן שלך לא תומך בשליפת מיקום.");
            }
        }

        function showUserLocation(position) {
            var userLocation = new google.maps.LatLng(position.coords.latitude, position.coords.longitude);

            var mapOptions = {
                center: userLocation,
                zoom: 8,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };

            var map = new google.maps.Map(document.getElementById("map"), mapOptions);
        }
    </script>

    

</asp:Content>
