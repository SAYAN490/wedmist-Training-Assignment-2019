
$(document).ready(function() {

    $('#Regform').submit(function(e) {
      e.preventDefault();
      
      var name = $('#name').val();
      
      var email = $("#email").val();
      var emailReg = /^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$/;

      var radioValue = $("input[name='gender']:checked").val();
      var radioValue1 = $("input[name='language']:checked").val();
      
      var age = $('#age').val() ;

      $(".error").remove();
      
      
      if (name.length < 1) {
        $('#name').after('<span class="error">This field is required</span>');
      }
      
      
      if (age == '') {
        $('#age').after('<span class="error">This field is required</span>');
      }
      
      if(email == '') {
        $('#email').after('<span class="error">Please enter your email address.</span>');
        hasError = true;
      }
   
      else if(!emailReg.test(email)) {
        $('#email').after('<span class="error" >Enter a valid email address.</span>');
        hasError = true;
      }
     
        
        if(radioValue){
            alert("Your are a - " + radioValue);
        }
        else{
            alert("please select a gender.");
        }
    
    
        
        if(radioValue1){
            alert("You speaks - " + radioValue1);
        }
        else{
            alert("please select a language.");
        }
    
});
});

  
