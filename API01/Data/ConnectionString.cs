namespace API01.Data
{
    public class ConnectionString
    {
        ///Cadena conexion SQL Server
        private string SqlServerConnectionOne = "Datasource=DESKTOP-9JCSRBN; User=sa; Password=nokia620*;";
        private string SqlServerConnectionTwo = "Datasource=DESKTOP-3QE31CC; User=sa; Password=nokia620*;";

        ///Cadena conexion MySQL
        private string MySqlConnectionOne = "Server=localhost; Database=usuarios; Uid=root; Pwd=nokia620*;";
        private string MySqlConnectionTwo = "Server=192.168.100.107; Database=usuarios; Uid=remote; Pwd=1234; Port=3307";


        //Propiedades para acceder a las cadenas de conexión
        public string SqlServerConnection => SqlServerConnectionTwo; 
        public string MySqlConnection => MySqlConnectionTwo;
    }
}
