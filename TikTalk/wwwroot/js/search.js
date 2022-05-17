$(function () {

    $('form').submit(function(e) {
        e.preventDefault();
        const q = $('#search').val(); // getting the searched value
        $('tbody').load('/Articles/Search2?query='+q); // filtering
    })
});