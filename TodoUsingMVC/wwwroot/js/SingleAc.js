$(document).ready(function () {
    $("#loadDataBtn").click(function () {
        $.ajax({
            url: '@Url.Action("GetData", "Home")',
            type: 'GET',
            success: function (response) {
                $("#result").html('<h1 style="background-color:green">Name:' + response.name + ', Age: ' + response.age+'</h1>');
            },
            error: function (error) {
                console.error("Error fetching data", error);
            }
        });
    });
});