let main = new XMLHttpRequest();
main.open('GET', 'https://localhost:44300/LocationTravel/AllLocationTravel');
main.onload = function () {
    if (main.status === 200) {
        const locations = JSON.parse(main.responseText);
        let cardHTML = '';
        for (let i = 0; i < locations.length; i++) {
            const location = locations[i];
            cardHTML += `
              <div class="col-lg-4 mx-auto d-flex justify-content-center" id="card">
                <div class="card" style="width: 424px;">
                    <img src="${location.locationTravelPicture}" width="336px" height="250px" class="card-img-top" alt="mainlocation">
                    <div class="card-body text-center">
                        <h3 class="card-title">${location.locationTravelName}</h3>
                        <p class="card-text">${location.locationTravelDetail}</p>
                    </div>
                </div>
              </div>`;
        }
        document.getElementById('card-container').innerHTML = cardHTML;
    } else {
        console.log('เกิดข้อผิดพลาดในการดึงข้อมูล');
    }
};
main.send();