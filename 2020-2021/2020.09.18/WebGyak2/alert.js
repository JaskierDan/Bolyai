function showAlert(){
    x = document.getElementById("input");
    y = document.getElementById("input").value;
    if(y == ""){
        alert("Please input something!");
    }
    else{
        alert(y);
        x.value = "";
    }
}