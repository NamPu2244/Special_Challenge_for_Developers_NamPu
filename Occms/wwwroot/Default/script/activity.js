let act = new XMLHttpRequest();
act.open('GET', 'https://localhost:44300/ActivityChaeson/AllActivityChaeson');
act.onload = function () {
    if (act.status === 200) {
        const activitys = JSON.parse(act.responseText);
        let cardHTML = '';
        for (let i = 0; i < activitys.length; i++) {
            const activity = activitys[i];
            cardHTML += `
              <div class="col-lg-6 mx-auto d-flex justify-content-center">
                        <div class="" style="width: 624px; height : 701px;">
                            <img src="${activity.activityChaesonPicture}"class="card-img-top" alt="activity">
                            <div class="card-body text-center">
                                <h2 class="card-title my-3" id="title">${activity.activityChaesonName}</h2>
                                <p class="card-text" id="disc">${activity.activityChaesonDetail}</p>
                            </div>
                        </div>
                    </div>`;
        }
        document.getElementById('card-container').innerHTML = cardHTML;
    } else {
        console.log('เกิดข้อผิดพลาดในการดึงข้อมูล');
    }
};
act.send();