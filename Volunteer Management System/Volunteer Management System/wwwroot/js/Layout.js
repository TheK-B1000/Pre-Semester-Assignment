(function ($) {
    'use strict';

    var Layout = function (element, settings) {
        this.element = $(element);
        this.settings = settings;
    };

    Layout.prototype = {
        toggleSidebar: function () {
            $('body').toggleClass('sidebar-collapse');
        }
    };

    $.fn.layout = function (option) {
        return this.each(function () {
            var $this = $(this);
            var data = $this.data('lte.layout');
            var options = $.extend({}, $.fn.layout.defaults, $this.data(), typeof option == 'object' && option);

            if (!data) {
                data = new Layout($this, options);
                $this.data('lte.layout', data);
            }

            if (typeof option == 'string') {
                data[option]();
            }
        });
    };

    $.fn.layout.defaults = {};

    $(document).on('click', '[data-toggle="push-menu"]', function (event) {
        event.preventDefault();

        $('body').layout('toggleSidebar');
    });
})(jQuery);
