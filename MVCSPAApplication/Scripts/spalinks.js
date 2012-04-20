(function ($, window) {
    $.widget("ui.spalinks", {
        //Options passed to the widget
        //target: the DOM element selected to be the container of the ajax updates
        //beforeajax: function that executes before the ajax request happens
        //afterajax: function that executes after the ajax request happens
        //useloading: when true a ajax loader indicator will be showed
        //loadingdefaulttext: The text to be displayed within the indicator container
        //loadingdefaultclass: If don´t like the default style you can define a class and pass it to the widget
        options: {
            target: $.noop,
            beforeajax: $.noop,
            afterajax: $.noop,
            useloading: false,
            loadingdefaulttext: "Loading ...",
            loadingdefaultclass: ""
        },
        //Widget creation. Executes only once
        _create: function () {
            var self = this;
            var source = this.element;
            self._bindlinks(source);
            $(window).bind('popstate', function (evt) {
                self._dopopstate(evt.originalEvent.state);
            });
        },
        //private method
        //param source: A link to be bound
        _bindlinks: function (source) {
            var self = this;
            source.find("a[data-ajax]").live("click", function (event) {
                self._trigger("beforeajax");
                if (self.options.useloading == true) {
                    self._addLoading();
                }
                self._ajaxload($(this).attr("href"), true);
                return false;
            });
        },
        //private method
        //param url: The url to pick de html data for refreshing the target container
        //param add: Boolean indicating if it is necessary to add a new url to the history object
        _ajaxload: function (url, add) {
            var self = this;
            if (add) {
                history.pushState({ uri: url }, '', url);
            }
            $(this.options.target).load(url, function () {
                self._trigger("afterajax");
                if (self.options.useloading == true) {
                    self._removeLoading();
                }
            });
        },
        //private method
        //param data: The data object containing the uri for doing pop when pressing back
        //button in browser. The event is being bound in _create
        _dopopstate: function (data) {
            if (data != null) {
                this._ajaxload(data.uri, false);
            }
        },
        //private method
        //Add the loader to the DOM element
        _addLoading: function () {
            var self = this;
            var loading;
            if (self.options.loadingdefaultclass != "") {
                loading = $('<div id="spalinks_loader"></div>')
									.addClass(self.options.loadingdefaultclass)
									.append($("<p></p>").text(self.options.loadingdefaulttext));
            } else {
                loading = $('<div id="spalinks_loader" style="display:none; position: fixed; top: 0; left: 0; z-index: 5000; font-size: 150%; width:100%;"></div>')
									.append($('<p style="margin: 0 auto; text-align:center; background-color: #7BB33D; color: white; font-weight:bold; font-size:15px; padding: 6px; width:22%; -moz-border-radius: 0 0 5px 5px; border-radius: 0 0 5px 5px; -moz-box-shadow: 0 1px 15px #7BB33D; -webkit-box-shadow: 0 1px 15px #7BB33D; box-shadow: 0 1px 15px #7BB33D;"></p>').text(this.options.loadingdefaulttext));
            }
            $(this.element).append(loading);
            $("#spalinks_loader").slideDown();
        },
        //Private method
        //Remove the loader from the DOM
        _removeLoading: function () {
            $("#spalinks_loader").slideUp(function () {
                $(this).remove();
            });
        },
        //Generic method of the widget factory to set options from outside the widget
        _setOption: function (name, value) {
            $.Widget.prototype._setOption.apply(this, arguments);
        },
        //Destroy widget instance
        destroy: function () {
            // if using jQuery UI 1.8.x
            $.Widget.prototype.destroy.call(this);
            // if using jQuery UI 1.9.x
            //this._destroy();
        }
    });
})(jQuery, window);




