$(document).ready(function () {
    $('.btnVote').click(function () {
        $("#dialog-modal").dialog({
            height: 100,
            width: 350,
            modal: true
        });
        $("#dialog-modal").data('productId', $(this).attr('productId'));
    });

    $('#btnSubmit').click(function () {
        $.post('vote.aspx', 'productId=' + $("#dialog-modal").data('productId') + "&randomCode=" + $('#txtRandomCode').val(), function (data) {
            data = data + '';
            if (data == 'success') {
                alert('投票成功');
                document.location.reload();
            }
            else
                alert(data);
        })
    });
});



