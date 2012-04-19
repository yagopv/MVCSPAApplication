(function ($,window) {
    $.widget("ui.spalinks", {	
		//Options passed to the widget
		//target: the DOM element selected to be the container of the ajax updates
        options: {
            target: $.noop,
			beforeajax: $.noop,
			afterajax: $.noop
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
			source.find("a[data-ajax]").live("click",function(event) { 
				self._trigger("beforeajax");
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
			$(this.options.target).load(url, function() {
				self._trigger("afterajax");
			});
		},		
		//private method
		//param data: The data object containing the uri for doing pop when pressing back
		//button in browser. The event is being bound in _create
		_dopopstate: function(data) {			
		    if (data != null) {
				this._ajaxload(data.uri, false);
			}
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
})(jQuery,window);



