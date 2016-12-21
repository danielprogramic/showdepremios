using System;

public partial class Admin_Mensal_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var campanha = new Campanha().GetCampanhaAtual();

        Titulo.InnerText = "Ranking de Representantes por Fechamento Mensal - " + campanha.Descricao;
        Periodo.InnerText = "De " + campanha.DataInicial.ToString("dd/MM/yyyy") + " Até " + campanha.DataFinal.ToString("dd/MM/yyyy");
    }
}