var login = (function () {

    $(document).on('click', '#submitBtn', function (e) {
        e.preventDefault();

        var username = $('#username').val();
        var password = $('#password').val();

        $.ajax({
            url: '/authorization/signin',
            type: 'POST',
            data: { username: username, password: password },
            success: function (response) {
                console.log(response);
            },
            error: function (error) {
                console.log(error);
            }
        });
    });

})();