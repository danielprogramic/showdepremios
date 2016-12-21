using System;
using System.Web.UI;

public partial class Admin_Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var campanha = new Campanha().GetCampanhaAtual();

        Titulo.InnerText = "Classificação Geral (REPRESENTANTES) - " + campanha.Descricao;
        Periodo.InnerText = "De " + campanha.DataInicial.ToString("dd/MM/yyyy") + " Até " + campanha.DataFinal.ToString("dd/MM/yyyy");
    }
}