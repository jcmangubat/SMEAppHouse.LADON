// handle the click event and perform smooth scrolling or redirection
const handleAnchorClick = (e) => {
    e.preventDefault();

    var hrefAttrib = e.target.getAttribute('href');

    if (hrefAttrib === "#")
        return;

    if (e.target.hasAttribute('no-handle')) {
        window.location.href = hrefAttrib;
        return;
    }

    if (window.location.pathname === '/') {
        var targetElement = document.querySelector(hrefAttrib);
        if (!targetElement) return;
        targetElement.scrollIntoView({
            behavior: 'smooth'
        });
    } else {
        // Store the target section in sessionStorage
        sessionStorage.setItem('scrollToSection', hrefAttrib);
        // Redirect to the root URL
        window.location.href = '/';
    }
}

// when DOM content is ready
$.when(
    $.ready
).done(function () {

    "use strict";

    // Initiate the wowjs
    new WOW().init();

    // Add event listeners for 'nav-link' anchor tags
    $('a.nav-link').on('click', handleAnchorClick);

    // Add event listeners for 'dropdown-item' elements
    $('.other-site-features a.dropdown-item').on('click', handleAnchorClick);

    // Back to top button
    $(window).on('scroll', function () {
        if ($(this).scrollTop() > 200) {
            $('.back-to-top').fadeIn('slow');
        } else {
            $('.back-to-top').fadeOut('slow');
        }
    });

    $('#goto-home').on('click', function (event) {
        $('html, body').animate({ scrollTop: 0 }, 1500, 'easeInOutExpo');
        return false;
    });

    $('#mini-lcs-logo').on('click', function () {
        $('html, body').animate({ scrollTop: 0 }, 1500, 'easeInOutExpo');
        return false;
    });

    $('.back-to-top').on('click', function () {
        $('html, body').animate({ scrollTop: 0 }, 1500, 'easeInOutExpo');
        return false;
    });

    // Sticky Navbar
    $(window).on('scroll', function () {
        if ($(this).scrollTop() > 90) {
            $('.nav-bar').addClass('nav-sticky');
            $('.nav-bar-logo').fadeIn('slow');
            $('.carousel, .page-header').css("margin-top", "73px");
        } else {
            $('.nav-bar').removeClass('nav-sticky');
            $('.nav-bar-logo').css('display', 'none');
            $('.carousel, .page-header').css("margin-top", "0");
        }
    });

    $('[data-toggle="tooltip"]').tooltip();
});

/* 
Scripts involving operations inside the user panel 
*/
$.when(
    $.ready
).done(function (data) { // Document is ready.
    "use strict";

    //$('#user-sign-out').on('click', function () {
    //    // Send an AJAX request to the server to logout
    //    $.ajax({
    //        url: '/Account/Logout', // URL of the logout action method
    //        method: 'POST', // Use POST method to send the request
    //        success: function (data) {
    //            // Redirect to the home page after successful logout
    //            window.location.href = '/';
    //        },
    //        error: function (xhr, status, error) {
    //            // Handle error if logout request fails
    //            console.error('Error occurred while signing out:', error);
    //        }
    //    });
    //});

    /*$('#user-sign-out').on("click", function (event) {
        event.preventDefault(); // Prevent the default action of the link

        // Submit the form when the link is clicked
        $(this).closest('form').trigger("submit");
    });*/

    // Hide the usr-menu-dropdown when scrolled or hovered out of it.
    /*$(window).on('scroll', function () {
        $('.usr-menu-dropdown').dropdown('hide');
    });*/
});