// Check if there is a section to scroll to
const scrollToSectionWhenRequired = () => {

    setTimeout(() => {

        const scrollToSection = sessionStorage.getItem('scrollToSection');

        if (!scrollToSection || window.location.pathname !== '/')
            return;

        // Scroll to the specified section
        document.querySelector(scrollToSection).scrollIntoView({
            behavior: 'smooth'
        });

        // Clear the sessionStorage
        sessionStorage.removeItem('scrollToSection');
    }, 100);
};

// When DOM Content is ready
$.when(
    $.ready
).done(function (data) { // Document is ready.

    "use strict";

    scrollToSectionWhenRequired();

    // jQuery counterUp
    $('[data-toggle="counter-up"]').counterUp({
        delay: 10,
        time: 2000
    });


});

$.when(
    $.ready
).done(function (data) {
    // Modal Video
    var $videoSrc;
    $('.btn-play').on('click', function () {
        $videoSrc = $(this).data("src");
    });

    $('#videoModal').on('shown.bs.modal', function (e) {
        $("#video").attr('src', $videoSrc + "?autoplay=1&amp;modestbranding=1&amp;showinfo=0");
    })

    $('#videoModal').on('hide.bs.modal', function (e) {
        $("#video").attr('src', $videoSrc);
    })

    // Function to pause the YouTube video
    function pauseVideo() {
        var iframe = document.getElementById('ytplayer');
        iframe.contentWindow.postMessage('{"event":"command","func":"pauseVideo","args":""}', '*');
        console.log('Modal closed');
    }

    // Add event listener to detect when the modal is closed
    $('#videoModal').on('hidden.bs.modal', function () {
        pauseVideo(); // Call the pauseVideo function when the modal is closed
    });
});


$.when(
    $.ready
).done(function (data) {
    // Dropdown on mouse hover
    function toggleNavbarMethod() {
        if ($(window).width() > 992) {
            $('.navbar .dropdown').on('mouseover', function () {
                $('.dropdown-toggle', this).trigger('click');
            }).on('mouseout', function () {
                $('.dropdown-toggle', this).trigger('click').blur();
            });
        } else {
            $('.navbar .dropdown').off('mouseover').off('mouseout');
        }
    }
    toggleNavbarMethod();
    $(window).resize(toggleNavbarMethod);
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

    $('#user-sign-out').on("click", function (event) {
        event.preventDefault(); // Prevent the default action of the link

        // Submit the form when the link is clicked
        $(this).closest('form').trigger("submit");
    });

    // Hide the usr-menu-dropdown when scrolled or hovered out of it.
    /*$(window).on('scroll', function () {
        $('.usr-menu-dropdown').dropdown('hide');
    });*/
});

$.when(
    $.ready
).done(function (data) { // Document is ready.
    "use strict";

    /*$('#loginForm').on('submit', function (event) {
        event.preventDefault(); // Prevent the default form submission
        console.log("loginForm:", $(this).serialize());
        $.ajax({
            url: $(this).attr('action'),
            method: 'POST',
            data: $(this).serialize(),
            success: function (data) {
                if (data.success) {
                    window.location.href = data.redirectUrl; // Redirect on successful login
                } else {
                    if (data.errors) {
                        $('#email-validation').text(data.errors.find(function (error) {
                            return error.includes("Email");
                        }) || "");
 
                        $('#password-validation').text(data.errors.find(function (error) {
                            return error.includes("Password");
                        }) || "");
 
                        $('#login-validation').text(data.errors.find(function (error) {
                            return error.includes('');
                        }) || "");
                    }
                }
            },
            error: function (xhr, status, error) {
                console.error('There was a problem with the AJAX request:', error);
            }
        });
    });*/

    /*$('#loginModal').on('show.bs.modal', function (e) {
        $('#email').val('');
        $('#password').val('');
        $('#rememberMe').prop('checked', false);
        $('#email-validation').text('');
        $('#password-validation').text('');
        $('#login-validation').text('');
    });*/



    //$('#user-sign-in').on('click', function () {
    //    $('#loginModal').modal('show');
    //});

    /*$('.user-access').on('click', function () {
        $('.usr-menu-dropdown').attr('aria-labelledby', $(this).attr('id'));
        $('.dropdown-toggle').dropdown('toggle');
    });*/

    //$('#top-bar-user-access').on('click', function () {
    //    var $dropdownMenu = $($(this).data('target'));
    //    $('.user-access').toggle();
    //});
});

$.when(
    $.ready
).done(function (data) {

    "use strict";

    // Clear validation messages when input fields are edited
    $('#name, #emailaddress, #mobilephoneno, #subject, #content').on('input', function () {
        var inputId = $(this).attr('id');
        $('#' + inputId + '-validation').text('');
        $('#login-validation').text('');
    });

    $('#contactForm').on('submit', function (event) {

        event.preventDefault(); // Prevent the default form submission

        var token = $('input[name="LADON-CSRF-FIELD"]').val();

        const formData = {
            name: $('#name').val(),
            emailaddress: $('#emailaddress').val(),
            mobilephoneno: $('#mobilephoneno').val(),
            subject: $('#subject').val(),
            contentText: $('#content').val(),
            siteMessageSource: 0
        };

        $.ajax({
            url: 'api/SiteVisitor/SendMessage', //$(this).attr('action'),
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(formData),
            dataType: 'json',
            beforeSend: function (xhr) {
                xhr.setRequestHeader('X-CSRF-TOKEN', token);
            },
            success: function (response) {
                if (response.success) {
                    $('#contactForm')[0].reset(); // Clear the form
                    $('#messageOK').modal('show');
                } else {
                    // Display validation errors
                    if (response.errors && response.errors.length > 0) {
                        var errorList = '<ul>';
                        response.errors.forEach(function (error) {
                            errorList += '<li>' + error + '</li>';
                        });
                        errorList += '</ul>';
                        $('.validation-summary-errors').html(errorList).show(); // Show the validation summary
                    }
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {

                // Clear previous validation messages
                //$('#name-validation').text("");
                //$('#emailaddress-validation').text("");
                //$('#subject-validation').text("");
                //$('#content-validation').text("");
                $("[id$='-validation']").text("");

                // Display validation errors
                const errorResponse = jqXHR.responseJSON;

                for (const [field, errors] of Object.entries(errorResponse.errors)) {
                    if (field.includes("Name")) {
                        $('#name-validation').text(errors.join(", "));
                    }
                    if (field.includes("EmailAddress")) {
                        $('#emailaddress-validation').text(errors.join(", "));
                    }
                    if (field.includes("Subject")) {
                        $('#subject-validation').text(errors.join(", "));
                    }
                    if (field.includes("Content")) {
                        $('#content-validation').text(errors.join(", "));
                    }
                }
                /*errorData.errors.forEach(function (error) {
                    if (error.includes("Name")) {
                        $('#name-validation').text(error);
                    }
                    if (error.includes("EmailAddress")) {
                        $('#emailaddress-validation').text(error);
                    }
                    if (error.includes("Subject")) {
                        $('#subject-validation').text(error);
                    }
                    if (error.includes("Content")) {
                        $('#content-validation').text(error);
                    }
                });*/
            }
        });

    });
});

$.when(
    $.ready
).done(function (data) {

    "use strict";

    $('#get-quote').on('click', function (event) {
        event.preventDefault();
        window.location.href = '/quoterequest';
    });

    $('.carousel-options a:contains("Get A Quote")').on('click', function (event) {
        event.preventDefault();
        window.location.href = '/quoterequest';
    });
});

$.when(
    $.ready
).done(function (data) {

    "use strict";

    $('.owl-carousel').on('click', '.owl-item .blog-item .blog-title > span', function (e) {
        e.preventDefault();
        var href = $(this).siblings('a').attr('href');
        if (href) {
            window.location.href = href;
        }
    });
});