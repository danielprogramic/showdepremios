	
$(function(){
	
		var _conjuntoLabel = [];
		var MyRows = $('table').find('tbody').find('tr');
	
		for (var i = 0; i < MyRows.length; i++) 
		  {
			var MyIndexValue = $(MyRows[i]).find('td:eq(0)').html();
			  $(MyRows[i]).find('td:eq(0)').text('');
			  if(MyIndexValue <= 9){
				 $(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="">'+
				 '<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:40px;margin-top:16px;" >'+MyIndexValue+'</span>'+
				 '<img  style="z-index:8;height:55px; width: 50px; margin-top:0px;margin-left:20px;"  src="../Content/img/fundo.png" />'+
				 '</div>');	
			  }else{
				 $(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="">'+
				 '<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:35px;margin-top:16px;" >'+MyIndexValue+'</span>'+
				 '<img  style="z-index:8;height:55px; width: 50px; margin-top:0px;margin-left:20px;"  src="../Content/img/fundo.png" />'+
				 '</div>');	
			  }								  	
		  }
				 
	});