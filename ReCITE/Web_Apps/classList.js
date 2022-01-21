function setup() {
  console.log('called');
  getClassId().then(() => {
    getTableData();
  })
}

let classId = '';
async function getClassId() {
  await database.ref('key/classId').once('value').then(function (snapshot) {
    classId = snapshot.val();
  })
}


let segments = [];

function getTableData() {
  var ref = database.ref('classList/' + classId);
  ref.orderByChild('score').on('value', function (snapshot) {
    segments.splice(0, segments.length);
    snapshot.forEach(element => {
      var item = {
        'score': element.val().score,
        'name': element.val().name
      }
      segments.push(item);
    });
    console.log(segments)
    createTableItems();
  });
}

function createTableItems() {
  segments.sort((a, b) => (a.score > b.score ? -1 : 1));
  let main = document.getElementById("main");
  main.innerHTML = '';
  segments.forEach(student => {
    let tr = document.createElement("tr");
    tr.className = 'item';
    let td_name = document.createElement("td");
    let name = document.createTextNode(student['name']);
    let td_score = document.createElement("td");
    let score = document.createTextNode(student['score']);
    let td_actions = document.createElement("td");
    let deleteButton = document.createElement('button');
    let btnText = document.createTextNode('Delete');
    deleteButton.appendChild(btnText);
    deleteButton.setAttribute("onClick", "deleteStudent('"+ student['name'] +"')")
    td_name.appendChild(name);
    td_score.appendChild(score);
    td_actions.appendChild(deleteButton)
    tr.appendChild(td_name);
    tr.appendChild(td_score);
    tr.appendChild(td_actions);

    main.appendChild(tr)
  })

  keys = [];
}


function deleteStudent(studentName) {
  var ref = database.ref('classList/' + classId + '/' + studentName);
  ref.remove();
}