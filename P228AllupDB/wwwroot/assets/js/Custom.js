$(document).ready(() => {
    $(".searchBtn").click(() => {
        let searchInput = $(".searchInput").val();
        let searchCategory = $(".searchCategory option:selected").val();


        if (searchInput.length >= 0) {

            fetch('/shop/search/' + searchCategory + '?search=' + searchInput)
                .then(response => {
                    return response.text();
                })
                .then(data => {
                    $("#searchList").html(data);
                })
            
            
        }
    })
    $(".searchInput").keyup(function () {
        let inputVal = $(this).val();

        if (inputVal.length <= 0)
        {
            $("#searchList").html('');
        }
    })
})