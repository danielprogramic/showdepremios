
	function MouseShow(id, objeto, tv, labelpr, texto, num) {
		habilitando = false;
		this.id = id;
		this.objeto = objeto;
		this.tv = tv;
		this.labelpr = labelpr;
		this.texto = texto;
		this.num = num;
		  
	};

	MouseShow.prototype.enablebtns = function() {
	this.objeto.css("cursor", "pointer");
	};

	MouseShow.prototype.actionsobject = function() {
		

		var _id = this.id;
		var _objeto = this.objeto;
		var _tv = this.tv;
		var _labelpr = this.labelpr;
		var _texto = this.texto; 
		var _num = this.num; 

	this.objeto.click(function(e) {
		
	  });
	this.objeto.mouseover(function() {
		_tv.addClass('animated tada');
		_num.addClass('animated pulse');
		//_labelpr.slideDown();
		_labelpr.stop(true, true).delay(500).slideDown('slow');
		_labelpr.text(_texto);

	   
	});
	
	this.objeto.mouseout(function() {
		_tv.removeClass('animated tada');
		_num.removeClass('animated pulse');
		//_labelpr.slideUp();
		_labelpr.stop(true, true).delay(500).slideUp('slow');
	});
	};


