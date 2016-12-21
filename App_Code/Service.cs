using System;
using System.Data;
using System.Text;
using System.Web.Configuration;
using System.Web.Services;
using ClientDataSet;
using MySql.Data.MySqlClient;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]
public class Service : WebService
{

    private bool Login(string user, string pass)
    {
        return user == "fsoft" && pass == "fsoft";
    }

    [WebMethod(Description = "Adiciona Dados Representantes")]
    public string SetDadosRepresentante(string user, string pass, string dados)
    {
        if (!Login(user, pass))
            return "Usuário e/ou Senha inválida!";

        try
        {
            var dtPontos = ClientDataSetConverter.getDataTable(dados);

            using (var con = new MySqlConnection(Base.ConnectionString))
            {
                con.Open();

                using (var trans = con.BeginTransaction())
                {
                    try
                    {
                        foreach (DataRow row in dtPontos.Rows)
                        {
                            if (decimal.Parse(row["RectoTotal"].ToString()) == 0) continue;
                            
                            var sql = new StringBuilder()
                                .AppendLine("REPLACE INTO ReprMensal")
                                .AppendLine("(NumShowPremio, CodUnidade, DescUnidade, CodRepr, NomeRepr, RectoTotal)")
                                .AppendLine("VALUES")
                                .AppendLine("(@NumShowPremio, @CodUnidade, @DescUnidade, @CodRepr, @NomeRepr, @RectoTotal);")
                                .ToString();

                            using (var cmd = new MySqlCommand(sql, con, trans))
                            {
                                cmd.Parameters.AddWithValue("@NumShowPremio", int.Parse(row["NumShowPremio"].ToString()));
                                cmd.Parameters.AddWithValue("@CodUnidade", int.Parse(row["CodUnidade"].ToString()));
                                cmd.Parameters.AddWithValue("@DescUnidade", row["DescUnidade"].ToString());
                                cmd.Parameters.AddWithValue("@CodRepr", int.Parse(row["CodRepr"].ToString()));
                                cmd.Parameters.AddWithValue("@NomeRepr", row["NomeRepr"].ToString());
                                cmd.Parameters.AddWithValue("@RectoTotal", decimal.Parse(row["RectoTotal"].ToString().Replace(".", ",")));
                                cmd.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();
                        return "";
                    }
                    catch (Exception e)
                    {
                        trans.Rollback();
                        throw new Exception(e.Message);
                    }
                }
            }
        }
        catch (Exception e)
        {
            return "[Erro Técnico] Problema ao carregar dados:\r\n" + e.Message;
        }
    }

    [WebMethod (Description = "Adiciona Dados Show de Prêmios")]
    public string SetDados(string user, string pass, string dados)
    {
        if (!Login(user, pass))
            return "Usuário e/ou Senha inválida!";

        try
        {
            var dtPontos = ClientDataSetConverter.getDataTable(dados);

            using (var con = new MySqlConnection(Base.ConnectionString))
            {
                con.Open();

                using (var trans = con.BeginTransaction())
                {
                    try
                    {
                        foreach (DataRow row in dtPontos.Rows)
                        {
                            if (decimal.Parse(row["PontosAcumulados"].ToString()) == 0) continue;
                            
                            var sql = new StringBuilder()
                                .AppendLine("REPLACE INTO DDShowPremio")
                                .AppendLine("(NumShowPremio, CodUnidade, DescUnidade, CodVend, NomeVend, CPFVend, CodRepr, NomeRepr, PontosPedido, PontosChequeDev, PontosAcumulados)")
                                .AppendLine("VALUES")
                                .AppendLine("(@NumShowPremio, @CodUnidade, @DescUnidade, @CodVend, @NomeVend, @CPFVend, @CodRepr, @NomeRepr, @PontosPedido, @PontosChequeDev, @PontosAcumulados);")
                                .ToString();

                            using (var cmd = new MySqlCommand(sql, con, trans))
                            {

                                cmd.Parameters.AddWithValue("@NumShowPremio", int.Parse(row["NumShowPremio"].ToString()));
                                cmd.Parameters.AddWithValue("@CodUnidade", int.Parse(row["CodUnidade"].ToString()));
                                cmd.Parameters.AddWithValue("@DescUnidade", row["DescUnidade"].ToString());
                                cmd.Parameters.AddWithValue("@CodVend", int.Parse(row["CodVend"].ToString()));
                                cmd.Parameters.AddWithValue("@NomeVend", row["NomeVend"].ToString());
                                cmd.Parameters.AddWithValue("@CPFVend", row["CPFVend"].ToString());
                                cmd.Parameters.AddWithValue("@CodRepr", int.Parse(row["CodRepr"].ToString()));
                                cmd.Parameters.AddWithValue("@NomeRepr", row["NomeRepr"].ToString());
                                cmd.Parameters.AddWithValue("@PontosPedido", decimal.Parse(row["PontosPedido"].ToString().Replace(".", ",")));
                                cmd.Parameters.AddWithValue("@PontosChequeDev", decimal.Parse(row["PontosChequeDev"].ToString().Replace(".", ",")));
                                cmd.Parameters.AddWithValue("@PontosAcumulados", decimal.Parse(row["PontosAcumulados"].ToString().Replace(".", ",")));

                                cmd.ExecuteNonQuery();
                            }
                        }
                        
                        trans.Commit();
                        return "";
                    }
                    catch (Exception e)
                    {
                        trans.Rollback();
                        throw new Exception(e.Message);
                    }
                }
            }
        }
        catch (Exception e)
        {
            return "[Erro Técnico] Problema ao carregar dados:\r\n" + e.Message;
        }
    }
}
