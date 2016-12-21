	
$(function(){
		var _conjuntoLabel = [];
		var MyRows = $('table').find('tbody').find('tr');
		
		for (var i = 0; i < MyRows.length; i++) 
		  {
			var MyIndexValue = $(MyRows[i]).find('td:eq(0)').html();
			
			if(MyIndexValue <= 3)
			 
			 {
			  _conjuntoLabel[MyIndexValue] = "TV Smart LED 43";
			  $(MyRows[i]).find('td:eq(0)').text('');
			  $(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="position:absolute;margin-top:11px;margin-left:-30px;">'+
				 '<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:20px;" >'+MyIndexValue+'</span>'+
				 '<img  style="z-index:8;position:absolute;height:55px; width: 50px; margin-top:-12px;"  src="./Content/img/fundo.png" />'+
				 '</div>');										  
			  $(MyRows[i]).find('td:eq(0)').append('<img id="objTV_'+MyIndexValue+'" style="height:73px; width: 110px; margin-top:0px;margin-left:50px;" src="./Content/img/smartyTV.png" />');
				
			
			} else if(MyIndexValue >= 3 && MyIndexValue <= 9)
			 
			 {
			  _conjuntoLabel[MyIndexValue] = "Maquina de Lavar 8Kg";
			  $(MyRows[i]).find('td:eq(0)').text('');
			  $(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="position:absolute;margin-top:19px;margin-left:-30px;">'+
				 '<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:20px;" >'+MyIndexValue+'</span>'+
				 '<img  style="z-index:8;position:absolute;height:55px; width: 50px; margin-top:-12px;"  src="./Content/img/fundo.png" />'+
				 '</div>'); 
			  $(MyRows[i]).find('td:eq(0)').append('<img id="objTV_'+MyIndexValue+'" style="height:78px; width: 60px; margin-top:-9px;margin-left:70px;" src="./Content/img/maquinalavar.png" />');  
			
			} else if(MyIndexValue >= 10 && MyIndexValue <= 12)
			 
			 {
			  _conjuntoLabel[MyIndexValue] = "Smartphone";
			  $(MyRows[i]).find('td:eq(0)').text('');
			  $(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="position:absolute;margin-top:19px;margin-left:-30px;">'+
				 '<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:15px;" >'+MyIndexValue+'</span>'+
				 '<img  style="z-index:8;position:absolute;height:55px; width: 50px; margin-top:-12px;"  src="./Content/img/fundo.png" />'+
				 '</div>'); 
			  $(MyRows[i]).find('td:eq(0)').append('<img id="objTV_'+MyIndexValue+'" style="height:68px; width: 50px; margin-top:-9px;margin-left:70px;" src="./Content/img/smartphone.png" />');  
			
			} else if(MyIndexValue >= 13 && MyIndexValue <= 15)
			 
			 {
			  _conjuntoLabel[MyIndexValue] = "Micro-ondas";
			  $(MyRows[i]).find('td:eq(0)').text('');
			  $(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="position:absolute;margin-top:19px;margin-left:-30px;">'+
				 '<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:15px;" >'+MyIndexValue+'</span>'+
				 '<img  style="z-index:8;position:absolute;height:55px; width: 50px; margin-top:-12px;"  src="./Content/img/fundo.png" />'+
				 '</div>'); 
			  $(MyRows[i]).find('td:eq(0)').append('<img id="objTV_'+MyIndexValue+'" style="height:58px; width: 95px; margin-top:-9px;margin-left:50px;" src="./Content/img/microondas.png" />');  
			
			} else if(MyIndexValue >= 16 && MyIndexValue <= 25)
			 
			 {
			  _conjuntoLabel[MyIndexValue] = "Fritadeira";
			  $(MyRows[i]).find('td:eq(0)').text('');
			  $(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="position:absolute;margin-top:19px;margin-left:-30px;">'+
				 '<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:15px;" >'+MyIndexValue+'</span>'+
				 '<img  style="z-index:8;position:absolute;height:55px; width: 50px; margin-top:-12px;"  src="./Content/img/fundo.png" />'+
				 '</div>'); 
			  $(MyRows[i]).find('td:eq(0)').append('<img id="objTV_'+MyIndexValue+'" style="height:85px; width: 70px; margin-top:-9px;margin-left:70px;" src="./Content/img/fritadeira.png" />');  
			
			} else if(MyIndexValue >= 26 && MyIndexValue <= 35)
			 
			 {
			  _conjuntoLabel[MyIndexValue] = "Panela de Arroz";
			  $(MyRows[i]).find('td:eq(0)').text('');
			  $(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="position:absolute;margin-top:19px;margin-left:-30px;">'+
				 '<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:15px;" >'+MyIndexValue+'</span>'+
				 '<img  style="z-index:8;position:absolute;height:55px; width: 50px; margin-top:-12px;"  src="./Content/img/fundo.png" />'+
				 '</div>'); 
			  $(MyRows[i]).find('td:eq(0)').append('<img id="objTV_'+MyIndexValue+'" style="height:65px; width: 60px; margin-top:-9px;margin-left:75px;" src="./Content/img/panelaarroz.png" />');  
			
		   } else if(MyIndexValue >= 36 && MyIndexValue <= 60)
			 
			 {
			  _conjuntoLabel[MyIndexValue] = "Ferro a Vapor";
			  $(MyRows[i]).find('td:eq(0)').text('');
			  $(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="position:absolute;margin-top:19px;margin-left:-30px;">'+
				 '<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:15px;" >'+MyIndexValue+'</span>'+
				 '<img  style="z-index:8;position:absolute;height:55px; width: 50px; margin-top:-12px;"  src="./Content/img/fundo.png" />'+
				 '</div>'); 
			  $(MyRows[i]).find('td:eq(0)').append('<img id="objTV_'+MyIndexValue+'" style="height:61px; width: 80px;  margin-top:-9px;margin-left:60px;" src="./Content/img/ferropassar.png" />');  
			
			} else if(MyIndexValue >= 61 && MyIndexValue <= 90)
			 
			 {
			  _conjuntoLabel[MyIndexValue] = "Batedeira";
			  $(MyRows[i]).find('td:eq(0)').text('');
			  $(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="position:absolute;margin-top:19px;margin-left:-30px;">'+
				 '<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:15px;" >'+MyIndexValue+'</span>'+
				 '<img  style="z-index:8;position:absolute;height:55px; width: 50px; margin-top:-12px;"  src="./Content/img/fundo.png" />'+
				 '</div>'); 
			  $(MyRows[i]).find('td:eq(0)').append('<img id="objTV_'+MyIndexValue+'" style="height:65px; width: 60px;  margin-top:-9px;margin-left:70px;" src="./Content/img/batedeira.png" />');  
			
			} else if(MyIndexValue >= 91 && MyIndexValue <= 120)
			 
			 {
			  _conjuntoLabel[MyIndexValue] = "Sanduicheira";
			  $(MyRows[i]).find('td:eq(0)').text('');
			  $(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="position:absolute;margin-top:19px;margin-left:-30px;">'+
				 '<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:9px;" >'+MyIndexValue+'</span>'+
				 '<img  style="z-index:8;position:absolute;height:55px; width: 50px; margin-top:-12px;"  src="./Content/img/fundo.png" />'+
				 '</div>'); 
			  $(MyRows[i]).find('td:eq(0)').append('<img id="objTV_'+MyIndexValue+'" style="height:70px; width: 65px;  margin-top:-9px;margin-left:70px;" src="./Content/img/sanduicheira.png" />');  

		   } else if(MyIndexValue >= 121 && MyIndexValue <= 160)
			 
			 {
			  _conjuntoLabel[MyIndexValue] = "Secador";
			  $(MyRows[i]).find('td:eq(0)').text('');
			  $(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="position:absolute;margin-top:19px;margin-left:-30px;">'+
				 '<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:9px;" >'+MyIndexValue+'</span>'+
				 '<img  style="z-index:8;position:absolute;height:55px; width: 50px; margin-top:-12px;"  src="./Content/img/fundo.png" />'+
				 '</div>'); 
			  $(MyRows[i]).find('td:eq(0)').append('<img id="objTV_'+MyIndexValue+'" style="height:70px; width: 65px;  margin-top:-0px;margin-left:70px;" src="./Content/img/secadora.png" />');  
			
		 } else if(MyIndexValue >= 161 && MyIndexValue <= 200)
			 
			 {
			  _conjuntoLabel[MyIndexValue] = "Mixer";
			  $(MyRows[i]).find('td:eq(0)').text('');
			  $(MyRows[i]).find('td:eq(0)').append('<div id="num_'+MyIndexValue+'" style="position:absolute;margin-top:19px;margin-left:-30px;">'+
				 '<span style="position:absolute;z-index:10;font-size:19px;font-weight:bold;color:#fff;margin-left:9px;" >'+MyIndexValue+'</span>'+
				 '<img  style="z-index:8;position:absolute;height:55px; width: 50px; margin-top:-12px;"  src="./Content/img/fundo.png" />'+
				 '</div>'); 
			  $(MyRows[i]).find('td:eq(0)').append('<img id="objTV_'+MyIndexValue+'" style="height:70px; width: 65px;  margin-top:-0px;margin-left:70px;" src="./Content/img/mixer.png" />');  
			}


			$(MyRows[i]).find('td:eq(0)').append('<div id="labelPremios_'+MyIndexValue+'" style="color:#c15387;position:absolute;'+
				 'z-index:0;margin-top:-15px;margin-left:10px;background-color:#fff;font-size:13px;'+
				 'padding:1px;-webkit-border-radius: 10px;-moz-border-radius: 10px;'+
				 'border-radius: 4px;" >TV Smart LED 43"</div>');
			 $('#labelPremios_'+MyIndexValue).hide();
			var buttonlist = new MouseShow( MyIndexValue, $(MyRows[i]), $('#objTV_'+MyIndexValue),$('#labelPremios_'+MyIndexValue), _conjuntoLabel[MyIndexValue],$('#num_'+MyIndexValue));		 
			buttonlist.actionsobject();
		 
		  }
				 
	});