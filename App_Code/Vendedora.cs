using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MySql.Data.MySqlClient;

public class Vendedora : Base
{
    public int Posicao { get; set; }
    
    public int Codigo { get; set; }

    public string Nome { get; set; }

    public string CPF { get; set; }

    public int CodigoRepresentante { get; set; }

    public string NomeRepresentante { get; set; }

    public string NomeCompletoRepresentante { get; set; }

    public int CodigoUnidade { get; set; }

    public string NomeUnidade { get; set; }

    public decimal PontosPedido { get; set; }

    public decimal PontosChequeDevolvido { get; set; }

    public decimal PontosAcumulados { get; set; }

    public static List<Vendedora> ListaVendedoras(int quantidade)
    {
        var lista = new List<Vendedora>();

        var campanha = new Campanha().GetCampanhaAtual();

        var sql = new StringBuilder()
            .AppendLine("  select *")
            .AppendLine("    from DDShowPremio")
            .AppendLine("   where NumShowPremio = @CAMPANHA")
            .AppendLine("order by PontosAcumulados desc");

        if (quantidade > 0)
            sql.AppendLine("limit "+ quantidade);

        using (var con = new MySqlConnection(ConnectionString))
        {
            con.Open();

            using (var cmd = new MySqlCommand(sql.ToString(), con))
            {
                cmd.Parameters.AddWithValue("@CAMPANHA", campanha.Numero);
                
                using (var dr = cmd.ExecuteReader())
                {
                    int posicao = 1;

                    while (dr.Read())
                    {
                        var nome = dr["NomeVend"].ToString().Split(' ')[0] + " (" + dr["CodVend"] + ")";
                        var nomeRepr = dr["NomeRepr"].ToString().Split(' ')[0];

                        lista.Add(new Vendedora
                        {
                            Posicao = posicao++,
                            Nome = nome,
                            CPF = dr["CPFVend"].ToString(),
                            CodigoRepresentante = int.Parse(dr["CodRepr"].ToString()),
                            NomeRepresentante = nomeRepr,
                            NomeCompletoRepresentante = dr["NomeRepr"].ToString(),
                            NomeUnidade = dr["DescUnidade"].ToString(),
                            PontosPedido = decimal.Parse(dr["PontosPedido"].ToString()),
                            PontosChequeDevolvido = decimal.Parse(dr["PontosChequeDev"].ToString()),
                            PontosAcumulados = decimal.Parse(dr["PontosAcumulados"].ToString())
                        });
                    }
                }
            }
        }

        return lista;
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static List<Vendedora> ListaVendedorasView()
    {        
        //return ListaVendedoras(new Campanha().GetCampanhaAtual().QtdeVendedorasPremiadas).OrderBy(m => m.Nome).ToList();
        return ListaVendedoras(new Campanha().GetCampanhaAtual().QtdeVendedorasPremiadas);
    }
}