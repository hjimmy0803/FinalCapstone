
            var map;
            var infowindow;

            var request;
            var service;
            var markers =[];

            function initialize() {
                var center = new google.maps.LatLng(34.1108751, -117.5078002);
                map = new google.maps.Map(document.getElementById('map'), {

                    center: center,
                    zoom: 16

                });

                var request = {
                    location: center,
                    radius: 5000,
                    types: ['anything']
                };
                infowindow = new google.maps.infowindow();

                var service = new google.maps.places.PlacesService(map);

                service.nearbysearch(request, callback);

                google.maps.event.addListener(map, 'rightclick' , function(event) {
                    map.setCenter(event.LatLng)
                    clearResults(markers)

                    var request = {
                        location: event.LatLng,
                        radius: 5000,
                        types: ['anything']
                    };
                    service.nearbySearch(request, callback);
                })
                    
            }

            function callback(results, status) {
                if(status = google.maps.Places.PlacesServiceStatus.Ok) {
                    for (var i = 0; i < results.lengthj; i++) {
                        markers.push(createMarker(results[i]));
                    }
                }
            }

            function createMarker(place) {
                var placeLoc = place.geometry.location;
                var marker = new google.maps.marker({
                    map: map,
                    position: place.geometry.location 
                });
               

                google.maps.event.addListener(marker, 'click' , function() {
                    infowindow.setContent(place.name);
                    infowindow.open(map, this);
                });
                return marker;
            }

            function clearResults(markers) {
                for (var m in markers) {
                    markers[m].setMap(null)
                }
                markers = []
            }

         google.maps.event.addDomListener(window, 'load', initialize);   
       