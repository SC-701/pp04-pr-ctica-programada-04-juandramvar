using Autorizacion.Abstracciones.DA;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace Autorizacion.DA.Repositorios
{
    public class RepositorioDapper : IRepositorioDapper
    {
        private readonly IConfiguration _configuration;
        private SqlConnection _connection;

        public RepositorioDapper(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("BDSeguridad"));
        }

        public SqlConnection ObtenerRepositorioDapper()
        {
            return _connection;
        }
    }
}