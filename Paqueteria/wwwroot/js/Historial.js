$(document).ready(function () {
    $('#historial').DataTable();

    
});

function eliminarHistorial() {

    var opcion = confirm("¿Está seguro que desea eliminar su historial de pedidos?")
    if (opcion == true) {
        $.ajax({
            url: "https://localhost:44384/Home/eliminarHistorial",
            type: "DELETE",
            crossDomain: true,
            success: function (result) {
                alert("Historial eliminado correctamente");
                location.reload();
            },
            error: function (xhr, status, error) {
                alert(error);
                alert("status " + status);
                alert("error " + error);
            }
        });
    } else {
        alert("Operacion cancelada");
    }

    
}

