$(document).ready(function () {
    $('#calcNarcisista').click(function () {
        var worker = new Worker("js/workerNarcisista.js");
        worker.postMessage({ num : $('#num').val() });
        worker.onmessage = function (e) {
            $('#res').html(e.data);
        };
    });
    
});