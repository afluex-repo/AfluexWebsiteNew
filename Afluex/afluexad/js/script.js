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

// portfolio _slider
$('.portfolio_slider').slick({
    dots: true,
    infinite: true,
    speed: 300,
    slidesToShow: 1,
    slidesToScroll: 1,
    arrows: true,
    autoplay: true,
    autoplaySpeed: 2000,
    prevArrow: '<button class="slide-arrowl prev-arrow"><i class="fas fa-long-arrow-alt-left"></i></button>',
    nextArrow: '<button class="slide-arrowr next-arrow"><i class="fas fa-long-arrow-alt-right"></i></button>',
    mobileFirst: true,
    responsive: [{
    breakpoint: 1024,
    settings: {
        slidesToShow: 4,
        slidesToScroll: 1,
        centerMode: false
    }
}]
});



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

// portfolio
$(document).ready(function() {

    var itemSelector = '.grid-item';

    var $container = $('#portfolio_con').isotope({
        itemSelector: itemSelector,
        masonry: {
            columnWidth: itemSelector,
            isFitWidth: true
        }
    });

    //Ascending order
    var responsiveIsotope = [
        [480, 7],
        [720, 10]
    ];

    var itemsPerPageDefault = 12;
    var itemsPerPage = defineItemsPerPage();
    var currentNumberPages = 1;
    var currentPage = 1;
    var currentFilter = '*';
    var filterAtribute = 'data-filter';
    var pageAtribute = 'data-page';
    var pagerClass = 'isotope-pager';

    function changeFilter(selector) {
        $container.isotope({
            filter: selector
        });
    }


    function goToPage(n) {
        currentPage = n;

        var selector = itemSelector;
        selector += (currentFilter != '*') ? '[' + filterAtribute + '="' + currentFilter + '"]' : '';
        selector += '[' + pageAtribute + '="' + currentPage + '"]';

        changeFilter(selector);
    }

    function defineItemsPerPage() {
        var pages = itemsPerPageDefault;

        for (var i = 0; i < responsiveIsotope.length; i++) {
            if ($(window).width() <= responsiveIsotope[i][0]) {
                pages = responsiveIsotope[i][1];
                break;
            }



        }

        return pages;
    }

    function setPagination() {

        var SettingsPagesOnItems = function() {

            var itemsLength = $container.children(itemSelector).length;

            var pages = Math.ceil(itemsLength / itemsPerPage);
            var item = 1;
            var page = 1;
            var selector = itemSelector;
            selector += (currentFilter != '*') ? '[' + filterAtribute + '="' + currentFilter + '"]' : '';

            $container.children(selector).each(function() {
                if (item > itemsPerPage) {
                    page++;
                    item = 1;
                }
                $(this).attr(pageAtribute, page);
                item++;
            });

            currentNumberPages = page;

        }();

        var CreatePagers = function() {

            var $isotopePager = ($('.' + pagerClass).length == 0) ? $('<div class="' + pagerClass + '"></div>') : $('.' + pagerClass);

            $isotopePager.html('');

            for (var i = 0; i < currentNumberPages; i++) {
                var $pager = $('<a href="javascript:void(0);" class="pager" ' + pageAtribute + '="' + (i + 1) + '"></a>');
                $pager.html(i + 1);

                $pager.click(function() {
                    var page = $(this).eq(0).attr(pageAtribute);
                    goToPage(page);
                });

                $pager.appendTo($isotopePager);
            }

            $container.after($isotopePager);

        }();

    }

    setPagination();
    goToPage(1);

    //Adicionando Event de Click para as categorias
    $('.filters a').click(function() {
        var filter = $(this).attr(filterAtribute);
        currentFilter = filter;

        setPagination();
        goToPage(1);


    });

    //Evento Responsivo
    $(window).resize(function() {
        itemsPerPage = defineItemsPerPage();
        setPagination();
    });



});



$(document).ready(function() {

    // filter items on button click
    $('.filter-button-group').on('click', 'li', function() {
        var filterValue = $(this).attr('data-filter');
        $('.grid').isotope({ filter: filterValue });
        $('.filter-button-group li').removeClass('active');
        $(this).addClass('active');
    });
})


$(document).ready(function() {

    // filter items on button click
    $('.isotope-pager').on('click', 'a', function() {
        var filterValue = $(this).attr('data-page');

        $('.isotope-pager a').removeClass('active');
        $(this).addClass('active');
    });
})


$(document).ready(function() {
    $('.popupimg').magnificPopup({
        type: 'image',
        mainClass: 'mfp-with-zoom',
        gallery: {
            enabled: true
        },

        zoom: {
            enabled: true,

            duration: 300, // duration of the effect, in milliseconds
            easing: 'ease-in-out', // CSS transition easing function

            opener: function(openerElement) {

                return openerElement.is('img') ? openerElement : openerElement.find('img');
            }
        }

    });

});

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

//portfolio
$(function() {
    var selected = "";
    $(".gallery-filter").click(function() {
        $(".gallery-filter").removeClass("gallery-filter-active");
        $(this).addClass("gallery-filter-active");
        selected = $(this).attr("data-filter");

        if (selected == "all") {
            setTimeout(function() {
                $("#portfolio .portfolio-item").show();
                $("#portfolio").fadeTo(300, 1);
            }, 300);
        }

        $("#portfolio").fadeTo(100, 0.1);

        $("#portfolio .portfolio-item").not("[data-portfolio='" + selected + "']").hide();

        setTimeout(function() {
            $("[data-portfolio='" + selected + "']").show();
            $("#portfolio").fadeTo(300, 1);
        }, 300);

    });
});