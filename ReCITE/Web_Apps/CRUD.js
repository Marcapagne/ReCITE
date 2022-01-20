

var classId = '';

function gameType(type) {
    console.log(type)
    getClassId().then(() => {
        getData();
        setTimeout(() => {
            writeDailyRecord();
        }, 1000);
    })
}


async function getClassId() {
    await database.ref('key/classid').once('value').then(function (snapshot) {
        classId = snapshot.val();
    })
}

function getData() {
    var ref = database.ref('classList/' + classId + '/');
    ref.on('value', function (snapshot) {
        snapshot.forEach(element => {
            samp_names.push(element.val().name);
        });
    });
}


function updateOverall(name) {
    database.ref('daily/' + classId + '/' + name + '/')
        .once('value')
        .then(function (snapshot) {
            snapshot.ref.child('score').set(snapshot.val().score + 1);
            getDailyScore(name);
        });

}

async function getDailyScore(name) {
    console.log(name)
    database.ref('classList/' + classId + '/' + name + '/')
        .once('value')
        .then(function (snapshot) {
            snapshot.ref.child('score').set(snapshot.val().score + 1);
        });
}


function writeDailyRecord() {
    samp_names.forEach(name => {
        var ref = database.ref('daily/' + classId + '/' + name);
        ref.set({
            name: name,
            score: 0
        })
    })
}

let selectedName = 'Kris';

function addPoints() {
    database.ref('daily/' + classId + '/' + selectedName + '/')
        .once('value')
        .then(function (snapshot) {
            updateOverall(selectedName);
        });
}