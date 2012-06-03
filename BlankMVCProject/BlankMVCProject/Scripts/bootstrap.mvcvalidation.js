$(document).ready(function() {
    $('form').addTriggersToJqueryValidate().triggerElementValidationsOnFormValidation();
    $('input').elementValidation(function (element, result) {
        var el = $(element);
        if (el.hasClass('input-validation-error')) {
            el.parents('div.control-group').addClass('error');
        } else {
            el.parents('div.control-group').removeClass('error');
        }
    });
}); 
