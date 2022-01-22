function setup() {
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
    // let td_name = document.createElement("td");
    // let name = document.createTextNode(student['name']);


    let name_input = document.createElement("input");
    name_input.disabled = true;
    name_input.value = student['name']
    name_input.id = student['name'];
    name_input.style.border = 'none';
    name_input.className = 'inputName';

    let td_score = document.createElement("td");
    let score = document.createTextNode(student['score']);
    let td_actions = document.createElement("td");
    let deleteButton = document.createElement('img');
    deleteButton.src = '../Resources/delete.png';
    deleteButton.setAttribute("onClick", "deleteStudent('" + student['name'] + "')")

    let editButton = document.createElement('img');
    editButton.src = '../Resources/edit.png';
    editButton.id = student['name'] + "_edit";
    editButton.setAttribute("onClick", "editable('" + student['name'] + "')")

    let save = document.createElement('img');
    save.src = '../Resources/check.png';
    save.id = student['name'] + '_save';
    save.setAttribute('onClick', "save('" + student['name'] + "')");
    save.style.display = 'none';

    // td_name.appendChild(name);
    td_score.appendChild(score);
    td_actions.appendChild(editButton);
    td_actions.appendChild(save);
    td_actions.appendChild(deleteButton);
    // tr.appendChild(td_name);
    tr.appendChild(name_input)
    tr.appendChild(td_score);
    tr.appendChild(td_actions);

    main.appendChild(tr)
  })

  keys = [];
}

function save(name) {
  document.getElementById(name + '_edit').style.display = 'inline';
  document.getElementById(name).disabled = true;
  document.getElementById(name + '_save').style.display = 'none';
  var nameValue = document.getElementById(name).value;
  
  var ref1 = database.ref('classList/' + classId + '/' + name);
  ref1.on('value', function (snapshot) {
    update(nameValue, snapshot.val().score);
  });

  if(nameValue != name ) ref1.remove();
}

function update(name, score) {
  var ref2 = database.ref('classList/' + classId + '/' + name);
  ref2.set({
    name: name,
    score: score
  })
}

function deleteStudent(studentName) {
  var ref = database.ref('classList/' + classId + '/' + studentName);
  ref.remove();
}

function editable(id) {
  document.getElementById(id + '_edit').style.display = 'none';
  document.getElementById(id + "_save").style.display = 'inline';
  document.getElementById(id).disabled = false;
}