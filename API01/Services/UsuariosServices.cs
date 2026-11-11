

using API01.Data;
using API01.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Security;

namespace API01.Respositories
{
    public class UsuariosServices
    {
        //Llamando e instanciando la clase DBConnections
        ConnectionString mysqlConnection = new ConnectionString();

        private string Query = "select correo, contrasena from cuenta where correo = @correo and contrasena = @contrasena";

        public bool GetUser(UsuariosModels usuario)
        {
            bool result = false;

            using (MySqlConnection connection = new MySqlConnection(mysqlConnection.MySqlConnection))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(Query,connection))
                    {
                        command.Parameters.AddWithValue("@correo", usuario.correo);
                        command.Parameters.AddWithValue("@contrasena", usuario.contrasena);

                        using (MySqlDataReader dataReader = command.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                            {
                                result = true;
                            }
                            else
                            {
                                result = false; ;
                            }
                        }


                    }
                }
                catch (Exception ex)
                {
                   result = false;
                }
            }
            return result;
        }







    }
}