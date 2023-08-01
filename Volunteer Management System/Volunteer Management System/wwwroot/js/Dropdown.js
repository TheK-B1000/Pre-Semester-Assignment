(function ($) {
    'use strict';

    var Dropdown = function (element, settings) {
        this.element = $(element);
        this.settings = settings;
    };

    Dropdown.prototype = {
        show: function () {
            this.element.addClass('show');
            this.element.find('.dropdown-menu').addClass('show');
        },
        hide: function () {
            this.element.removeClass('show');
            this.element.find('.dropdown-menu').removeClass('show');
        },
        toggle: function () {
            if (this.element.hasClass('show')) {
                this.hide();
            } else {
                this.show();
            }
        }
    };

    $.fn.dropdown = function (option) {
        return this.each(function () {
            var $this = $(this);
            var data = $this.data('lte.dropdown');
            var options = $.extend({}, $.fn.dropdown.defaults, $this.data(), typeof option == 'object' && option);

            if (!data) {
                data = new Dropdown($this, options);
                $this.data('lte.dropdown', data);
            }

            if (typeof option == 'string') {
                data[option]();
            }
        });
    };

    $.fn.dropdown.defaults = {};

    $(document).on('click', '[data-toggle="dropdown"]', function (event) {
        event.preventDefault();

        var button = $(this);
        var dropdown = button.parent();

        dropdown.dropdown('toggle');
    });
})(jQuery);
