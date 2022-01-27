// Preloader
jQuery(window).on('load', function() {
    $('.main_loader').fadeOut(2000);
});


// banner-carousel
if ($('.banner_carousel').length) {
    $('.banner_carousel').owlCarousel({
        loop: true,
        margin: 0,
        nav: true,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        active: true,
        smartSpeed: 500,
        autoplay: 6000,
        navText: ['<span class="flaticon-left-arrow"></span>', '<span class="flaticon-right-arrow"></span>'],
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            800: {
                items: 1
            },
            1024: {
                items: 1
            }
        }
    });
}

// testimonial-carousel
if ($('.testimonial_carousel').length) {
    $('.testimonial_carousel').owlCarousel({
        loop: true,
        margin: 0,
        nav: true,
        dots: false,
        animateOut: '',//fadeOut
        animateIn: '',//fadeIn
        active: true,
        smartSpeed: 1000,
        autoplay: 6000,
        navText: ['<span><i class="fa fa-chevron-left" aria-hidden="true"></i></span>', '<span><i class="fa fa-chevron-right" aria-hidden="true"></i></span>'],
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            800: {
                items: 1
            },
            1024: {
                items: 1
            }
        }
    });
}


// client-carousel
if ($('.client_carousel').length) {
    $('.client_carousel').owlCarousel({
        loop: true,
        dots: true,
        margin: 0,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        active: true,
        smartSpeed: 1000,
        autoplay: 6000,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            800: {
                items: 1
            },
            1024: {
                items: 7
            }
        }
    });
}


// client-carousel
if ($('.softdevslider').length) {
    $('.softdevslider').owlCarousel({
        loop: true,
        dots: true,
        margin: 0,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        active: true,
        smartSpeed: 1000,
        autoplay: 6000,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            800: {
                items: 1
            },
            1024: {
                items: 3
            }
        }
    });
}

// sticky-header

$(window).scroll(function() { // this will work when your window scrolled.
    var height = $(window).scrollTop(); //getting the scrolling height of window
    if (height > 100) {
        $(".top_header").css({ "position": "fixed" });
    } else {
        $(".top_header").css({ "position": "relative" });
    }
});

// go-top
$(window).scroll(function() {
    if ($(this).scrollTop() > 200) {
        $('#gotop').show();
    } else {
        $('#gotop').hide();
    }
});

// click event on gotop button
$('#gotop').click(function() {
    $('html, body').animate({
        scrollTop: 0
    }, 'slow');
    return false;
});

// horizontal scroll bar
$(window).scroll(function() {
    var windowScroll = $(window).scrollTop();
    var height = $(document).height() - $(window).height();
    var scrolled = (windowScroll / height) * 100;
    $('#scrollBar').css('width', scrolled + '%');
});

