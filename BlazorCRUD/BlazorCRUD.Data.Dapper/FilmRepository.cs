using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCRUD.Model;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Data;

namespace BlazorCRUD.Data.Dapper
{
    public class FilmRepository : IFilmRepository
    {
        private string ConnectionString;

        public FilmRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public async Task<bool> DeleteFilm(int id)
        {
            var db = dbConnection();

            var sql = @"delete from Films where Id = @Id";

            var result = await db.ExecuteAsync(sql.ToString(), new { Id = id });
            return result > 0;
        }

        public async Task<IEnumerable<Film>> GetAllFilms()
        {
            var db = dbConnection();

            var sql = @"select Id, Title, Director, ReleaseDate
                        from Films";

            return await db.QueryAsync<Film>(sql.ToString(), new { });
        }

        public async Task<Film> GetFilmDetails(int id)
        {
            var db = dbConnection();
            var sql = @"select Id, Title, Director, ReleaseDate
                        from Films where Id=@Id";

            return await db.QueryFirstOrDefaultAsync<Film>(sql.ToString(), new { Id = id });
        }

        public async Task<bool> InsertFilm(Film film)
        {

            var db = dbConnection();
            var sql = @"INSERT INTO Films (Title, Director, ReleaseDate)
                        VALUES(@Title, @Director, @ReleaseDate) ";
            var result = await db.ExecuteAsync(sql.ToString(),
                         new { film.Title, film.Director,film.ReleaseDate });
            return result > 0;
        }

        public async Task<bool> UpdateFilm(Film film)
        {
            var db = dbConnection();
            var sql = @"UPDATE Films 
                       set Title = @Title, Director = @Director, ReleaseDate = @ReleaseDate
                       WHERE Id = @Id";
            var result = await dbConnection().ExecuteAsync(sql.ToString(),
                         new { film.Title, film.Director, film.ReleaseDate, film.Id });
            return result > 0;
        }

        public async Task<Usuarios> GetUsuarios(string usuario, string password)
        {
            var db = dbConnection();

            var sql = @"SELECT  Usuario, Password FROM Usuarios where Usuario=@Usuario and Password=@Password";

            var result = await db.QueryFirstOrDefaultAsync<Usuarios>(sql.ToString(), new { Usuario = usuario, Password = password });

            return result;
        }
    }
}
