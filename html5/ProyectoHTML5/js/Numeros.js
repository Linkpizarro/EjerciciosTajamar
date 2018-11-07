//Función ortopédica:
function Mostrar() {
    var num1 = parseInt(document.getElementById('num1').value);
    var num2 = parseInt(document.getElementById('num2').value);
    var num3 = parseInt(document.getElementById('num3').value);
    var mayor=0;
    var menor=0;
    var intermedio=0;

    if (!isNaN(num1) && !isNaN(num2) && !isNaN(num3)) {

        if (num1 > num2 && num1 > num3 && num2>num3) {
            mayor = num1;
            menor = num3;
            intermedio = num2;
        } else if (num1 > num2 && num1 > num3 && num2 < num3) {
            mayor = num1;
            menor = num2;
            intermedio = num3;
        } else if (num2 > num1 && num2 > num3 && num1 > num3) {
            mayor = num2;
            menor = num1;
            intermedio = num3;
        } else if (num2 > num1 && num2 > num3 && num1 < num3) {
            mayor = num2;
            menor = num3;
            intermedio = num1;
        } else if (num3 > num1 && num3 > num2 && num2 > num1) {
            mayor = num3;
            menor = num1;
            intermedio = num2;

        } else if (num3 > num1 && num3 > num2 && num2 < num1) {
            mayor = num3;
            menor = num2;
            intermedio = num1;
        }

        document.getElementById('res').style.color = 'black';
        document.getElementById('res').innerHTML = 'Mayor:'+mayor+'<br>Menor:'+menor+'<br>Intermedio:'+intermedio;

    } else {
        document.getElementById('res').style.color = 'red';
        document.getElementById('res').innerHTML = 'Falta algún campo sin completar';
    }

}

//Función mas corrrecta:
function MostrarResultados() {
    var num1 = parseInt(document.getElementById('num1').value);
    var num2 = parseInt(document.getElementById('num2').value);
    var num3 = parseInt(document.getElementById('num3').value);
    var numeros = new Array(num1, num2, num3).sort(function (a, b) { return a - b });
    if (!isNaN(num1) && !isNaN(num2) && !isNaN(num3)) {
        if (num1 == num2 && num1 == num3) {
            document.getElementById('res').style.color = 'black';
            document.getElementById('res').style.fontSize = '30px';
            document.getElementById('res').innerHTML = '<br>¡Todos los números son iguales!';
        } else if (num1 == num2 || num1 == num3 || num2 == num3) {
            document.getElementById('res').style.color = 'black';
            document.getElementById('res').style.fontSize = '30px';
            document.getElementById('res').innerHTML = '<br>Mayor:' + numeros[2] + '<br>Menor:' + numeros[0];
        
        } else {
            document.getElementById('res').style.color = 'black';
            document.getElementById('res').style.fontSize = '30px';
            document.getElementById('res').innerHTML = '<br>Mayor:' + numeros[2] + '<br>Menor:' + numeros[0] + '<br>Intermedio:' + numeros[1];
        }
       

    } else {
        document.getElementById('res').style.color = 'red';
        document.getElementById('res').style.fontSize = '30px';

        document.getElementById('res').innerHTML = '<br>Falta algún campo sin completar';
    }
}