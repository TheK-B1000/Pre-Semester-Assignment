(function ($) {
    'use strict';

    var ControlSidebar = function (element, settings) {
        this.element = $(element);
        this.settings = settings;
    };

    ControlSidebar.prototype = {
        open: function () {
            this.element.addClass('control-sidebar-open');
        },
        close: function () {
            this.element.removeClass('control-sidebar-open');
        },
        toggle: function () {
            this.element.toggleClass('control-sidebar-open');
        }
    };

    $.fn.controlSidebar = function (option) {
        return this.each(function () {
            var $this = $(this);
            var data = $this.data('lte.controlsidebar');
            var options = $.extend({}, $.fn.controlSidebar.defaults, $this.data(), typeof option == 'object' && option);

            if (!data) {
                data = new ControlSidebar($this, options);
                $this.data('lte.controlsidebar', data);
            }

            if (typeof option == 'string') {
                data[option]();
            }
        });
    };

    $.fn.controlSidebar.defaults = {};

    $(document).on('click', '[data-control-sidebar]', function (event) {
        event.preventDefault();

        var button = $(this);
        var sidebar = $(button.data('target'));
        var action = button.data('control-sidebar');

        sidebar.controlSidebar(action);
    });
})(jQuery);
