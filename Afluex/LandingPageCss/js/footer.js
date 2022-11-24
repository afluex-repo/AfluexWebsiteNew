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
                      <input type="text" id="mobile" name="mobile" placeholder="Enter Your Mobile No."  data-error="Please fill Out" maxlength="10" minlength="10" onkeypress = "return isNumberKey(event);">
                      <div class="help-block with-errors"></div>
                    </div>
                  </div>
		            <div class="row">
		             <div class="form-group col-sm-12">
		                <input type="email" id="email" name="email"  placeholder="Enter Your Email" />
		              </div>
		            </div>
                    <div class ="row">
                    <div class ="form-group col-sm-5">
                       <h4 type="text" id="mainCaptcha"></h4>
                       </div>
                       <div class ="col-md-7">
                       <p><i class ="fa fa-refresh" onclick="Captcha();" style="cursor:pointer"></i></p>
                       </div>
                       </div>
                       <div class ="row">
                       <div class ="col-sm-12">
                         <input type="text" id="txtInput" name="txtInput" placeholder="Enter captcha"/>
                       </div></div>
                     <button type="button"  id="save" name="save" onclick="return SaveDetails1();" class ="btn lnk btn-main bg-btn">Submit<span class ="circle"></span></button>
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
     <script src="../LandingpageCss/js/typer.js"></script>

   <script type="text/javascript">
$(document).ready(function() {
Captcha();
});
function SaveDetails1() {
    debugger;
      var Rndcaptcha = $("#mainCaptcha").val();
      var Inputcaptcha = $("#txtInput").val();

    $("#divload").css({'display': ''})
    $(".errortext").removeClass("errortext");
    if($("#name").val() == "") {
        $("#name").addClass('errortext');
        $("#name").focus();
           return false;
     }

    if($("#mobile").val() == "") {
        $("#mobile").addClass('errortext');
        $("#mobile").focus();
        return false;
        }

    if($("#email").val() == "") {
        $("#email").addClass('errortext');
        $("#email").focus();
        return false;
     }
    if($("#txtInput").val() == "") {
        $("#txtInput").addClass('errortext');
        $("#txtInput").focus();
        return false;
   }

     if (Inputcaptcha != Rndcaptcha) {
        alert("Invalid Captcha!");
        $("#txtInput").addClass('errortext');
        $("#txtInput").focus();
        $("#txtInput").val("");
        return false;
     }
else {
            var Name = $('#name').val();
            var Mobile = $('#mobile').val();
            var Email = $('#email').val();
                  $.ajax({
                        url: "/Home/SaveLandingPage",
                        Type: "Post",
                        DataType: "JSON",
                        data: { Name: $('#name').val(), Mobile: $('#mobile').val(), Email: $('#email').val()},
                        success: function (data) {
                        debugger
                        $(".main_loader").css({ 'display': 'none' });
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

function Captcha() {
     var alpha = new Array('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
	 	'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
 	    	'0', '1', '2', '3', '4', '5', '6', '7', '8', '9');
     var i;
     for (i=0; i<6; i++) {
         var a = alpha[Math.floor(Math.random() * alpha.length)];
         var b = alpha[Math.floor(Math.random() * alpha.length)];
         var c = alpha[Math.floor(Math.random() * alpha.length)];
         var d = alpha[Math.floor(Math.random() * alpha.length)];
         var e = alpha[Math.floor(Math.random() * alpha.length)];
         var f = alpha[Math.floor(Math.random() * alpha.length)];
         var g = alpha[Math.floor(Math.random() * alpha.length)];
}
         var code = a+b+c+d+e+f+g;
         document.getElementById("mainCaptcha").innerHTML = code
		 document.getElementById("mainCaptcha").value = code
         document.getElementById("mainCaptcha1").innerHTML = code
		 document.getElementById("mainCaptcha1").value = code
}
//function removeSpaces(string) {
//     return string.split(' ').join('');
//}
    </script>
	`);

