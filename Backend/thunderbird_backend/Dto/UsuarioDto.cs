using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class UsuarioDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Boolean State { get; set; }
        public string Email { get; set; }
        public string Document_Id { get; set; }
        public int Id_Rol { get; set; }
    }
}
