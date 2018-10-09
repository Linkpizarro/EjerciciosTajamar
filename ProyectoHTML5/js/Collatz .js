function Mostrar() {
    var num = parseInt(document.getElementById('num').value);
    document.getElementById('res').innerHTML = '';
    if (!isNaN(num) && num > 0) {
        document.getElementById('res').style.color = 'black'
        while (num != 1) {

            if (num % 2 == 0) {
                num = num / 2;   
            }
            else {
                num = (num * 3) + 1;          
            }
            document.getElementById('res').innerHTML += num + ', ';
        }
    } else {
        document.getElementById('res').style.color = 'red';
        document.getElementById('res').innerHTML = 'El número no es válido!';
    }
}
