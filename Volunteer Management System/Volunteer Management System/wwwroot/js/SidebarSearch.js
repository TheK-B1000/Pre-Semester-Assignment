(function ($) {
    'use strict';

    var SidebarSearch = function (element) {
        this.element = $(element);
    };

    SidebarSearch.prototype = {
        toggle: function () {
            this.element.toggleClass('sidebar-search-open');
        }
    };

    $.fn.sidebarSearch = function (option) {
        return this.each(function () {
            var $this = $(this);
            var data = $this.data('lte.sidebarsearch');

            if (!data) {
                data = new SidebarSearch($this);
                $this.data('lte.sidebarsearch', data);
            }

            if (typeof option === 'string') {
                data[option]();
            }
        });
    };

    $(document).on('click', '[data-toggle="sidebar-search"]', function (event) {
        event.preventDefault();
        $('.sidebar').sidebarSearch('toggle');
    });
})(jQuery);
