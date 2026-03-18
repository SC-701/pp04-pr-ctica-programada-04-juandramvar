using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DA.Repositorios
{
    public class RepositorioDapper : Abstracciones.DA.IRepositorioDapper
    {
        private readonly IConfiguration _configuration;
        private SqlConnection _connection;

        public RepositorioDapper(IConfiguration configuration)
        {
            _configuration = configuration;

            var cadena = _configuration.GetConnectionString("BDSeguridad");
            Console.WriteLine("CADENA SQL: " + cadena);

            _connection = new SqlConnection(cadena);
        }

        public SqlConnection ObtenerRepositorioDapper()
        {
            return _connection;
        }
    }
}