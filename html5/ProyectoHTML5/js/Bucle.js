for (i = 0; i < 15; i++) {
    document.getElementsByTagName('section')[0].innerHTML += '<br> ';
    for (j = 0-i; j < i+1; j++) {
        document.getElementsByTagName('section')[0].innerHTML += '*';
    }
}
