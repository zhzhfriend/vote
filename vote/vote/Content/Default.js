$(document).ready(function () {
    $('.btnVote').click(function () {
        $.post('vote.aspx', 'productId=' + $(this).attr('productId'), function (data) {
            if (data == 'success')
                alert('投票成功');
            else
                alert(data);
        });
    });
});

