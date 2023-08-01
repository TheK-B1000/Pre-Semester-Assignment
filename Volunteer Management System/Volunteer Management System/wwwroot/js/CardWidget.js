(function ($) {
    'use strict';

    var CardWidget = function (element, settings) {
        this.element = $(element);
        this.settings = settings;
    };

    CardWidget.prototype = {
        toggle: function () {
            this.element.slideToggle(this.settings.animationSpeed);
        },
        remove: function () {
            this.element.slideUp(this.settings.animationSpeed, function () {
                $(this).remove();
            });
        }
    };

    $.fn.cardWidget = function (option) {
        return this.each(function () {
            var $this = $(this);
            var data = $this.data('lte.cardwidget');
            var options = $.extend({}, $.fn.cardWidget.defaults, $this.data(), typeof option == 'object' && option);

            if (!data) {
                data = new CardWidget($this, options);
                $this.data('lte.cardwidget', data);
            }

            if (typeof option == 'string') {
                data[option]();
            }
        });
    };

    $.fn.cardWidget.defaults = {
        animationSpeed: 'normal'
    };

    $(document).on('click', '[data-card-widget]', function (event) {
        event.preventDefault();

        var button = $(this);
        var card = button.parents('.card').first();
        var action = button.data('card-widget');

        card.cardWidget(action);
    });
})(jQuery);
