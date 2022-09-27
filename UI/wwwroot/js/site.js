// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$.extend($.fn.bootstrapTable.defaults, $.fn.bootstrapTable.locales['tr-TR'])



$(document).ready(function () {
    setTimeout(function () {
        $("div.loading").fadeOut("slow", function () {
            $("div.loading").hide();
        });
    }, 500);
});

//Bootsrapt table oluşturma metotu
function Veri_Listele(_url, id) {
    var table = $(`#${id}`);
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        async: false,
        success: function (liste) {
            table.bootstrapTable('load', liste);
            table.bootstrapTable({ data: liste });
        },
        error: function (err) {
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.reload();
                }
            });
            console.log(err);
        }
    });
};
function Veri_Ekle(_url, id, _data = null) {
    var frm = $('#' + id);
    if (_data == null) {
        _data = JSON.stringify(frm.serializeJSON());
    }
    $.ajax({
        url: _url,
        method: 'POST',
        data: _data,
        async: false,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (result) {
            Swal.fire(
                'Veriler Eklendi!',
                'Verileriniz başarı ile eklenmiştir!',
                'success'
            ).then((result) => {
                if (result.isConfirmed) {
                    window.location.reload();
                }
            });
        },
        error: function (err) {
            console.log(err);
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            }).then((result) => {
                if (result.isConfirmed) {
                }
            });
        }
    });
};
function Veri_Sil(_url, nesne) {
    var _data = JSON.stringify(nesne);
    $.ajax({
        url: _url,
        method: 'DELETE',
        dataType: 'json',
        data: _data,
        async: false,
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
            Swal.fire(
                'Veriler Silindi!',
                'Veriler Başarıyla Silindi!',
                'success'
            ).then((result) => {
                if (result.isConfirmed) {
                    window.location.reload();
                }
            });
        },
        error: function (err) {
            console.log(err);
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            });
        }
    });
};