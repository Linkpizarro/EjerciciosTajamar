self.onmessage =  function (e) {
    var num = e.data.num;
    var numeros = num.split('');
    var res = 0;
    for (var i = 0; i < numeros.length; i++) {
        res = res + Math.pow(parseInt(numeros[i]), numeros.length);
    }
    if (res == parseInt(num)) {
        postMessage('Es narcisista');
    } else {
        postMessage('No es narcisista');
    }
}

