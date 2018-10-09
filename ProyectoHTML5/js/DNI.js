function Calcular(){
	var letras="TRWAGMYFPDXBNJZSQVHLCKE";
	var numero= parseInt(document.getElementById('dni').value);
	var calculador;
	var flag=0;
	while(flag==0){
        if (!isNaN(numero) && numero>=100000 && numero<=99999999){
			calculador=numero%23;
			document.getElementById('res').innerHTML='La letra de su DNI es la '+letras.charAt(calculador);
			flag++;
		}else{
            document.getElementById('res').innerHTML = "Por favor,introduzca un número válido";
            flag++;
		}
	}
}
