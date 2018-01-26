var mapHospital;
var infowindow2;


function initMap2() {

    var pyrmont = { lat: 23.763831, lng: 90.406886 };

    mapHospital = new google.maps.Map(document.getElementById('mapHospital'), {
        center: pyrmont,
        zoom: 15
    });

    infowindow2 = new google.maps.InfoWindow();
    var service2 = new google.maps.places.PlacesService(mapHospital);
    service2.nearbySearch({
        location: pyrmont,
        radius: 500,
        type: ['hospital']
    }, callback);
}

function callback2(results, status) {
    if (status === google.maps.places.PlacesServiceStatus.OK) {
        for (var i = 0; i < results.length; i++) {
            createMarker(results[i]);
        }
    }
}

function createMarker(place) {
    var placeLoc = place.geometry.location;
    var marker = new google.maps.Marker({
        map: mapHospital,
        position: place.geometry.location
    });

    google.maps.event.addListener(marker, 'click', function () {
        infowindow2.setContent(place.name);
        infowindow2.open(map, this);
    });
}
