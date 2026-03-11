const apiUrl = "https://localhost:7039/api/students";

function loadStudents() {

fetch(apiUrl)
.then(res => res.json())
.then(data => {

let list = document.getElementById("studentList");
list.innerHTML = "";

data.forEach(student => {

let li = document.createElement("li");
li.textContent = student;   // student.name nahi

list.appendChild(li);

});

});

}