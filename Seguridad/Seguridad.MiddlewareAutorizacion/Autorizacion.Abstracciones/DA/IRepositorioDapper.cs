using Microsoft.Data.SqlClient;

namespace Autorizacion.Abstracciones.DA
{
    public interface IRepositorioDapper
    {
        SqlConnection ObtenerRepositorioDapper();
    }
}
