$(function () {

    $('form').submit(function (e) {

        e.preventDefault();

        const q = $('#search').val(); // getting the searched value

        var r = await fetch('/Articles/Search3?query=' + q);
        //$('tbody').load('/Articles/Search3?query='+q); // filtering
        var d = await r.jason();
        Console.log(d); //todo delete


        const template = $('#template').html();
        let results = '';
        for (var item in d) {
            let row = template;
            for (var key in d[item]) {
                Console.log('{' + key + '}', d[item][key]); //todo delete
                row = row.replaceAll('{' + key + '}', d[item][key]);
            }
            results += row;
        }
        $('tbody').html(results);
    });
});