var contenido = document.getElementsByTagName('table')[0].getElementsByTagName('tbody')[0];
var tr = contenido.getElementsByTagName('tr');
var pantalla = document.getElementById('pantalla');
var num1='';
var num2 = '';
var signo = '';
for (i = 1; i < contenido.childElementCount; i++) {
    var celda = tr[i].getElementsByTagName('td');
    for (j = 0; j < tr[i].childElementCount; j++){
        var boton = celda[j].getElementsByTagName('button')[0];
        boton.addEventListener('click', function () {
            if (!isNaN(parseInt(this.value))) {
                pantalla.value += this.value;
            } else {
                switch (this.value) {
                    case 'c': borrar(pantalla); break;
                    case '/': dividir(pantalla, signo, num1, this.value); break;
                    case '*': multiplicar(pantalla, signo, num1, this.value); break;
                    case '-': restar(pantalla, signo, num1, this.value); break;
                    case '+': sumar(pantalla,signo,num1,this.value); break;
                    case '.': decimal(); break;
                    case 'enter': operar(pantalla,signo,num1,num2); break;
                }
            }
        });
    }
}
function borrar(pantalla) {
    pantalla.value = '';
}

function sumar(pantalla, signo, num1, valor) {
    if (num1!='') {
        signo = valor;
        pantalla.value = '';
    } else {
        num1 = pantalla.value;
        signo = valor;
        pantalla.value = '';
    }
}

function operar(pantalla, signo, num1, num2) {
    if (num1 != '') {
         num2=pantalla.value;
        if (signo == '+') {
            if (num2 != '') {
                pantalla.value = (parseInt(num1) + parseInt(num2));
            } else {
                pantalla.value = (num1);
            }
        }
    }
}

