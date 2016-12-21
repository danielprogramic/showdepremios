	
$(function(){ 
	
		var _conjuntoLabel = [];
		var MyRows = $('table').find('tbody').find('tr');
	
		for (var i = 0; i < MyRows.length; i++) 
		  {

			var MyIndexValue = $(MyRows[i]).find('td:eq(0)').html();
			$(MyRows[i]).find('td:eq(0)').text('');

			  if(MyIndexValue <= 10){
					if(MyIndexValue != 10){
						
						$(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="position:absolute;margin-top:19px;margin-left:-30px;">'+
						'<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:20px;margin-top:13px;" >'+MyIndexValue+'</span>'+
						'<img  style="z-index:8;position:absolute;height:55px; width: 50px; margin-top:0px;margin-left:0px;"  src="../../Content/img/fundo.png" />'+
						'</div>'); 
					}else{
						$(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="position:absolute;margin-top:19px;margin-left:-30px;">'+
						'<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:13px;margin-top:13px;" >'+MyIndexValue+'</span>'+
						'<img  style="z-index:8;position:absolute;height:55px; width: 50px; margin-top:0px;margin-left:0px;"  src="../../Content/img/fundo.png" />'+
						'</div>'); 

					}

			  $(MyRows[i]).find('td:eq(0)').append('<img id="objTV_'+MyIndexValue+'" style="height:82px; width: 57px; margin-top:-9px;margin-left:20px;" src="../../Content/img/trofeu.png" />'); 
				var buttonlist = new MouseShow( MyIndexValue, $(MyRows[i]), $('#objTV_'+MyIndexValue),$('#labelPremios_'+MyIndexValue), _conjuntoLabel[MyIndexValue],$('#num_'+MyIndexValue));		 
        buttonlist.actionsobject(); 

			  }else{

				 $(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="">'+
				 '<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:35px;margin-top:16px;" >'+MyIndexValue+'</span>'+
				 '<img  style="z-index:8;height:55px; width: 50px; margin-top:0px;margin-left:20px;"  src="../../Content/img/fundo.png" />'+
				 '</div>');	

			  }								  	
		  }
				 
	});