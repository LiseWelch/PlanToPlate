
 $('#AddItem').submit(function () {
    $.ajax({
        type: "POST",
        url: 'recipe/add/item',
        data: $(this).serialize(),
        success: function (response) {
            $('#ItemList').html(response);
            $('#ItemList').dialog('open');
        }
    })
})