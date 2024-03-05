<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Map.aspx.cs" Inherits="gogo_v0._3.Administretor.Map" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script src="https://polyfill.io/v3/polyfill.min.js?features=default"></script>

    <link rel="stylesheet" type="text/css" href="./style.css" />
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
                center: { lat: -24.345, lng: 134.46 }, // Australia.
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
                "Perth, WA",
                "Sydney, NSW",
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
                        { location: "Adelaide, SA" },
                        { location: "Broken Hill, NSW" },
                    ],
                    travelMode: google.maps.TravelMode.DRIVING,
                    avoidTolls: true,
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
      src="https://maps.googleapis.com/maps/api/js?key=&callback=initMap&v=weekly"
      defer
    ></script>

</body>
</html>
