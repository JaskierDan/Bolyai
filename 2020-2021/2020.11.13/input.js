let input = document.getElementById("input-field");
let update = document.getElementById("update-field");

function hideInput(){
    input.style.transition = "1s";
    input.style.top = "-50%";
}

function showInput(){
    input.style.transition = "1s";
    input.style.top = "50%";
}

function hideUpdate(){
    update.style.transition = "1s";
    update.style.top = "-50%";
}

function showUpdate(){
    update.style.transition = "1s";
    update.style.top = "50%";
}