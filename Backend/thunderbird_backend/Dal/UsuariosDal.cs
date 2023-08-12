using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class UsuariosDal : Dapper
    {
        public UsuariosDal(string ConexionString)
        {
            Conexion = ConexionString;
        }

        public bool Add_User(UsuarioDto user)
        {
            return SingleQuery<object, bool>("[dbo].[SP_AgregarUsuarios]", new
            {
                Username = user.Username,
                Password = user.Password,
                State = user.State,
                Email = user.Email,
                Document_Id = user.Document_Id,
                Id_Rol = user.Id_Rol
            });
        }

        public bool Add_Role(RolesDto rol)
        {
            return SingleQuery<object, bool>("[dbo].[SP_AgregarRoles]", new
            {
                Description = rol.Description,
                State = rol.State
            });
        }

    }
}
