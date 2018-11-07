var valor = document.getElementById('fecha');
var boton = document.getElementById('cal');
var resultado = document.getElementById('res');

function Mostrar() {    
    var valores = valor.value.split('-');
    var anio = parseInt(valores[0]);
    var mes = parseInt(valores[1]);
    var dia = parseInt(valores[2]);
    if (mes == 1) {
        mes = 13;
        anio = anio - 1;
    } else if (mes == 2) {
        mes = 14;
        anio = anio - 1;
    } else { }

    var op1 = Math.trunc(((mes + 1) * 3) / 5);

    var op2 = Math.trunc(anio / 4);
   
    var op3 = Math.trunc(anio / 100);
    
    var op4 = Math.trunc(anio / 400);
   
    var op5 = Math.trunc(dia + (mes * 2) + anio + op1 + op2 - op3 + op4 + 2);
   
    var op6 = Math.trunc(op5 / 7);
   
    var res = Math.trunc(op5 - (op6 * 7));
    switch (res) {
        case 0: resultado.innerHTML = 'Sábado'; break;
        case 1: resultado.innerHTML = 'Domingo'; break;
        case 2: resultado.innerHTML = 'Lunes'; break;
        case 3: resultado.innerHTML = 'Martes'; break;
        case 4: resultado.innerHTML = 'Miércoles'; break;
        case 5: resultado.innerHTML = 'Jueves'; break;
        case 6: resultado.innerHTML = 'Viernes'; break;
    }
}