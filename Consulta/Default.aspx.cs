using System;
using System.Linq;

public partial class Consulta_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblResultado.Text = "";
    }

    protected virtual void OnClick(Object sender, EventArgs e)
    {
        var cpf = edtCPF.Text.Trim();

        if (cpf == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Atenção!", "alert('CPF Não Indicado!');", true);            
            edtCPF.Focus();
            edtCPF.Text = "";
            return;
        }

        if (!Funcoes.CPFValido(cpf))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Atenção!", "alert('CPF Inválido!');", true);            
            edtCPF.Focus();
            edtCPF.Text = "";
            return;
        }

        var campanha = new Campanha().GetCampanhaAtual();
        
        var lista = Vendedora.ListaVendedoras(0);

        var vendedora = lista.Where(vend => vend.CPF == cpf).ToList();

        if (!vendedora.Any())
        {
            var dataAtual = DateTime.Now;

            if (dataAtual.Day > 11)
            {
                dataAtual = dataAtual.AddDays(30);
            }
            
            lblResultado.Text =
                "<strong>CPF não encontado</strong>. Aguarde até a proxima atualização da promoção que ocorrerá dia " + dataAtual.ToString("11/MM/yyyy");
        }
        else if (vendedora[0].Posicao > campanha.QtdeVendedorasPremiadas)
        {
            lblResultado.Text =
                "Olá, " + vendedora[0].Nome.Split(' ')[0] + ". Seus pontos acumulados até o momento são de " + String.Format("{0:n0}", vendedora[0].PontosAcumulados) + " pontos. Continue concorrendo. Boa sorte!";
        }
        else
        {
            lblResultado.Text =
                "Olá, " + vendedora[0].Nome.Split(' ')[0] + ". Seus pontos acumulados até o momento são de <strong>" + String.Format("{0:n0}", vendedora[0].PontosAcumulados) + " PONTOS</strong>. Parabéns, você está em <strong>" + vendedora[0].Posicao + "º NO RANKING</strong>. Continue concorrendo. Boa sorte!";

        }
        
    }
}