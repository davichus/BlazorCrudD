using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCRUD.Model;

namespace BlazorCRUD.UI.Interfaces
{
    public interface IFilmService
    {
        Task<IEnumerable<Film>> GetAllFilms();
        Task<Film> GetDetails(int id);
        Task<bool> DeleteFilm(int id);
        Task<bool> SaveFilm(Film film);
        Task<Usuarios> GetUsuarios(string usuario, string password);
    }
}
