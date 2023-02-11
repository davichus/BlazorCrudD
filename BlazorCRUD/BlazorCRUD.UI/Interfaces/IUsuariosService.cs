using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCRUD.Model;

namespace BlazorCRUD.UI.Interfaces
{
    public interface IUsuariosService
    {
        Task<IEnumerable<Usuarios>> GetAllUsuarios();
        Task<Usuarios> GetUsuarios(string usuario, string password);
        Task<Usuarios> GetDetails(int id);
        Task<bool> SaveUsuarios(Usuarios usu);
        Task<bool> DeleteUsuario(int id);
        Task<Usuarios> GetPassword(string usuario);
    }

}
