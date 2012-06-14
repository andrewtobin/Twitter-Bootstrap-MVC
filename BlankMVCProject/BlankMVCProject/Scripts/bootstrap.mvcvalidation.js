$(function () {
    $('form').addTriggersToJqueryValidate().triggerElementValidationsOnFormValidation();
    $('input[data-val]').elementValidation(function (element, result) {
        var el = $(element);
        if (!result)
            el.parents('div.control-group').addClass('error');
        else
            el.parents('div.control-group').removeClass('error');
    });
});