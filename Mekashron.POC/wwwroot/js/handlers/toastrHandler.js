var ToastrManager = (function () {

    toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-top-right",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "3000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    };

    function showMessage(toastType, message) {
       
        switch (toastType) {
            case ToastrType.ERROR:
                toastr.error(message);
                break;
            case ToastrType.INFO:
                toastr.info(message);
                break;
            case ToastrType.SUCCESS:
                toastr.success(message);
                break;
            case ToastrType.WARNING:
                toastr.warning(message);
                break;
            default:
        }
    }

    return {
        showMessage: showMessage
    };

})();