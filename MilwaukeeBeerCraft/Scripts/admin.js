
$(function () {
    $("#tabs").tabs();
});

$(document).on('focusin', function (e) {
    if ($(e.target).closest(".mce-window").length) {
        e.stopImmediatePropagation();
    }
});

tinymce.init({
    selector: '#mytextarea',
    plugins: ['autosave, code, image'],
    toolbar: 'restoredraft, code',
    skin: 'lightgray',
    theme: 'modern',
});


