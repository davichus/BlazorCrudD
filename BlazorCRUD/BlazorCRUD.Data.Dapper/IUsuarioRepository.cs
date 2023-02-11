using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCRUD.Model;

namespace BlazorCRUD.Data.Dapper
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuarios>> GetAllUsuarios();
        Task<Usuarios> GetUsuariosDetails(int id);
        Task<bool> InsertUsuario(Usuarios usu);
        Task<bool> UpdateUsuario(Usuarios usu);
        Task<bool> DeleteUsuario(int id);
        Task<Usuarios> GetUsuarios(string usuario, string password);
        Task<Usuarios> GetPassword(string usuario);
    }
}
