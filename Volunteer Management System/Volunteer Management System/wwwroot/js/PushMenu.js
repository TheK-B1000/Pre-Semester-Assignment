(function ($) {
    'use strict';

    var PushMenu = function (element, settings) {
        this.element = $(element);
        this.settings = settings;
    };

    PushMenu.prototype = {
        toggle: function () {
            var windowWidth = $(window).width();
            if (windowWidth > 768) {
                $('body').toggleClass('sidebar-collapse');
            } else {
                $('body').toggleClass('sidebar-open');
            }
        }
    };

    $.fn.pushMenu = function (option) {
        return this.each(function () {
            var $this = $(this);
            var data = $this.data('lte.pushmenu');
            var options = $.extend({}, $.fn.pushMenu.defaults, $this.data(), typeof option == 'object' && option);

            if (!data) {
                data = new PushMenu($this, options);
                $this.data('lte.pushmenu', data);
            }

            if (typeof option === 'string') {
                data[option]();
            }
        });
    };

    $.fn.pushMenu.defaults = {};

    $(document).on('click', '[data-toggle="push-menu"]', function (event) {
        event.preventDefault();
        $('body').pushMenu('toggle');
    });
})(jQuery);
