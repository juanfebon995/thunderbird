using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class UsuariosBussiness
    {
        public UsuariosDal Dal;

        public UsuariosBussiness(string Conexion)
        {
            Dal = new UsuariosDal(Conexion);
        }

        /// <summary>
        /// Funcion encargada de agregar usuarios dentro de la base de datos
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Add_User(UsuarioDto user)
        {
            var Response = Dal.Add_User(user);
            return Response;
        }

        /// <summary>
        /// Funcion encargada de agregar roles dentro de la base de datos
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Add_Role(RolesDto rol)
        {
            var Response = Dal.Add_Role(rol);
            return Response;
        }

    }
}
