jQuery(window).on('load', function() {
    $('.main_loader').fadeOut(2000)
});
if ($('.banner_carousel').length) {
    $('.banner_carousel').owlCarousel({
        loop: !0,
        margin: 0,
        nav: !0,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        active: !0,
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
    })
}
if ($('.testimonial_carousel').length) {
    $('.testimonial_carousel').owlCarousel({
        loop: !0,
        margin: 0,
        nav: !0,
        dots: !1,
        animateOut: '',
        animateIn: '',
        active: !0,
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
    })
}
if ($('.client_carousel').length) {
    $('.client_carousel').owlCarousel({
        loop: !0,
        dots: !0,
        margin: 0,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        active: !0,
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
    })
}
if ($('.softdevslider').length) {
    $('.softdevslider').owlCarousel({
        loop: !0,
        dots: !0,
        margin: 0,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        active: !0,
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
    })
}
$(window).scroll(function() {
    var height = $(window).scrollTop();
    if (height > 100) {
        $(".top_header").css({
            "position": "sticky",
            "transition": "1s",
            "background": "#fff",
            "top": "0",
            "transition-timing-function": "linear"
        })
    } else {
        $(".top_header").css({
            "position": "relative",
            "transition": "3s",
            "transition-timing-function": "linear"
        })
    }
});
$(window).scroll(function() {
    if ($(this).scrollTop() > 200) {
        $('#gotop').show()
    } else {
        $('#gotop').hide()
    }
});
$('#gotop').click(function() {
    $('html, body').animate({
        scrollTop: 0
    }, 'slow');
    return !1
});
$(window).scroll(function() {
    var windowScroll = $(window).scrollTop();
    var height = $(document).height() - $(window).height();
    var scrolled = (windowScroll / height) * 100;
    $('#scrollBar').css('width', scrolled + '%')
})