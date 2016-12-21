	<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

	<!DOCTYPE html>

	<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<title>Classificação Geral (Show de Prêmios)</title>
       
		<link rel="stylesheet" type="text/css" href="Content/css/normalize.css" />
		<link rel="stylesheet" type="text/css" href="Content/css/demo.css" />
		<link rel="stylesheet" type="text/css" href="Content/css/component.css" />
		<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.5.2/animate.min.css">
        <script src="http://ajax.googleapis.com/ajax/libs/jquery/1/jquery.min.js"></script>
		<script src="http://cdnjs.cloudflare.com/ajax/libs/jquery-throttle-debounce/1.1/jquery.ba-throttle-debounce.min.js"></script>
		<script src="./Content/js/jquery.stickyheader.js"></script>
		<script src="./Content/js/app.js"></script>
		<script src="./Content/js/MouseShow.js"></script>
        <script language= "JavaScript">
			var url = window.location.href;
            function procuPegaParametros(parameterName) {
                var result = null,
                    tmp = [];
                    location.search
                    .substr(1)
                    .split("?")
                    .forEach(function (item) {
                        tmp = item.split("=");
                        result = tmp;
                    });

                return result;
            }

			if(url.slice(-1) != "/" && procuPegaParametros(window.location.href) == ''){
             location.href= url+"/";
			}
      </script>
	</head>
	<body>
	  <div class="container">
	  
	   <header >
		   <div style="float:left;margin-left:90px;margin-top:-24px;" >
		         <img  src="./Content/img/logo.png" >
		   </div>
			<div style="margin-top:40px;" >
			     <h1 style="font-size:28px;font-weight:bold;" id="Titulo" runat="server" >Classificação Geral - <span>CAMPANHA 1vazio</span> </h1>
				 <h2  style="color:#d8a0ba;" id="Periodo" runat="server">De 01/11/2016 Até 31/05/2017</h2>
		   </div>				
	   </header>	
		  
	  <div style="text-shadow: 0px 0px 0px rgba(150, 150, 150, 0.54);color:#3c3c3c;text-shadow: 1px 1px 0px rgba(150, 150, 150, 0.50);" class="component">
        <h2>Classificação parcial até o momento.</h2>
		<span style="float:right;color:#000;font-size:13px;">  As imagens são meramente ilustrativas. </span>
		<form id="formVend" runat="server">        
		<div>
			<asp:GridView runat="server" AutoGenerateColumns="False" ID="gridView"
				AllowSorting="True"
				OnSorting="GridViewSorting" >
				<Columns>
					<asp:BoundField  DataField="Posicao" HeaderText="POSIÇÃO" SortExpression="Posicao" >
						<HeaderStyle HorizontalAlign="Center" Width="70px" />
						<ItemStyle HorizontalAlign="Center" />
					</asp:BoundField>
					<asp:BoundField DataField="Nome" HeaderText="VENDEDORA" SortExpression="Nome" >
						<HeaderStyle HorizontalAlign="Left" Width="200px" />
						<ItemStyle HorizontalAlign="Left" />
					</asp:BoundField>
					<asp:BoundField DataField="NomeRepresentante" HeaderText="REPRESENTANTE" >
						<HeaderStyle HorizontalAlign="Left" Width="200px" />
						<ItemStyle HorizontalAlign="Left" />
					</asp:BoundField>
					<asp:BoundField DataField="NomeUnidade" HeaderText="UNIDADE" >
						<HeaderStyle Width="200px" />
						<ItemStyle HorizontalAlign="Center" />
					</asp:BoundField>
					<asp:BoundField DataField="PontosAcumulados" HeaderText="PONTOS" DataFormatString="{0:n0}" Visible="True" >
						<HeaderStyle Width="100px" HorizontalAlign="Right" />
						<ItemStyle HorizontalAlign="Right" />
					</asp:BoundField>
				</Columns>	
			</asp:GridView>

		</div>
		</form>	
		</div>
		</div>
		
	
	</body>
	</html>
