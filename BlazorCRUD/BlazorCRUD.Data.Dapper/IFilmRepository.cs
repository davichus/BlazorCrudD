using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCRUD.Model;

namespace BlazorCRUD.Data.Dapper
{
    public interface IFilmRepository
    {
       Task<IEnumerable<Film>> GetAllFilms();
       Task<Film> GetFilmDetails(int id);
       Task<bool> InsertFilm(Film film);
       Task<bool> UpdateFilm(Film film);
       Task<bool> DeleteFilm(int id);
       Task<Usuarios> GetUsuarios(string usuario, string password);
    }
}
