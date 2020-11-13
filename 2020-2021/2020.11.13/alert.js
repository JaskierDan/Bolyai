function showAlert(){
    x_Fname = document.forms['personalInfo']['fullName'].value;
    x_Email = document.forms['personalInfo']['email'].value;
    if(x_Fname == "" || x_Email == ""){
        alert("Please fill out all the input fields!");
        return false;
    }
}

function showUpdateAlert(){
    y_Fname = document.forms['updatePersonalInfo']['fullName'].value;
    y_Email = document.forms['updatePersonalInfo']['email'].value;
    if(y_Fname == "" || y_Email == ""){
        alert("Please fill out all the input fields!");
        return false;
    }
}