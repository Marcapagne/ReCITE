var classId = '';

function setup() {
  getgame_type();
  getClassId().then(() => {
    getData();
    setTimeout(() => {
      writeDailyRecord();
    }, 1000);
  })
}

async function getClassId() {
  await database.ref('key/classId').once('value').then(function (snapshot) {
    classId = snapshot.val();
  })
}

function getData() {
  console.log(classId);
  var ref = database.ref('classList/' + classId);
  ref.on('value', function (snapshot) {
    snapshot.forEach(element => {
      samp_names.push(element.val().name);
    });
  });
}


function updateOverall(name) {
  database.ref('daily/' + classId + '/' + game_type + '/' + name + '/')
    .once('value')
    .then(function (snapshot) {
      snapshot.ref.child('score').set(snapshot.val().score + 1);
      getDailyScore(name);
    });

}

let game_type = '';
function getgame_type() {
  database.ref('game/type').once('value').then(function (snapshot) {
    game_type = snapshot.val();
  })
}


async function getDailyScore(name) {
  database.ref('classList/' + classId + '/' + name + '/')
    .once('value')
    .then(function (snapshot) {
      snapshot.ref.child('score').set(snapshot.val().score + 1);
    });
}

function writeDailyRecord() {
  samp_names.forEach(name => {
    var ref = database.ref('daily/' + classId + '/' + game_type + '/' + name);
    ref.set({
      name: name,
      score: 0,
      lifeline: {
        cf: false,
        s: false,
        hu: false
      }
    })
  })
}

let selectedName = 'Kris';

function addPoints() {
  database.ref('daily/' + classId + '/' + game_type + '/' + selectedName + '/')
    .once('value')
    .then(function (snapshot) {
      updateOverall(selectedName);
    });
}

function getLifeLineStatus(name) {
  database.ref('daily/' + classId + '/' + game_type + '/' + selectedName + '/lifeline')
    .once('value')
    .then(function (snapshot) {
      if (snapshot.val().cf) document.getElementById("cll").style.display = "none";
      if (snapshot.val().s) document.getElementById("skp").style.display = "none";
      if (snapshot.val().hu) document.getElementById("hdle").style.display = "none";
      callAFriend = snapshot.val().cf;
      skip = snapshot.val().s;
      huddleUp = snapshot.val().hu;
    });
}

function useLifeLine(specialAttack) {
  database.ref('daily/' + classId + '/' + game_type + '/' + selectedName + '/lifeline/'+specialAttack)
    .set(true);
  getLifeLineStatus();
}
