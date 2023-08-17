(function ($) {
    'use strict';

    var SidebarSearch = function (element) {
        this.element = $(element);
        this.init();
    };

    SidebarSearch.prototype = {
        init: function () {
            var self = this;

            this.element.on('submit', function (e) {
                e.preventDefault();
                self.handleSearch();
            });
        },

        toggle: function () {
            this.element.toggleClass('sidebar-search-open');
        },

        handleSearch: function () {
            var inputValue = $("#searchInput").val().toLowerCase();

            if (inputValue.includes("add volunteer")) {
                window.location.href = '@Url.Action("AddVolunteer", "Volunteer")';
            } else if (inputValue.includes("add opportunity")) {
                window.location.href = '@Url.Action("AddOpportunity", "Opportunity")';
            }
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
