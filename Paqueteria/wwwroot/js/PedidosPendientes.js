

$(document).ready(function () {
    $('#pendientes').DataTable();
});

function cambiarEstatus(id, est) {

    var opcion = confirm("Esta seguro que desea actualizar el pedido seleccionado?");
    if (opcion == true) {
        $.ajax({
            url: "https://localhost:44384/Home/cambiarEstatus",
            type: "POST",
            contentType: "application/json; charset-utf-8",
            data: JSON.stringify({
                idpedido: id,
                estatus: est
            }),
            crossDomain: true,
            success: function (result) {
                alert("Pedido modificado exitosamente");
                location.reload();
            },
            error: function (xhr, status, error) {
                alert(xhr);
                alert("status " + status)
                alert("error " + error)
            }
        });
    } else {
        alert("Operaci[on cancelada");
    }


   
}



