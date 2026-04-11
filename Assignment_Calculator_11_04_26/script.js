function getValues() {
    let a = parseFloat(document.getElementById("num1").value);
    
    let b = parseFloat(document.getElementById("num2").value);
    return [a, b];
}

function add() {
    let [a, b] = getValues();

    document.getElementById("result").innerText = "Result: " + (a + b);
}

function subtract() {
    let [a, b] = getValues();

    document.getElementById("result").innerText = "Result: " + (a - b);
}

function multiply() {
    let [a, b] = getValues();

    document.getElementById("result").innerText = "Result: " + (a * b);
}

function divide() {
    let [a, b] = getValues();
    
    if (b === 0) {
        document.getElementById("result").innerText = "Cannot divide by zero";
    } else {
        document.getElementById("result").innerText = "Result: " + (a / b);
    }
}