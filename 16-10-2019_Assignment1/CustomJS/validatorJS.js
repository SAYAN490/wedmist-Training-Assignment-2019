function Validateform()                                    
{ 
    var name = document.forms["registration"]["name"];               
    var email = document.forms["registration"]["Email"];    
    var age = document.forms["registration"]["Age"]; 
    var bio = document.forms["registration"]["message"];

    var gender =  document.getElementsByName("Gender");  
    var lang =  document.getElementsByName("language"); 
    
   
    if (name.value == "")                                  
    { 
        alert("Please enter your name."); 
        name.focus(); 
        return false; 
    } 
   
    if (age.value == "")                               
    { 
        alert("Please enter your age."); 
        age.focus(); 
        return false; 
    } 
       
    if (email.value == "")                                   
    { 
        alert("Please enter a valid e-mail address."); 
        email.focus(); 
        return false; 
    } 
   
    if (email.value.indexOf("@", 0) < 0)                 
    { 
        alert("Please enter a valid e-mail address."); 
        email.focus(); 
        return false; 
    } 
   
    if (email.value.indexOf(".", 0) < 0)                 
    { 
        alert("Please enter a valid e-mail address."); 
        email.focus(); 
        return false; 
    } 
    
    if (gender[0].checked==false && gender[1].checked==false&& gender[2].checked==false)
        {alert("Please select gender");
        return false;}
    if (lang[0].checked==false && lang[1].checked==false&& lang[2].checked==false)
        {alert("Please select Language");
        return false;}
    if (bio.value==null|| bio.value=="") // text area validator not working ...
        {
            alert("Please enter Bio");
            return false;
        }

    
    alert ("Entered Name:" +name.value +" , "+"Age is: "+ age.value + " , "+"Email is: "+email.value+" , "+"Bio is: "+bio.value);
    
    if(gender[0].checked== true)
        alert ("Selected Gender is: "+gender[0].value);
    else if(gender[1].checked== true)
        alert ("Selected Gender is: "+gender[1].value);
    else
        alert ("Selected gender is: "+gender[2].value);

    if(lang[0].checked== true)
        alert ("Selected language is: "+lang[0].value+"  Press ok to submit ");
    else if(lang[1].checked== true)
        alert ("Selected language is: "+lang[1].value+ "  Press ok to submit ");
    else
        alert ("Selected language is: "+lang[2].value+ "  Press ok to submit ");
    
   
    
   
    return true; 
}


