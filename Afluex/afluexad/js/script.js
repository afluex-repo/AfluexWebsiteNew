jQuery(window).on("load", (function() {
    $(".main_loader").fadeOut(2e3)
})), $(".banner_carousel").length && $(".banner_carousel").owlCarousel({
    loop: !0,
    margin: 0,
    nav: !0,
    animateOut: "fadeOut",
    animateIn: "fadeIn",
    active: !0,
    smartSpeed: 500,
    autoplay: 6e3,
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
}), $(".portfolio_slider").slick({
    dots: !0,
    infinite: !0,
    speed: 300,
    slidesToShow: 1,
    slidesToScroll: 1,
    arrows: !0,
    autoplay: !0,
    autoplaySpeed: 2e3,
    prevArrow: '<button class="slide-arrowl prev-arrow"><i class="fas fa-long-arrow-alt-left"></i></button>',
    nextArrow: '<button class="slide-arrowr next-arrow"><i class="fas fa-long-arrow-alt-right"></i></button>',
    mobileFirst: !0,
    responsive: [{
        breakpoint: 1024,
        settings: {
            slidesToShow: 4,
            slidesToScroll: 1,
            centerMode: !1
        }
    }]
}), $(".testimonial_carousel").length && $(".testimonial_carousel").owlCarousel({
    loop: !0,
    margin: 0,
    nav: !0,
    dots: !1,
    animateOut: "",
    animateIn: "",
    active: !0,
    smartSpeed: 1e3,
    items: 2,
    autoplay: 6e3,
    navText: ['<span><i class="fa fa-chevron-left" aria-hidden="true"></i></span>', '<span><i class="fa fa-chevron-right" aria-hidden="true"></i></span>'],
    responsive: {
        0: {
            items: 1
        },
        600: {
            items: 1
        },
        800: {
            items: 2
        },
        1024: {
            items: 2
        }
    }
}), $(".client_carousel").length && $(".client_carousel").owlCarousel({
    loop: !0,
    dots: !0,
    margin: 0,
    animateOut: "fadeOut",
    animateIn: "fadeIn",
    active: !0,
    smartSpeed: 1e3,
    autoplay: 6e3,
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
}), $(document).ready((function() {
    var t = ".grid-item",
        o = $("#portfolio_con").isotope({
            itemSelector: t,
            masonry: {
                columnWidth: t,
                isFitWidth: !0
            }
        }),
        e = [
            [480, 7],
            [720, 10]
        ],
        a = d(),
        i = 1,
        r = "*",
        n = "data-filter",
        l = "data-page",
        s = "isotope-pager";

    function c(e) {
        var a = t;
        a += "*" != r ? '[data-filter="' + r + '"]' : "",
            function(t) {
                o.isotope({
                    filter: t
                })
            }(a += '[data-page="' + e + '"]')
    }

    function d() {
        for (var t = 12, o = 0; o < e.length; o++)
            if ($(window).width() <= e[o][0]) {
                t = e[o][1];
                break
            } return t
    }

    function f() {
        var e, n, d, f;
        e = o.children(t).length, Math.ceil(e / a), n = 1, d = 1, f = t, f += "*" != r ? '[data-filter="' + r + '"]' : "", o.children(f).each((function() {
                n > a && (d++, n = 1), $(this).attr(l, d), n++
            })), i = d,
            function() {
                var t = 0 == $("." + s).length ? $('<div class="isotope-pager"></div>') : $("." + s);
                t.html("");
                for (var e = 0; e < i; e++) {
                    var a = $('<a href="javascript:void(0);" class="pager" data-page="' + (e + 1) + '"></a>');
                    a.html(e + 1), a.click((function() {
                        c($(this).eq(0).attr(l))
                    })), a.appendTo(t)
                }
                o.after(t)
            }()
    }
    f(), c(1), $(".filters a").click((function() {
        var t = $(this).attr(n);
        r = t, f(), c(1)
    })), $(window).resize((function() {
        a = d(), f()
    }))
})), $(document).ready((function() {
    $(".filter-button-group").on("click", "li", (function() {
        var t = $(this).attr("data-filter");
        $(".grid").isotope({
            filter: t
        }), $(".filter-button-group li").removeClass("active"), $(this).addClass("active")
    }))
})), $(document).ready((function() {
    $(".isotope-pager").on("click", "a", (function() {
        $(this).attr("data-page");
        $(".isotope-pager a").removeClass("active"), $(this).addClass("active")
    }))
})), $(document).ready((function() {
    $(".popupimg").magnificPopup({
        type: "image",
        mainClass: "mfp-with-zoom",
        gallery: {
            enabled: !0
        },
        zoom: {
            enabled: !0,
            duration: 300,
            easing: "ease-in-out",
            opener: function(t) {
                return t.is("img") ? t : t.find("img")
            }
        }
    })
})), $(window).scroll((function() {
    $(window).scrollTop() > 100 ? $(".top_header").css({
        position: "fixed"
    }) : $(".top_header").css({
        position: "relative"
    })
})), $(window).scroll((function() {
    $(this).scrollTop() > 200 ? $("#gotop").show() : $("#gotop").hide()
})), $("#gotop").click((function() {
    return $("html, body").animate({
        scrollTop: 0
    }, "slow"), !1
})), $(window).scroll((function() {
    var t = $(window).scrollTop() / ($(document).height() - $(window).height()) * 100;
    $("#scrollBar").css("width", t + "%")
})), $((function() {
    var t = "";
    $(".gallery-filter").click((function() {
        $(".gallery-filter").removeClass("gallery-filter-active"), $(this).addClass("gallery-filter-active"), "all" == (t = $(this).attr("data-filter")) && setTimeout((function() {
            $("#portfolio .portfolio-item").show(), $("#portfolio").fadeTo(300, 1)
        }), 300), $("#portfolio").fadeTo(100, .1), $("#portfolio .portfolio-item").not("[data-portfolio='" + t + "']").hide(), setTimeout((function() {
            $("[data-portfolio='" + t + "']").show(), $("#portfolio").fadeTo(300, 1)
        }), 300)
    }))
}));