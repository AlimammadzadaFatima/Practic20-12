$(function () {
    $(document).on("click", ".modal", function () {
        console.log("dsgds");
        let id = $(this).attr("data-id");
        fetch(`/home/getcourse/${id}`)
            //.then(response => response.json())
            .then(response => response.text())
            .then(data => {

                console.log(data)
             /*   $("#detailModal .modal-content").html(data)*/
                $("#exampleModal").find(".product-title").text(data.name)
            })



        $("#exampleModal").modal("show")
    })
})