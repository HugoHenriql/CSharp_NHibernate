using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.Entidades
{    public class Usuario
    {
        public virtual int Numero { get; set; }
        public virtual int Id  { get; set; }
        public virtual string Nome { get; set; }

        public static implicit operator Usuario(string v)
        {
            throw new NotImplementedException();
        }
    }
}
