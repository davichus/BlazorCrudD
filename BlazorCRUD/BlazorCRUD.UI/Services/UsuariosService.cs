using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCRUD.Data.Dapper;
using BlazorCRUD.Model;
using BlazorCRUD.UI.Data;
using BlazorCRUD.UI.Interfaces;

namespace BlazorCRUD.UI.Services
{
    public class UsuariosService : IUsuariosService
    {
        private readonly SqlConfiguration _configuration;
        private IUsuarioRepository _usuarioRepository;

        public UsuariosService(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _usuarioRepository = new UsuarioRepository(configuration.ConnectionString);
        }

        public Task<bool> DeleteUsuario(int id)
        {
            return _usuarioRepository.DeleteUsuario(id);
        }

        public Task<IEnumerable<Usuarios>> GetAllUsuarios()
        {
            return _usuarioRepository.GetAllUsuarios();
        }

        public Task<Usuarios> GetDetails(int id)
        {
            return _usuarioRepository.GetUsuariosDetails(id);
        }

        public Task<Usuarios> GetPassword(string usuario)
        {
            return _usuarioRepository.GetPassword(usuario);
        }

        public Task<Usuarios> GetUsuarios(string usuario, string password)
        {
            return _usuarioRepository.GetUsuarios(usuario, password);
        }

        public Task<bool> SaveUsuarios(Usuarios usu)
        {
            if (usu.Id == 0)
            {
                return _usuarioRepository.InsertUsuario(usu);
            }
            else
            {
                return _usuarioRepository.UpdateUsuario(usu);
            }
        }
    }
}
