//Script from Details
$(document).ready(function () {
    var $input = $('div.rating'), count = Object.keys($input).length;
    if (count > 0) {
        $input.rating();
    };
});

//Script from Layout
$(document).ready(function () {
    $('.carousel').carousel({
        interval: 5000 //changes the speed
    });


    //Script from New

    $(document).ready(function () {
        $.validator.methods.date = function (value, element) {
            return this.optional(element) || $.datepicker.parseDate('dd/mm/yy', value);
        };
        $("#DateOfCreate").datepicker({
            dateFormat: 'dd/mm/yy',
            showOn: "both",
            buttonImage: "//mricons.com/store/png/118235_35805_32_calendar_month_view_icon.png",
            buttonImageOnly: true,
            selectOtherMonths: true,
            showWeek: true,
            buttonText: "Select date",
            firstDay: 1
        });
        $(".datepicker").datepicker("setDate", new Date())
    });



    jQuery(document).ready(function () {
        $('.rb-rating').rating({ 'showCaption': true, 'stars': '5', 'min': '0', 'max': '5', 'step': '1', 'size': 'xs' });
        $('#input-id').rating('update', 3);
    });

    $(document).ready(function () {
        $(":file").filestyle({ buttonname: "btn-primary" });
    });
});


$('#formDelete').submit(function () {
    var $form = $(this);
    swal({
        title: "Are you sure?",
        text: "You will not be able to recover this story!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: '#D9534F',
        confirmButtonText: 'Yes, delete it!',
        closeOnConfirm: false,
        allowOutsideClick: true
    },
    function (isConfirm) {
        if (isConfirm) {
            var id = $form.data("id");
            $.ajax({
                url: "/Story/Delete/" + id,
                type: "POST"
            })
            .success(function () {
                swal({
                    title: "Deleted!",
                    text: "Your story has been deleted.",
                    showCancelButton: false,
                    type: "success"
                }, function () {
                    window.location = "/";
                });
            })
            .error(function (arg1, arg2) {

            });
        }
    });

    return false;
});
