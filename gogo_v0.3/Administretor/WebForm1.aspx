<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="gogo_v0._3.Administretor.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script src="https://polyfill.io/v3/polyfill.min.js?features=default"></script>

    <link rel="stylesheet" type="text/css" href="./style.css" />
    <%--<script type="module" src="./index.js"> </script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    
    <div id="container">
      <div id="map"></div>
      <div id="sidebar">
        <p>Total Distance: <span id="total"></span></p>
        <div id="panel"></div>
      </div>
    </div>



    <script>



        function initMap() {
            const map = new google.maps.Map(document.getElementById("map"), {
                zoom: 4,
                center: {  }, // Australia.
            });
            const directionsService = new google.maps.DirectionsService();
            const directionsRenderer = new google.maps.DirectionsRenderer({
                draggable: true,
                map,
                panel: document.getElementById("panel"),
            });
           
            directionsRenderer.addListener("directions_changed", () => {
                const directions = directionsRenderer.getDirections();

                if (directions) {
                    computeTotalDistance(directions);
                }
            });
            displayRoute(
                "אשדוד, ישראל",
                "חיפה, ישראל",
                directionsService,
                directionsRenderer
            );
        }

        

        function displayRoute(origin, destination, service, display) {
            service
                .route({
                    origin: origin,
                    destination: destination,
                    waypoints: [
                        { location: "רמלה,ישראל" },
                        { location: "רמלה,ישראל" },
                        { location: "רמלה,ישראל" },
                       
                    ],
                    travelMode: google.maps.TravelMode.DRIVING,
                    avoidTolls: true,
                    optimizeWaypoints: true, // מאפשר סידור הקו על פי בעית הסוכן הנוסע
                })
                .then((result) => {
                    display.setDirections(result);
                })
                .catch((e) => {
                    alert("Could not display directions due to: " + e);
                });
        }

        function computeTotalDistance(result) {
            let total = 0;
            const myroute = result.routes[0];

            if (!myroute) {
                return;
            }

            for (let i = 0; i < myroute.legs.length; i++) {
                total += myroute.legs[i].distance.value;
            }

            total = total / 1000;
            document.getElementById("total").innerHTML = total + " km";
        }
        document.addEventListener('DOMContentLoaded', () => {
            initMap();
        });




        
        /*window.initMap = initMap;*/
    </script>

    <asp:literal id="ltaWayPonit" runat="server"/>


    <script
      src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAdb8PCEpJNc-q-ojME4uQRdOEV-Kp2UkU&callback=initMap&v=weekly"
      defer
    ></script>
</body>
</html>
