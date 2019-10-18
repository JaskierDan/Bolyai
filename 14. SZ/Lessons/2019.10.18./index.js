function $(id){
    return document.getElementById(id);
}

function showAlert(){
    alert($('input1').value + ' ' + $('input2').value);
}

if($('btn1')){
    $('btn1').addEventListener('click', showAlert);
}