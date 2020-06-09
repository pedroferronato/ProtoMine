using ProtoMine.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoMine.Cache
{
    public static class UserCache
    {
        public static Usuario UsuarioLogado { get; set; }
        public static bool Mestre { get; set; }
    }
}
