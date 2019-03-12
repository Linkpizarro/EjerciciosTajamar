function cargarTablaDepartamentosAsync(callback) {
    var urlapi = "https://apidepartamentospgs.azurewebsites.net/api/Departamentos";
    $.ajax({
        url: urlapi
        , type: "GET"
        , success: function (data) {
            var html = "";
            $.each(data, function (ind, dept) {
                html += "<tr>";
                html += "<td>" + dept.Numero + "</td>";
                html += "<td>" + dept.Nombre + "</td>";
                html += "<td>" + dept.Localidad + "</td>";
                html += "</tr>";
            });
            callback(html);
        }
    });
}

function cargarJsonDepartamentosAsync(callback) {
    var urlapi = "https://apidepartamentospgs.azurewebsites.net/api/Departamentos";
    $.ajax({
        url: urlapi
        , type: "GET"
        , success: function (data) {
            callback(data);
        }
    });
}

function eliminarDepartamento(num, callback) {
    var urlapi =
        "https://apidepartamentospgs.azurewebsites.net/api/Departamentos/" + num;
    $.ajax({
        url: urlapi
        , type: "DELETE"
        , success: function () {
            callback();
        }
    });
}

