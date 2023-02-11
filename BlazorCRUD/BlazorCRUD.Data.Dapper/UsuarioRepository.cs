using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCRUD.Model;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace BlazorCRUD.Data.Dapper
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string ConnectionString;

        public UsuarioRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public async Task<Usuarios> GetUsuarios(string usuario, string password)
        {
            var db = dbConnection();

            var sql = @"SELECT  Usuario, Password FROM Usuarios where Usuario=@Usuario and Password=@Password";

            var result = await db.QueryFirstOrDefaultAsync<Usuarios>(sql.ToString(), new { Usuario = usuario, Password = password });

            return result;
        }

        public async Task<IEnumerable<Usuarios>> GetAllUsuarios()
        {
            var db = dbConnection();

            var sql = @"select Id, Usuario, Password from Usuarios";

            return await db.QueryAsync<Usuarios>(sql.ToString(), new { });
        }

        public async Task<Usuarios> GetUsuariosDetails(int id)
        {
            Usuarios u = new Usuarios();
            var db = dbConnection();
            var sql = @"select Id, Usuario, Password from Usuarios where Id=@Id";

            return await db.QueryFirstOrDefaultAsync<Usuarios>(sql.ToString(), new { Id = id });
        }

        public async Task<bool> InsertUsuario(Usuarios usu)
        {
            string pass="";
            
            pass = CN_Encriptacion.Encriptar(usu.Password);
            
            var db = dbConnection();
            var sql = @"INSERT INTO Usuarios (Usuario, Password)
                        VALUES(@Usuario, '"+pass+"') ";
            var result = await db.ExecuteAsync(sql.ToString(),
                         new { usu.Usuario, usu.Password });
            return result > 0;
        }

        public async Task<bool> UpdateUsuario(Usuarios usu)
        {
            string pass = "";

            pass = CN_Encriptacion.Encriptar(usu.Password);

            var db = dbConnection();
            var sql = @"UPDATE Usuarios 
                       set Usuario = @Usuario, Password = '" + pass + "' WHERE Id = @Id";
            var result = await dbConnection().ExecuteAsync(sql.ToString(),
                         new { usu.Usuario, usu.Password, usu.Id });
            return result > 0;
        }

        public async Task<bool> DeleteUsuario(int id)
        {
            var db = dbConnection();

            var sql = @"delete from Usuarios where Id = @Id";

            var result = await db.ExecuteAsync(sql.ToString(), new { Id = id });
            return result > 0;
        }

        public async Task<Usuarios> GetPassword(string usuario)
        {
            var db = dbConnection();
           
            var sql = @"SELECT  Usuario, Password FROM Usuarios where Usuario=@Usuario";
            var result = await db.QueryFirstOrDefaultAsync<Usuarios>(sql.ToString(), new { Usuario = usuario });

            return result;
        }
    }
}
