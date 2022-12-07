$(document).ready(() => {

    $(".addtobasket").click(function (e) {
        e.preventDefault();

        let url = $(this).attr("href");

        fetch(url)
            .then(res => {
                if (res.ok) {
                    alert("Add Olundu");
                } else if (res.status == 404) {
                    alert(res.statusText);
                } else if (res.status == 400) {
                    alert(res.statusText);
                }
            })
    })

    $(".productModalBtn").click(function (e) {
        e.preventDefault();

        let url = $(this).attr("href");

        fetch(url)
            .then(res => {
                return res.text();
            })
            .then(data => {
                $(".modal .modal-dialog .modal-content .modal-body").html(data);
                $(".modal").show();
                //===== slick Slider Product Quick View

                $('.quick-view-image').slick({
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    arrows: false,
                    dots: false,
                    fade: true,
                    asNavFor: '.quick-view-thumb',
                    speed: 400,
                });

                $('.quick-view-thumb').slick({
                    slidesToShow: 4,
                    slidesToScroll: 1,
                    asNavFor: '.quick-view-image',
                    dots: false,
                    arrows: false,
                    focusOnSelect: true,
                    speed: 400,
                });
            })
    })

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