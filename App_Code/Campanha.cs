using System;
using System.Text;
using MySql.Data.MySqlClient;

public class Campanha : Base
{
    public int Numero { get; set; }

    public string Descricao { get; set; }

    public DateTime DataInicial { get; set; }

    public DateTime DataFinal { get; set; }

    public int QtdeVendedorasPremiadas { get; set; }

    public int QtdeRepresentantesPremiados { get; set; }

    public int QtdeRepresentanteMensal { get; set; }

    public int QtdeRepresentanteMensalPremiados { get; set; }

    public Campanha GetCampanhaAtual()
    {
        var campanha = new Campanha();

        using (var con = new MySqlConnection(ConnectionString))
        {
            con.Open();

            var sql = new StringBuilder()
                .AppendLine("select *")
                .AppendLine("  from ShowPremio ")
                .AppendLine(" where current_date() between DataInicial and DataFinal")
                .ToString();

            using (var cmd = new MySqlCommand(sql, con))
            {
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        campanha.Numero = int.Parse(dr["Numero"].ToString());
                        campanha.Descricao = dr["Descricao"].ToString();
                        campanha.DataInicial = DateTime.Parse(dr["DataInicial"].ToString());
                        campanha.DataFinal = DateTime.Parse(dr["DataFinal"].ToString());
                        campanha.QtdeVendedorasPremiadas = int.Parse(dr["QtdeVendPremiadas"].ToString());
                        campanha.QtdeRepresentantesPremiados = int.Parse(dr["QtdeReprPremiados"].ToString());
                        campanha.QtdeRepresentanteMensal = int.Parse(dr["QtdeReprMensal"].ToString());
                        campanha.QtdeRepresentanteMensalPremiados = int.Parse(dr["QtdeReprMensalPremiados"].ToString());
                    }
                }
            }
        }

        return campanha;
    }
}