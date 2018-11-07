var Pelicula = function (titulo, descripcion, poster, tituloOriginal, escenas) {
    this.titulo = titulo;
    this.descripcion = descripcion;
    this.poster = poster;
    this.tituloOriginal = tituloOriginal;
    this.escenas = escenas;

    this.getEscenas = function () {
        var Escenas = new Array();   
        $.get({
            "method": "GET",
            "url": "http://apipeliculas.azurewebsites.net/api/EscenasPelis/Regreso",
            "success": function (response) {          
                $.each($(response).find('Escena'), function () {
                    Escenas.push([
                        $(this).find('TituloEscena').text(),
                        $(this).find('DescripcionEscena').text(),
                        $(this).find('ImagenEscena').text()
                    ]);
                });
            }
        });
        this.escenas = Escenas;
    }

    this.Mostrar = function () {
        var tabla = $('<table>');
        var tit = $('<tr>').append($('<td>').attr('colspan', '2').append($('<h1>').text(this.titulo + ' (' + this.tituloOriginal + ')'))); 
        var descImg = $('<tr>').append([
            $('<td>').text(this.descripcion),
            $('<td>').append($('<img>').attr('src', this.poster)),

        ]);
        if (this.escenas != null) {
            var esc = $('<tr>').append($('<td>').attr('colspan', '2').append($('<button>').attr('id', 'mostrarEscenas').text('Mostrar Escenas')));
            tabla.append([tit, descImg, esc]);
        } else {
            tabla.append([tit, descImg]);
        }
       
        return tabla;
    }

    this.MostrarEscenas = function () {
        var tabla = $('<table>');
        $.each(this.escenas, function () {
            tabla.append([
                $('<tr>').append($('<td>').attr('colspan', '2').append($('<h1>').text(this[0]))),
                $('<tr>').append([
                    $('<td>').text(this[1]),
                    $('<td>').append($('<img>').attr('src', this[2]))
                ])
            ]);
        });
        return tabla;
    }

}