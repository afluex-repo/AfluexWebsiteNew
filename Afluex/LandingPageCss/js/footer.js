document.write(`
<div class="footer-row3">
    <div class="copyright">
       <div class="container">
          <div class="row">
             <div class="col-lg-12">
                <div class="footer-">
                   <p>© 2017 Afluex Multiservices LLP || All Rights Reserved.</p>
                </div>
             </div>
          </div>
       </div>
    </div>
 </div>

<!-- lead generaton popup start -->
<div class="modal leadpopup fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel">
   <div class="modal-dialog modal-dialog-centered">
     <div class="modal-content">
       <div class="modal-body">
         <div class="innerbody">
           <div class="innerleft">
            <div class="leadbtnclose"> <button type="button" class="btn-close" data-bs-dismiss="modal"></button></div>
               <h3>Get A Demo</h3>
               <p class ="mt-2">Please fill out the form below if you have a plan or project in mind that you'd like to share with us.</p>
           <form id="form" data-bs-toggle="validator" class ="shake mt20" action="/home/crmsoftware">
               <div class="form-block">
               	<div class="form-block formcover shadow">
                <div class="row">
                    <div class="form-group col-sm-6">
                      <input type="text" id="name" name="name" placeholder="Enter Your Name" data-error="Please fill Out">
                      <div class="help-block with-errors"></div>
                    </div>
                    <div class="form-group col-sm-6">
                      <input type="text" id="mobile" name="mobile" placeholder="Enter Your Mobile No." data-error="Please fill Out"  onkeypress = "return isNumberKey(event);">
                      <div class="help-block with-errors"></div>
                    </div>
                  </div>
		            <div class="row">
		             <div class="form-group col-sm-12">
		                <input type="email" id="email" name="email"  placeholder="Enter Your Email" />
		              </div>
		            </div>
                    <button type="button"  id="save" name="save" onclick="return ActionSaveDetails();" class ="btn lnk btn-main bg-btn">Submit<span class ="circle"></span></button>
		            <div class ="clearfix"></div>
		      </form>
               </div>
             </div>
           </div>
         </div>
       </div>
     </div>
   </div>
 </div>
<!-- lead generaton popup end -->
      <!-- js placed at the end of the document so the pages load faster -->
     <script src="../LandingPageCss/js/jquery.min.js"></script>
     <script src="../LandingpageCss/js/vendor/modernizr-3.5.0.min.js"></script>

    <script src="../LandingpageCss/js/bootstrap.bundle.min.js"></script>
    <script src="../LandingpageCss/js/plugin.min.js"></script>
    <script src="../LandingpageCss/js/preloader.js"></script>
    <!--common script file-->
    <script src="../LandingpageCss/js/main.js"></script>
    <script src="../LandingpageCss/js/progress-bar.js"></script>

   <script type="text/javascript">


function ActionSaveDetails() {
    debugger;
    $("#divload").css({'display': ''})
    $(".errortext").removeClass("errortext");
    if($("#name").val() == "") {
        $("#name").addClass('errortext');
        $("#name").focus();
        return false();
}

    if($("#mobile").val() == "") {
        $("#mobile").addClass('errortext');
        $("#mobile").focus();
        return false();
}

    if($("#email").val() == "") {
        $("#email").addClass('errortext');
        $("#email").focus();
        return false();
}

else {
 $("#page_loader").css({ 'display': 'block !important'});
            var Name = $('#name').val();
            var Mobile = $('#mobile').val();
            var Email = $('#email').val();
             $.ajax({
    url: "/Home/SaveLandingPage",
    Type: "Post",
    DataType: "JSON",
    data: { Name: $('#name').val(), Mobile: $('#mobile').val(), Email: $('#email').val() },
    success: function (data) {
                        debugger
                        $("#page_loader").css({ 'display': 'none' });
                        if (data.Result == "true") {
                        alert('Your Details Save SuccessFully !!');
                       window.location.replace("https://afluex.com/home/crmsoftware");
}
else {
                          alert(data.Result);
}
}
});
}
}
  function isNumberKey(evt) {
        var charCode = (evt.which) ? evt.which: event.keyCode;
        if (charCode != 46 && charCode > 31
          && (charCode < 48 || charCode > 57))
            return false;
        return true;
}
//$('button[type=submit]').attr('disabled', 'disabled');

//var randomNum1;
//var randomNum2;

////set the largeest number to display

//var maxNum = 20;
//var total;

//randomNum1 = Math.ceil(Math.random() * maxNum);
//randomNum2 = Math.ceil(Math.random() * maxNum);
//total = randomNum1 +randomNum2;

//$("#question").prepend(randomNum1 + " + " +randomNum2 + "=");

//// When users input the value

//$("#ans").keyup(function() {

//  var input = $(this).val();
//  var slideSpeed = 200;

//  $('#message').hide();

//  if (input == total) {

//    $('button[type=submit]').removeAttr('disabled');
//    $('#success').slideDown(slideSpeed);
//    $('#fail').slideUp(slideSpeed);

//} else {

//    $('button[type=submit]').attr('disabled', 'disabled');
//    $('#fail').slideDown(slideSpeed);
//    $('#success').slideUp(slideSpeed);

//}

//});

//// Wheen "reset button" click, generating new randomNum1 & randomNum2
//$("#reset").on("click", function() {
//  randomNum1 = Math.ceil(Math.random() * maxNum);
//  randomNum2 = Math.ceil(Math.random() * maxNum);
//  total = randomNum1 +randomNum2;
//  $("#question").empty();
//  $("#ans").val('');
//  $("#question").prepend(randomNum1 + " + " +randomNum2 + "=");
//});
    </script>
	`);
