$.when(
    $.ready
).done(function (data) {

    "use strict";

    var shareUrl = window.location.href;
    var shareText = 'Check out this article!';
    var encodedShareUrl = encodeURIComponent(shareUrl);
    var encodedShareText = encodeURIComponent(shareText);

    if (navigator.share) {
        var shareButton = '<button class="btn btn-share hover-red"><i class="fas fa-share" aria-hidden="true"><span>Share</span></i></button>';
        $('.interaction-buttons').each(function () {
            $(this).append(shareButton);
        });
    }
    $(document).on('click', '.btn-share .fas.fa-share', function () {
        if (navigator.share) {
            navigator.share({
                title: document.title,
                text: 'Check out this article!',
                url: window.location.href
            }).then(() => {
                console.log('Thanks for sharing!');
            }).catch(console.error);
        }
    });

    $(document).on('click', '.btn-share .fab.fa-facebook-f', function () {
        var facebookShare = 'https://www.facebook.com/sharer/sharer.php?u=' + encodedShareUrl;
        window.open(facebookShare, '_blank', 'width=600,height=400');
    });

    $(document).on('click', '.btn-share .fa-brands.fa-twitter', function () {
        var twitterShare = 'https://twitter.com/intent/tweet?url=' + encodedShareUrl + '&text=' + encodedShareText;
        window.open(twitterShare, '_blank', 'width=600,height=400');
    });

    $(document).on('click', '.btn-share .fa-brands.fa-linkedin', function () {
        var linkedInShare = 'https://www.linkedin.com/sharing/share-offsite/?url=' + encodedShareUrl;
        window.open(linkedInShare, '_blank', 'width=600,height=400');
    });

    $('.btn-like').on('click', function (e) {
        e.preventDefault();
        var asyncCall = $('#like-form').attr('async-call');
        var data = $('#like-form').serialize();

        $.ajax({
            type: "POST",
            url: asyncCall,
            data: data,
            success: function (response) {
                if (response.success) {
                    var reactionLbl = "Like";
                    if (response.likes > 1)
                        reactionLbl = "Likes";
                    $('.interaction-buttons .btn-like span').text(`${response.likes} ${reactionLbl}`);
                } else {
                    alert(response.reason);
                }
            },
            error: function (xhr, status, error) {
                console.error("XHR: ", xhr);
                console.error("Status: ", status);
                console.error("Error: ", error);
                alert('Error while liking the article.');
            }
        });
    });

    $('.btn-heart').on('click', function (e) {
        e.preventDefault();
        var asyncCall = $('#heart-form').attr('async-call');
        var data = $('#heart-form').serialize();

        $.ajax({
            type: "POST",
            url: asyncCall,
            data: data,
            success: function (response) {
                if (response.success) {
                    var reactionLbl = "Heart";
                    if (response.hearts > 1)
                        reactionLbl = "Hearts";
                    $('.interaction-buttons .btn-heart span').text(`${response.hearts} ${reactionLbl}`);
                } else {
                    alert(response.reason);
                }
            },
            error: function (xhr, status, error) {
                console.error("XHR: ", xhr);
                console.error("Status: ", status);
                console.error("Error: ", error);
                alert('Error while liking the article.');
            }
        });
    });
});