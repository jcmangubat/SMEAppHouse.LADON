function formatWithCommas(input) {
    let value = input.value;
    if (value) {
        // Remove existing commas
        value = value.replace(/,/g, '');
        // Add commas for thousands
        value = parseFloat(value).toLocaleString('en-US');
        input.value = value;
    }
}

function removeCommas(input) {
    let value = input.value;
    if (value) {
        // Remove commas
        input.value = value.replace(/,/g, '');
    }
}

const acceptFloatNumbersOnly = function () {
    // Remove non-numeric characters except decimal point
    $(this).val($(this).val().replace(/[^0-9.]/g, ''));

    // Prevent more than one decimal point
    if ($(this).val().split('.').length > 2) {
        var parts = $(this).val().split('.');
        $(this).val(parts[0] + '.' + parts.slice(1).join(''));
    }
}

$.when(
    $.ready
).done(function (data) {
    "use strict";

    var ignoreSiteAddressValuesChanges = false;
    var originalSiteAddressValues = {
        siteAddress: $('#SiteAddress').val(),
        siteCity: $('#SiteCity').val(),
        siteRegion: $('#SiteStateOrRegion').val(),
        siteCountry: $('#SiteCountry').val(),
        siteZipCode: $('#SiteZipCode').val()
    };

    $('#section-siteAddressSameAsResidential').hide();
    $("main").addClass("parallax");
    $("#get-quote").remove();

    $('#desiredStartDate').datepicker({
        format: 'yyyy-mm-dd', // specify the format you want
        autoclose: true,
        todayHighlight: true
    });

    $('#desiredEndDate').datepicker({
        format: 'yyyy-mm-dd', // specify the format you want
        autoclose: true,
        todayHighlight: true
    });

    $('#SquareArea').on('input', acceptFloatNumbersOnly);
    $('#SpecificBudgetAmount').on('input', acceptFloatNumbersOnly);
    $('#MinimumBudgetAmount').on('input', acceptFloatNumbersOnly);
    $('#MaximumBudgetAmount').on('input', acceptFloatNumbersOnly);

    $('#ServiceCategory').on('change', function () {
        const selectedCategory = $(this).val();
        const serviceCodeSelect = $('#ServiceCode');

        if (selectedCategory) {
            $.ajax({
                url: '/quoterequest',
                type: 'get',
                data: { handler: 'ServiceCodes', category: selectedCategory },
                success: function (data) {
                    serviceCodeSelect.empty();
                    serviceCodeSelect.append($('<option>', {
                        value: '',
                        text: 'Please select the type of service for this category'
                    }));
                    serviceCodeSelect.append($('<optgroup>', {
                        label: '------------------------'
                    }));

                    var filteredData = data.filter((item) => item.description.toLowerCase() !== 'other' && item.description.toLowerCase() !== 'others');
                    $.each(filteredData, function (index, item) {
                        serviceCodeSelect.append($('<option>', {
                            value: item.value,
                            text: item.description
                        }));
                    });

                    // Add separator for the last option
                    serviceCodeSelect.append($('<optgroup>', {
                        label: '------------------------'
                    }));

                    var filteredDataOther = data.filter((item) => item.description.toLowerCase() === 'other' || item.description.toLowerCase() === 'others')[0];
                    if (filteredDataOther) {
                        serviceCodeSelect.append($('<option>', {
                            value: filteredDataOther.value,
                            text: filteredDataOther.description
                        }));
                    }
                    else {
                        serviceCodeSelect.append($('<option>', {
                            value: data.length,
                            text: 'Other'
                        }));
                    }
                },
                error: function (xhr, status, error) {
                    console.error('Error fetching service codes:', error);
                }
            });
        } else {
            serviceCodeSelect.empty();
        }
    });

    $('label[for="QuoteRequest_SiteAddressSameAsResidential"]').on('click', function () {
        var checkbox = $('#SiteAddressSameAsResidential');
        checkbox.prop('checked', !checkbox.prop('checked')).trigger('change');
    });

    $('#Address, #City, #Region, #Country, #ZipCode').on('input change', function () {
        var address = $('#Address').val().trim();
        var city = $('#City').val().trim();
        var region = $('#StateOrRegion').val().trim();
        var country = $('#CountryCode').val().trim();
        var zipCode = $('#ZipCode').val().trim();
        if (address && city && region && country && zipCode) {
            $('#section-SiteAddressSameAsResidential').show();
        } else {
            $('#section-siteAddressSameAsResidential').hide();
        }
    });


    $('#SiteAddress').on('input change', function () {
        if (ignoreSiteAddressValuesChanges)
            return;
        originalSiteAddressValues.siteAddress = $('#SiteAddress').val();
    });

    $('#SiteCity').on('input change', function () {
        if (ignoreSiteAddressValuesChanges)
            return;
        originalSiteAddressValues.siteCity = $('#SiteCity').val();
    });

    $('#SiteStateOrRegion').on('input change', function () {
        if (ignoreSiteAddressValuesChanges)
            return;
        originalSiteAddressValues.siteRegion = $('#SiteRegion').val();
    });

    $('#SiteCountryCode').on('input change', function () {
        if (ignoreSiteAddressValuesChanges)
            return;
        originalSiteAddressValues.siteCountry = $('#SiteCountryCode').val();
    });
    $('#SiteZipCode').on('input change', function () {
        if (ignoreSiteAddressValuesChanges)
            return;
        originalSiteAddressValues.siteZipCode = $('#SiteZipCode').val();
    });

    $('#SiteAddressSameAsResidential').on('change', function () {
        if ($(this).is(':checked')) {
            // Copy values from residential to site address
            ignoreSiteAddressValuesChanges = true;
            $('#SiteAddress').val($('#Address').val());
            $('#SiteCity').val($('#City').val());
            $('#SiteStateOrRegion').val($('#StateOrRegion').val());
            $('#SiteCountryCode').val($('#CountryCode').val());
            $('#SiteZipCode').val($('#ZipCode').val());
            ignoreSiteAddressValuesChanges = false;
        } else {
            // Restore original site address values
            $('#SiteAddress').val(originalSiteAddressValues.siteAddress);
            $('#SiteCity').val(originalSiteAddressValues.siteCity);
            $('#SiteStateOrRegion').val(originalSiteAddressValues.siteRegion);
            $('#SiteCountryCode').val(originalSiteAddressValues.siteCountry);
            $('#SiteZipCode').val(originalSiteAddressValues.siteZipCode);
        }
    });

    $('#quoterqst-messageOK').on('hidden.bs.modal', function (e) {
        window.location.href = '/';
    });

    $("#SiteAddress, #DurationMonths").on("input", function () {
        var inputId = $(this).attr('id');
        $('#' + inputId + '-validation').text('');
    });

});

$.when(
    $.ready
).done(function (data) {
    "use strict";

    $('#form-submit').on("click", function (event) {
        event.preventDefault(); // Prevent the default action of the link

        // Submit the form when the link is clicked
        $('#quoteRequestForm').trigger("submit");
    });

    $('#quoteRequestForm').on('submit', function (event) {
        event.preventDefault(); // Prevent the default form submission

        var formData = new FormData(this);

        //// Append files to FormData
        //var files = $('#_attach-files')[0].files; // Assuming your file input field has an id of "fileInput"
        //for (var i = 0; i < files.length; i++) {
        //    formData.append('formFiles', files[i]);
        //}

        // Show the loading indicator
        $('#loadingIndicator').show();

        var token = $('input[name="LADON-CSRF-FIELD"]').val();

        $.ajax({

            url: $(this).attr('action'), // Get the form action attribute
            method: $(this).attr('method'), // Get the form method attribute
            data: formData, // Use FormData object instead of serialized data
            contentType: false, // Set contentType to false, FormData will automatically set it
            processData: false, // Set processData to false, FormData will automatically set it
            beforeSend: function (xhr) {
                xhr.setRequestHeader('X-CSRF-TOKEN', token);
            },
            success: function (response) {
                // Check if the response indicates success
                if (response.success) {
                    $('#quoterqst-messageOK').modal('show');
                } else {

                    // Display validation errors

                    let firstErrorElement = null;

                    if (response.errors) {

                        // Clear previous validation messages
                        $("[id$='-validation']").text("");

                        var errorList = '<ul>';

                        for (let field in response.errors) {
                            if (response.errors.hasOwnProperty(field)) {
                                var errors = response.errors[field];
                                const fieldElement = $(`[name="QuoteRequest.${field}"]`);

                                if ($(`#${field}-validation`).length)
                                    $(`#${field}-validation`).text(errors);

                                if (fieldElement.siblings(`#${field}-validation`).length > 0) 
                                    fieldElement.siblings(`#${field}-validation`).text(errors);

                                // Check if this is the first error element and store the field element
                                if (!firstErrorElement && fieldElement.length > 0) {
                                    firstErrorElement = fieldElement;
                                }
                            }
                        }

                        if (errorList.includes('<li>')) {
                            $('.validation-summary-errors').html(errorList).show(); // Show the validation summary

                            // If there is no specific field error element, set the firstErrorElement to the summary
                            if (!firstErrorElement) {
                                firstErrorElement = $('.validation-summary-errors');
                            }
                        }

                        // Scroll to the first visible validation error field
                        if (firstErrorElement) {
                            $('html, body').animate({
                                scrollTop: firstErrorElement.offset().top - 180 // Adjust the offset as needed
                            }, 500); // 500 milliseconds for smooth scroll
                        }
                    }
                }
            },
/*            error: function (jqXHR, textStatus, errorThrown) {
                console.error("quoteRequestForm Ajax request failed:");
                console.error("Status: " + textStatus);
                console.error("Error: " + errorThrown);
                console.error("Response Text: " + jqXHR.responseText);
                console.error("Response Headers: " + jqXHR.getAllResponseHeaders());
                console.log('An error occurred: ' + textStatus + '\nError Thrown: ' + errorThrown);   
            },*/
            complete: function () {
                // Hide the loading indicator
                $('#loadingIndicator').hide();
            }
        });
    });
});

$.when(
    $.ready
).done(function (data) {
    "use strict";

    let selectedFiles = [];

    $('#browse-files').on('click', function (event) {
        event.preventDefault();
        $('#_attach-files').trigger('click');
    });

    $('#_attach-files').on('change', function (event) {
        selectedFiles = Array.from(event.target.files); // Update selectedFiles array
        updatePreview();
        updateFileLabel(); // Update the label text
    });

    function updatePreview() {
        $('.gallery-box-container').empty(); // Clear the preview area
        $.each(selectedFiles, function (index, file) {
            if (file.type.match('image.*')) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('.gallery-box-container').append('<a href="" class="gallery-box">' +
                        '<span class="gallery-box__img-container">' +
                        '<img src="' + e.target.result + '" alt="' + file.name + '" class="gallery-box__img">' +
                        '</span>' +
                        '<span class="gallery-box__text-wrapper">' +
                        '<span class="gallery-box__text gallery-box__filename"><marquee>' + file.name + '</marquee></span>' +
                        '<span class="gallery-box__text" style="font-weight: bold;">' + (file.size / 1024).toFixed(2) + ' KB</span>' +
                        '</span>' +
                        '</a>');
                }
                reader.readAsDataURL(file);
            } else {
                $('.gallery-box-container').append(
                    '<div>' +
                    '<p>' + file.name + '</p>' +
                    '<div class="file-info">' + file.name + ' (' + (file.size / 1024).toFixed(2) + ' KB)</div>' +
                    '<button class="remove-btn" data-index="' + index + '">&times;</button>' +
                    '</div>'
                );
            }
        });
    }

    $(document).on('click', '.remove-btn', function () {
        var index = $(this).data('index');
        selectedFiles.splice(index, 1); // Remove the selected file from the array
        updatePreview(); // Update the preview area
        updateFileInput(); // Update the file input to reflect changes
        updateFileLabel(); // Update the label text
    });

    function updateFileInput() {
        var dataTransfer = new DataTransfer();
        selectedFiles.forEach(file => {
            dataTransfer.items.add(file);
        });
        $('#files')[0].files = dataTransfer.files;
        // Trigger a change event to update the file input display
        $('#files').trigger('change');
    }

    function updateFileLabel() {
        var fileNames = selectedFiles.map(file => file.name).join(', ');
        $('.custom-file-label').text(fileNames || 'Choose files');
    }

    var $popup = $('<div id="popup"></div>');
    var $image = $("<img>");
    $popup.append($image);
    $("body").append($popup);

    // Capture click event on link
    $(".gallery-box").on('click', function (event) {
        event.preventDefault();
        var href = $(".gallery-box .gallery-box__img").attr("href");

        //Set src as href from link clicked
        $image.attr("src", href);
        $popup.show();
    });

    //Hide popup when clicked
    $popup.on('click', function () {
        $popup.hide();
    });

});