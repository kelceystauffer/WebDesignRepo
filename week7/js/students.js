function initializestudents() {
    var data = getTeststudents();
    displaystudents(data.students);
}

function getTeststudents() {
    return JSON.parse(teststudents);
}

function displaystudents(students) {

    for(i = 0; i < students.length; i++) {

        console.log('name: ' + students[i].name);
        
        var name = students[i].name;
        var price = students[i].price;
        var available = students[i].available ? 'yes' : 'no';
        var markup = "<tr><td>" + name + "</td><td>$" + price + "</td><td>" + available + "</td></tr>";

        $("table tbody").append(markup);
    }
}

var teststudents = '{"students id ": [{"id": "91821447","email": ks@oit.edu}]}'
