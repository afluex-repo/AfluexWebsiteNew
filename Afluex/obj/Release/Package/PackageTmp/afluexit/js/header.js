document.write(`
<!doctype html>
<html lang="en">

<head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,300;0,400;0,500;0,700;0,900;1,300;1,400;1,500;1,700;1,900&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Open+Sans:ital,wght@0,300;0,400;0,600;0,700;0,800;1,300;1,400;1,600;1,700;1,800&display=swap" rel="stylesheet">

    <!-- Bootstrap CSS -->
    <link href="images/favicon.png" rel="shortcut icon">
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">
    <link href="css/responsive.css" rel="stylesheet">
    <link href="css/fontawesome.min.css" rel="stylesheet">
    <link href="css/owl.carousel.css" rel="stylesheet">
    <link href="css/owl.carousel.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.2/css/fontawesome.min.css" rel="stylesheet">
    <!-- <link href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/assets/owl.theme.default.min.css" rel="stylesheet"> -->
    <link rel="stylesheet" href="./css/glightbox.css">
    <title>Afluex Multiservices LLP</title>
</head>

<body>

    <div class="main_loader">
        <div class="loader_inner" style="z-index:99999">
            <div class="loader">
                <div class="face">
                    <div class="circle"></div>
                </div>
                <div class="face">
                    <div class="circle"></div>
                </div>
                <img src="images/loader.png" class="img-fluid af-logo" alt="logo">
            </div>
        </div>
    </div>

    <div class ="top_header">
        <div class ="container">
            <div class ="row">
                <div class ="col-lg-12">
                    <nav class ="navbar navbar-expand-lg navbar-light">
                      <div class ="container-fluid nav-container">
                        <div class ="logo">
                          <a href="index.html"><img src="images/logo-black.png" class ="img-fluid af-logo" alt="logo"></a>
                      </div>
                      <button class ="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                          <span class ="navbar-toggler-icon"></span>
                      </button>
                      <div class ="collapse navbar-collapse" id="navbarSupportedContent">
                          <ul class ="navbar-nav ms-auto mb-2 mb-lg-0 profile-menu">
                            <li class ="nav-item">
                                <a class ="nav-link active" aria-current="page" href="index.html">Home</a>
                            </li>
                          <!-- <li class ="nav-item dropdown">
                              <a class ="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                Dropdown
                            </a>
                            <ul class ="dropdown-menu" aria-labelledby="navbarDropdown">
                                <li><a class ="dropdown-item" href="#">Action</a></li>
                                <li><a class ="dropdown-item" href="#">Another action</a></li>
                                <li><hr class ="dropdown-divider"></li>
                                <li><a class ="dropdown-item" href="#">Something else here</a></li>
                            </ul>
                        </li> -->
                        <li class ="nav-item dropdown">
                            <a class ="nav-link" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                About Us <span class ="dropdown_icon"><i class ="fa fa-angle-down" aria-hidden="true"></i></span>
                            </a>
                             <div class ="dropdown-menu" aria-labelledby="navbarDropdown">
                            <div class ="pro_mega">
                            <ul class ="list-unstyled">
                                <li><a class ="dropdown-item" href="company-overview.html">Company Overview</a></li>
                                <li><a class ="dropdown-item" href="vision-and-mission.html">Mission & Vision</a></li>
                                <li><a class ="dropdown-item" href="our-team.html">Our Team</a></li>
                            </ul>
                            </div>
                            </div>
                        </li>
                        <li class ="nav-item dropdown">
                            <a class ="nav-link" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                Services <span class ="dropdown_icon"><i class ="fa fa-angle-down" aria-hidden="true"></i></span>
                            </a>
                            <div class ="dropdown-menu" aria-labelledby="navbarDropdown">
                            <div class ="pro_mega">
                            <ul class ="list-unstyled">
                                <li><a class ="dropdown-item" href="website-development-services.html">Website Development</a></li>
                                <li><a class ="dropdown-item" href="software-development-services.html">Software Development</a></li>
                                <li><a class ="dropdown-item" href="app-development-services.html">Mobile App Development</a></li>
                                <li><a class ="dropdown-item" href="mvc-training-services.html">Asp.net / MVC Training</a></li>
                                <li><a class ="dropdown-item" href="digital-marketing-services.html">Digital Marketing</a></li>
                                <li><a class ="dropdown-item" href="domain-and-hosting-services.html">Domain &amp; Hosting</a></li>
                                <li><a class ="dropdown-item" href="seo-services.html">SEO Services</a></li>
                                <li><a class ="dropdown-item" href="graphic-designs.html">Graphic Design</a></li>
                            </ul>
                            </div>
                            </div>
                        </li>
                        <li class ="nav-item dropdown menu_area">
                            <a class ="nav-link" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                Product <span class ="dropdown_icon"><i class ="fa fa-angle-down" aria-hidden="true"></i></span>
                            </a>
                            <div class ="dropdown-menu mega_area" aria-labelledby="navbarDropdown">
                                <div class ="row">
                                    <div class ="col-lg-4 col-md-4">
                                        <div class ="pro_mega">
                                            <ul class ="list-unstyled">
                                                <li><a class ="dropdown-item" href="mlm-software.html">MLM Software</a></li>
                                                <li><a class ="dropdown-item" href="real-estate-software.html">Real Estate Software </a></li>
                                                <li><a class ="dropdown-item" href="ecommerce-software.html">E-commerce Software</a></li>
                                                <li><a class ="dropdown-item" href="edu_tech/index.html">School Management Software</a></li>
                                                <li><a class ="dropdown-item" href="travel-portal-software.html">Travel Portal Software</a></li>
                                                <li><a class ="dropdown-item" href="flight-booking-software.html">Flight Booking Software</a></li>
                                                <li><a class ="dropdown-item" href="hospital-management-software.html">Hospital Management Software</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class ="col-lg-4 col-md-4">
                                        <div class ="pro_mega">
                                            <ul class ="list-unstyled">
                                                <li><a class ="dropdown-item" href="mobile-recharge-software.html">Mobile Recharge Software</a></li>
                                                <li><a class ="dropdown-item" href="news-portal-software.html">News Portal Software</a></li>
                                                <li><a class ="dropdown-item" href="crm-software.html">CRM Software</a></li>
                                                <li><a class ="dropdown-item" href="hrms-software.html">HRMS Software</a></li>
                                                <li><a class ="dropdown-item" href="erp-software.html">ERP Software</a></li>
                                                <li><a class ="dropdown-item" href="followup-software.html">Followup Software</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class ="col-lg-4 col-md-4">
                                        <div class ="pro_mega">
                                            <ul class ="list-unstyled">
                                                <li><a class ="dropdown-item" href="daily-expenses-software.html">Daily Expenses</a></li>
                                                <li><a class ="dropdown-item" href="nidhi-software.html">Nidhi Software</a></li>
                                                <li><a class ="dropdown-item" href="helping-software.html">Helping Software</a></li>
                                                <li><a class ="dropdown-item" href="restaurant-billing-software.html">Restaurant Billing Software</a></li>
                                                <li><a class ="dropdown-item" href="loan-management-software.html">Loan Management Software</a></li>
                                                <li><a class ="dropdown-item" href="mart-billing-software.html">Mart Billing Software</a></li>
                                                <li><a class ="dropdown-item" href="inventry-management-software.html">Inventory Management Software </a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </li>
                        <li class ="nav-item">
                            <a class ="nav-link" href="portfolio.html">Portfolio</a>
                        </li>
                        <li class ="nav-item">
                            <a class ="nav-link" href="gallery.html">Gallery</a>
                        </li>
                        <li class ="nav-item">
                            <a class ="nav-link" href="blog.html">Blog</a>
                        </li>
                        <li class ="nav-item">
                            <a class ="nav-link" href="career.html">Career</a>
                        </li>
                        <li class ="nav-item">
                            <a class ="nav-link" href="contactus.html">Contact Us</a>
                        </li>
                    </ul>

</div>
</div>
</nav>
</div>
            </div>
        </div>

    </div>


    <div class ="sidebar-contact">
    <button type="button" class ="btn btn-skyblue" data-bs-toggle="modal" data-bs-target="#exampleModal">
  <i class ="fa fa-envelope"></i> &nbsp; Get Quote
</button>
</div>
<!--Modal-->

<div class ="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class ="modal-dialog">
    <div class ="modal-content">
      <div class ="modal-header">
        <h5 class ="modal-title" id="exampleModalLabel">Inquiry Form</h5>
        <button type="button" class ="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class ="modal-body">
       <form class ="contact-box dzForm p-a30 border-1" action="">
                    <div class ="dzFormMsg m-b20"></div>
                    <input type="hidden" value="Contact" name="dzToDo">
                    <div class ="row">
                    <div class ="col-lg-12 col-md-12">
                            <div class ="form-group mb-4">
                                <div class ="input-group">
                                    <input name="Name" type="text" required="" class ="form-control" placeholder="Name">
                                </div>
                            </div>
                        </div>
                        <div class ="col-lg-6 col-md-6">
                            <div class ="form-group mb-4">
                                <div class ="input-group">
                                    <input name="text" type="text" required="" class ="form-control" placeholder="Phone">
                                </div>
                            </div>
                        </div>
                        <div class ="col-lg-6 col-md-6">
                            <div class ="form-group mb-4">
                                <div class ="input-group">
                                    <input name="E-mail" type="email" class ="form-control" required="" placeholder="E-mail">
                                </div>
                            </div>
                        </div>
                        <div class ="col-lg-6 col-md-6">
                            <div class ="form-group mb-4">
                                <div class ="input-group">
                                    <input name="text" type="text" required="" class ="form-control" placeholder="Project Type">
                                </div>
                            </div>
                        </div>
                        <div class ="col-lg-6 col-md-6">
                            <div class ="form-group mb-4">
                                <div class ="input-group">
                                    <input name="budget" type="text" required="" class ="form-control" placeholder="Your Budget">
                                </div>
                            </div>
                        </div>
                        <div class ="col-lg-12 col-md-12">
                            <div class ="form-group mb-4">
                                <div class ="input-group">
                                    <textarea class ="form-control" placeholder="Tell us about your project or idea" id="floatingTextarea2" style="height: 100px"></textarea>
                                </div>
                            </div>
                        </div>
                        <div class ="col-lg-12 col-md-12 text-end">
                            <div class ="contact_btn">
                                <button name="submit" type="submit" value="Submit" class ="btn btn-primary btn-lg">Send Inquiry</button>
                            </div>
                        </div>
                    </div>
                </form>
      </div>
      
    </div>
  </div>
</div>



`);
//    <script type="text/javascript">
//        document.querySelectorAll('.dropdown-toggle').forEach(item => {
//          item.addEventListener('click', event => {

//            if(event.target.classList.contains('dropdown-toggle')) {
//              event.target.classList.toggle('toggle-change');
//}
//else if(event.target.parentElement.classList.contains('dropdown-toggle')) {
//              event.target.parentElement.classList.toggle('toggle-change');
//}
//})
//});
//  </script>