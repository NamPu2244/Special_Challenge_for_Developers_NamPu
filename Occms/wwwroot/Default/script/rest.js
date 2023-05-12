let rest = new XMLHttpRequest();
rest.open('GET', 'https://localhost:44300/LocationRest/AllLocationRest');
rest.onload = function () {
    if (rest.status === 200) {
        const rests = JSON.parse(rest.responseText);
        let cardHTML = '';
        for (let i = 0; i < rests.length; i++) {
            const locationrest = rests[i];
            cardHTML += `<div class="col-lg-4 mx-auto d-flex justify-content-center">
                        <div class="">
                            <img src="${locationrest.locationRestPicture}" width="424" height="447" class="card-img-top" alt="rest">
                            <div class="card-body text-center">
                                <h5 class="card-title">${locationrest.locationRestName}</h5>
                            </div>
                        </div>
                    </div>`;
        }
        document.getElementById('card-container').innerHTML = cardHTML;
    } else {
        console.log('เกิดข้อผิดพลาดในการดึงข้อมูล');
    }
};
rest.send();