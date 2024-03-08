
$(document).ready(function () {
   
    var eachUserTR="";

    $.ajax({
        type:"GET",
        url:"/User/MyUserlistJsonResult",
        dataType:'json',
        success: function (data) {
            $.each(data, function (i, user) {
                eachUserTR += "<tr>" +
                    "<td>" + user.name + "</td>" +
                    "<td>" + user.age + "</td>" +
                    "<td>" + user.email + "</td>" +
                    "<td>" + user.password + "</td>" +
                    "</tr>"
            });
            $("#AjaxUsersTable tbody").append(eachUserTR);
        },

        error: function (errorData) {
            var errorJson = jQuery.parseJSON(errorData.responseText);
            alert("Message:" +errorJson.Message);
        }

    });
});
