$(function () {

    $('form').submit(function (e) {

        e.preventDefault();

        // get the searched value
        const q = $('#search').val();

        // create json of filtered results
        var r = await fetch('/Articles/Search3?query=' + q);
        var d = await r.jason();

        // show filtered results
        const template = $('#template').html();
        let results = '';
        for (var item in d) {
            let row = template;
            for (var key in d[item]) {
                row = row.replaceAll('{' + key + '}', d[item][key]);
            }
            results += row;
        }
        $('tbody').html(results);
    });
});