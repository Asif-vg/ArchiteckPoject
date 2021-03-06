
$(document).ready(function() {


    //Video 
    $('.video-play-btn').magnificPopup({
        disabledOn: 320,
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        fixedContentPos: false
    });
    $.extend(true, $.magnificPopup.defaults, {
        iframe: {
            patterns: {
                youtube: {
                    index: 'youtube.com/',
                    id: 'v=',
                    src: 'http://www.youtube.com/embed/%id%?autoplay=1'
                }
            }
        }
    });
    //Video End
    AOS.init({
        duration: 500,
        easing: 'ease-in-out',

    });

    //Client-Carousel
    $('.said-body').owlCarousel({
        items: 2,
        margin: 20,
        loop: true,
        responsiveClass: true,
        autoplay: true,
        autoplayTimeout: 3000,
        autoplayHoverPause: true,
        responsive: {
            0: {
                items: 1,
            },
            600: {
                items: 1,
            },
            1000: {
                items: 2,
            },
        }

    });
    //Client-Carousel End

    //Project-Carousel 
    $('.project-body').owlCarousel({
        items: 4,
        margin: 30,
        loop: true,
        responsiveClass: true,
        autoplay: true,
        autoplayTimeout: 4000,
        autoplayHoverPause: true,
        responsive: {

            0: {
                items: 1,
            },
            768: {
                items: 2,
            },
            1200: {
                items: 4,
            }
        }

    });
    //Project-Carousel End

    //Team-Carousel 
    $('.persons').owlCarousel({
        items: 4,
        margin: 30,
        loop: true,
        responsiveClass: true,
        autoplay: true,
        autoplayTimeout: 4000,
        autoplayHoverPause: true,
        responsive: {
            0: {
                items: 1,
            },
            768: {
                items: 2,
            },
            1199: {
                items: 4,
            },
        }

    });
    //Team-Carousel End

    //Sponsor-Carousel 
    $('.client-items').owlCarousel({
        items: 6,
        margin: 10,
        loop: true,
        responsiveClass: true,
        autoplay: true,
        autoplayTimeout: 4000,
        autoplayHoverPause: true,
        responsive: {
            0: {
                items: 1,
            },
            1020: {
                items: 3,
            },
            1199: {
                items: 6,
            },
        }

    });
    //Sponsor-Carousel End

    $('.custom-slider').owlCarousel({
        items: 1,
        // margin: 10,
        loop: true,
        responsiveClass: true,
        autoplay: true,
        autoplayTimeout: 4000,
        responsive: {
            0: {
                items: 1,
            },
            600: {
                items: 1,
            },
            1000: {
                items: 1,
            },
        }

    });


    //GoUpBtn
    let goUpbtn = $(".circle")[0];

    var offset = 400;
    var duration = 300;
    if (goUpbtn != null || goUpbtn != undefined) {
        $(window).scroll(function() {
            if ($(this).scrollTop() > offset) {
                $('.circle')[0].style.bottom = "30px";
            } else {
                $('.circle')[0].style.bottom = "-50px";
            }
        });

        $('.circle').click(function(event) {
            event.preventDefault();
            $('html, body').animate({ scrollTop: 0 }, duration);
            return false;
        })
    }
    //GoUpBtn End


    let isEmailTrue = function isEmail(email) {
        return /^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))$/i.test(email);
    }

    $("#messageSend").click(function (e) {
        e.preventDefault();
        let nm = $("#name11").val().toString();
        let eml = $("#email11").val().toString();
        let sbj = $("#subject11").val().toString();
        let msg = $("#message11").val();

        console.log(msg)

        if (isEmailTrue(eml) && nm != "" && sbj != "", msg != "") {


            $.ajax({
                url: "/Contact/Message",
                type: "get",
                dataType: "json",
                data: {
                    nm: nm,
                    eml: eml,
                    sbj: sbj,
                    txt: msg
                },
                success: function (response) {
                    if (response.success) {
                        console.log("success")
                        swal("Good job!", "Your message has been delivered to the other party", "success")
                        
                    }
                },
                error: function (error) {
                    console.log(error);
                },
                complete: function () {

                }

            })


        }
        else {
            swal("Error", "Please fill in the required information", "error")
            console.log("datalari doldur")
        }


        console.log($(this), nm, msg, sbj,eml)

        

    })

});
//Search
let search = document.querySelector(".header-search");
let box = document.querySelector(".search-box");
let xSearch = document.querySelector(".x-search");
let loopSearch = document.querySelector(".loop-search");
let activeBox = document.querySelector(".active-box");

if (search != null || search != undefined) {
    search.addEventListener("click", function(e) {
        e.preventDefault();

        box.classList.toggle("active-box");
        if (box.matches(".active-box")) {
            loopSearch.style.fontSize = "0";
            xSearch.style.fontSize = "20px";
        } else {
            xSearch.style.fontSize = "0";
            loopSearch.style.fontSize = "20px";
        }
    });
}
//Search End
//Navbar
let customNav = document.querySelector(".custom-navs");
let topHeader = document.querySelector(".top-header");
let logo = document.querySelector(".logo");




let li = document.querySelectorAll(".accordion ul li");
let accordionShow = () => {
    for (let i = 0; i < li.length; i++) {
        li[i].addEventListener("click", (e) => {
            e.preventDefault();
            if (li[i].classList.contains("show")) {
                li[i].classList.remove("show");

            } else {
                for (let a = 0; a < li.length; a++) {
                    li[a].classList.remove("show");

                }
                li[i].classList.add("show");

            }

            console.log(li[i].lastElementChild);
        });
    }
};
accordionShow();


window.addEventListener("scroll", () => {
        if (window.pageYOffset > 200) {
            customNav.style.position = "fixed";
            customNav.style.right = "0";
            customNav.style.left = "0";
            customNav.style.zIndex = "999"
            customNav.classList.add("active");
            topHeader.style.display = "none";
            logo.style.padding = "6px 30px"

        } else {
            customNav.style.position = "relative";
            customNav.style.transition = "all 0.3s linear";
            topHeader.style.display = "block";
            logo.style.padding = "28px 30px"
            customNav.classList.remove("active");

        }
    })
    //Navbar end

let resLines = document.querySelector(".res-menu-bar-lines");
let linedMenu = document.querySelector(".nav-menu-ul");
let spansForLined = document.querySelector(".res-menu-bar-lines");

resLines.addEventListener("click", function(e) {
    linedMenu.classList.toggle("active-nav-menu-ul");

})


let preloader = document.querySelector(".page-loader");

window.addEventListener("load", function() {
    preloader.style.display = "none";
})


let reply = document.querySelectorAll(".reply");
let replyMessage = document.querySelectorAll(".replyDisplay");
let cancelReply = document.querySelector(".cancelReply");

for (let i = 0; i < reply.length; i++) {
    reply[i].addEventListener("click", (e) => {
        e.preventDefault();
        replyMessage[i].classList.toggle("showcomment");
    });
}



