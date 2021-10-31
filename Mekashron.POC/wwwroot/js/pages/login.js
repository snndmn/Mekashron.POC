var login = (function () {

    $(document).on('click', '#submitBtn', function (e) {
        e.preventDefault();

        var username = $('#username').val();
        var password = $('#password').val();

        if (username.length == 0 || password.length == 0) {
            ToastrManager.showMessage(ToastrType.WARNING, Constants.WarningMessages.valuesCannotBeEmpty);
            return;
        }

        $.ajax({
            url: '/authorization/signin',
            type: 'POST',
            data: { username: username, password: password },
            success: function (response) {
                console.log(response);
                var mesageType = (response.hasError) ? ToastrType.ERROR : ToastrType.SUCCESS;
                ToastrManager.showMessage(mesageType, response.ResultMessage);
            },
            error: function (error) {
                ToastrManager.showMessage(ToastrType.ERROR, error);
            }
        });

    });

})();