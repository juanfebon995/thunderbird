using Bussiness;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace thunderbird_backend.Controllers
{
    public class UsuariosController : ApiController
    {
        public UsuariosBussiness Bussiness = new UsuariosBussiness(Properties.Settings.Default.Conexion);

        /// <summary>
        /// Funcion encargada de agregar usuarios dentro de la base de datos
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost, Route("Add_User")]
        public dynamic Add_User(UsuarioDto user)
        {
            try
            {
                var Response = Bussiness.Add_User(user);
                return Json(new { 
                    Msg = "Usuario creado con exito",
                    Code = 200,
                    Username = user.Username
                });
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }


        /// <summary>
        /// Funcion encargada de agregar roles dentro de la base de datos
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost, Route("Add_Role")]
        public dynamic Add_Role(RolesDto rol)
        {
            try
            {
                var Response = Bussiness.Add_Role(rol);
                return Json(new
                {
                    Msg = "Rol creado con éxito",
                    Code = 200,
                    Username = rol.Description
                });
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }

    }
}
