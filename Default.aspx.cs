using System;
using System.Linq;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {               
        if (!IsPostBack)
        {
            var campanha = new Campanha().GetCampanhaAtual();

            Titulo.InnerText = "Classificação Geral - " + campanha.Descricao;
            Periodo.InnerText = "De " + campanha.DataInicial.ToString("dd/MM/yyyy") + " Até " + campanha.DataFinal.ToString("dd/MM/yyyy");

            Session["View"] = Request.Form["View"];

            gridView.DataSource = Vendedora.ListaVendedorasView();
            gridView.DataBind();
        }

        gridView.Columns[4].Visible = (Session["View"] != null && Session["View"].ToString() == "{1B605F4E-A7C9-4B7B-98B7-5A2D2ADBD520}");

        var dev = Request.QueryString["dev"];

        if (dev != null)
            gridView.Columns[4].Visible = true;
    }

    protected void GridViewSorting(object sender, GridViewSortEventArgs e)
    {
        if (e.SortExpression == "Nome")
        {
            gridView.DataSource = Vendedora.ListaVendedorasView().OrderBy(m => m.Nome).ToList();
        }
        else if (e.SortExpression == "Posicao")
        {
            gridView.DataSource = Vendedora.ListaVendedorasView();
        }        
        gridView.DataBind();
    }
}