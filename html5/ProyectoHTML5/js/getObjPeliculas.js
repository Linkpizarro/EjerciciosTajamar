$(document).ready(function () {
    $.get({
        "method": "GET",
        "url": "http://apipeliculas.azurewebsites.net/api/peliculas",
        "success": function (response) {
            var peliculas = new Array();
            var select = $('<select>').attr('id', 'peliculas');
            select.append($('<option>').text('Seleccione una película'));
            $.each($(response).find('Pelicula'), function () {
                select.append($('<option>').text($(this).find('Titulo').text()));
                var pelicula = new Pelicula($(this).find('Titulo').text(), $(this).find('Descripcion').text(), $(this).find('Poster').text(), $(this).find('TituloOriginal').text(), null); 
                if (pelicula.titulo == 'Regreso al futuro') {
                    pelicula.getEscenas();
                } 
                peliculas.push(pelicula);
            });
            $('#videoclub').append(select);
            $('#videoclub #peliculas').change(function () {
                $('#videoclub table').remove();
                if ($(this)[0].selectedIndex != 0) {
                    $('#videoclub').append(peliculas[($(this)[0].selectedIndex) - 1].Mostrar());
                    $('#mostrarEscenas').click(function () {
                        $('#videoclub').append(peliculas[0].MostrarEscenas());
                    });
                }
            });
        }
    });
    
});