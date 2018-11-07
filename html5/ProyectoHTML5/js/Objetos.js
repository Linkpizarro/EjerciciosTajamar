function EvaluarString() {
    var cadena = 'VISUAL STUDIO .net';
    var res = document.getElementById('res');
    res.innerHTML += "<ul>";
    res.innerHTML += "<li>Length: " + cadena.length + "</li>";
    res.innerHTML += "<li>LowerCase: " + cadena.toLocaleLowerCase() + "</li>";
    res.innerHTML += "<li>UpperCase: " + cadena.toLocaleUpperCase() + "</li>";
    res.innerHTML += "<li>IndexOf(S): " + cadena.indexOf('S') + "</li>";
    res.innerHTML += "<li>CharAt(5): " + cadena.charAt(5) + "</li>";
    res.innerHTML += "<li>Replace(A to @): " + cadena.replace('A', '@') + "</li>";
    res.innerHTML += "<li>SubStr(2,3): " + cadena.substr(2, 3) + "</li>";
    res.innerHTML += "<li>SubStr: " + cadena.substr(6) + "</li>";
    res.innerHTML += "<li>Strike: " + cadena.strike() + "</li>";
}