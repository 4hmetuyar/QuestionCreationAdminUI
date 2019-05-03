/*! components-inputs.js | Bulkit | CSS Ninja */

/* ==========================================================================
special inputs JS file
========================================================================== */

$(document).ready(function($) {
    
    "use strict";

    //Basic autocomplete
    if ($('#basic-autocpl').length) {
        var options = {
            url: "assets/js/easyAutocomplete/data/persons.json",
            getValue: function(element) {
                return element.name;
            },
            highlightPhrase: false,
            list: {
                maxNumberOfElements: 5,
                showAnimation: {
                    type: "fade", //normal|slide|fade
                    time: 400,
                    callback: function() {}
                },
                match: {
                    enabled: true
                }
            },
        };

        $("#basic-autocpl").easyAutocomplete(options);
    }

    //Description autocomplete
    if ($('#desc-autocpl').length) {
        var options = {
            url: "assets/js/easyAutocomplete/data/persons.json",
            getValue: function(element) {
                return element.name;
            },
            template: {
                type: "description",
                fields: {
                    description: "position"
                }
            },
            highlightPhrase: false,
            list: {
                maxNumberOfElements: 5,
                showAnimation: {
                    type: "fade", //normal|slide|fade
                    time: 400,
                    callback: function() {}
                },
                match: {
                    enabled: true
                }
            },
        };

        $("#desc-autocpl").easyAutocomplete(options);
    }

    //Users autocomplete
    if ($('#users-autocpl').length) {
        var usersOptions = {
            url: "assets/js/easyAutocomplete/data/persons.json",
            getValue: "name",
            template: {
                type: "custom",
                method: function(value, item) {
                    return "<div class=" + 'template-wrapper' + "><img class=" + 'autocpl-avatar' + " src='" + item.pic + "' /><div class=" + 'entry-text' + ">" + value + "<br><span>" + item.email + "</span></div></div> ";
                }
            },
            highlightPhrase: false,
            list: {
                maxNumberOfElements: 3,
                showAnimation: {
                    type: "fade", //normal|slide|fade
                    time: 400,
                    callback: function() {}
                },
                match: {
                    enabled: true
                }
            },
        };

        $("#users-autocpl").easyAutocomplete(usersOptions);
    }

    //datepicker init
    $('[data-toggle="datepicker"]').datepicker();

    //wickedpicker 12 hours init
    $('.timepicker-12').wickedpicker();

    //wickedpicker 24 hours init
    $('.timepicker-24').wickedpicker({
        twentyFour: true,
        timeSeparator: ':'
    });

    //Bubble range input
    if ($('#input-range').length) {

        var input = $('#input-range');

        input.bind('input', function(){
            getRangeValue(input);
        }).bind('change', function(){
            getRangeValue(input);	/* for IE */
        });

        function getRangeValue(e){
            var value = $(e).val();
            $('.value').text(value);
            $('.range').attr('data-value', value);
            input.attr('value', value);
        }

    }
    //Tags input initialization
    if ($('.tag-input').length) {
        $('.tag-input').jQueryInputTags({
            maxTotalSize: 255,
            maxTagSize: 10,
            minTagSize: 3,
            chars: /[,:]/,
            keycode: /(^9$|^13$|^32)/, // Tab, Enter, Space
            separator: ',',
            sensitive: false,
            clearSpaces: true

        });
    }

});


