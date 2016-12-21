using System.Web.Configuration;

public class Base
{
    public static readonly string ConnectionString = WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
}