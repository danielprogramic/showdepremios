using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

public class Representante : Base
{
    public int Posicao { get; set; }

    public int Codigo { get; set; }

    public string Nome { get; set; }

    public string Unidade { get; set; }

    public decimal PontosAcumulados { get; set; }

    public decimal TotalRecebido { get; set; }

    public static List<Representante> ListaRepresentantesMensal(int quantidade)
    {
        var lista = new List<Representante>();

        var campanha = new Campanha().GetCampanhaAtual();

        var sql = new StringBuilder()
            .AppendLine("select *")
            .AppendLine("  from ReprMensal")
            .AppendLine(" where NumShowPremio = @CAMPANHA")
            .AppendLine(" order by RectoTotal desc");

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
                        lista.Add(new Representante()
                        {
                            Posicao = posicao++,
                            Codigo = int.Parse(dr["CodRepr"].ToString()),
                            Nome = dr["NomeRepr"].ToString(),
                            Unidade = dr["DescUnidade"].ToString(),
                            PontosAcumulados = decimal.Parse(dr["RectoTotal"].ToString()),
                            TotalRecebido = decimal.Parse(dr["RectoTotal"].ToString())
                        });
                    }
                }
            }
        }

        return lista;
    }

    public static List<Representante> ListaRepresentantes(int quantidade)
    {
        var lista = new List<Representante>();       
        
        var lVend = Vendedora.ListaVendedorasView();

        foreach (var vend in lVend)
        {
            var found = false;
            
            foreach (var rep in lista)
            {
                if (rep.Codigo.Equals(vend.CodigoRepresentante) && rep.Unidade.Equals(vend.NomeUnidade))
                {
                    rep.PontosAcumulados += vend.PontosAcumulados;
                    found = true;
                    break;
                }
            }

            if (found) continue;

            lista.Add(new Representante()
                          {
                              Codigo = vend.CodigoRepresentante,
                              Nome = vend.NomeCompletoRepresentante,
                              PontosAcumulados = vend.PontosAcumulados,
                              Posicao = 0,
                              Unidade = vend.NomeUnidade
                          });
        }

        // Posição
        var pos = 1;

        foreach (var rep in lista.OrderByDescending(r => r.PontosAcumulados))
        {
            rep.Posicao = pos++;
        }

        return lista.OrderByDescending(l => l.PontosAcumulados).ToList().GetRange(0, lista.Count() < quantidade ? lista.Count : quantidade);

        /*
        var lista = new List<Representante>();

        var campanha = new Campanha().GetCampanhaAtual();

        var sql = new StringBuilder()
            .AppendLine("select dsp.CodRepr,")
            .AppendLine("       dsp.NomeRepr,")
            .AppendLine("       dsp.DescUnidade,")
            .AppendLine("       sum(dsp.PontosAcumulados) Pontos")
            .AppendLine("  from DDShowPremio dsp")
            .AppendLine("   where dsp.NumShowPremio = @CAMPANHA")
            .AppendLine(" group by dsp.CodRepr, dsp.CodUnidade")            
            .AppendLine(" order by 4 desc");

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
                        //var nome = dr["NomeRepr"].ToString().Split(' ')[0];
                        var nome = dr["NomeRepr"].ToString();

                        lista.Add(new Representante()
                                      {
                                          Posicao = posicao++,
                                          Codigo = int.Parse(dr["CodRepr"].ToString()),
                                          Nome = nome,
                                          Unidade = dr["DescUnidade"].ToString(),
                                          PontosAcumulados = decimal.Parse(dr["Pontos"].ToString())
                                      });
                    }
                }
            }
        }

        return lista;
         */
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static List<Representante> ListaRepresentantesView()
    {
        return ListaRepresentantes(new Campanha().GetCampanhaAtual().QtdeRepresentantesPremiados);
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static List<Representante> ListaRepresentantesMensalView()
    {
        return ListaRepresentantesMensal(new Campanha().GetCampanhaAtual().QtdeRepresentanteMensal);
    }
}