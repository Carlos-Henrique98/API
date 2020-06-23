using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Clientes
    {
        public int id { get; set; }

        public string Nome { get; set; }

        public Clientes(string texto)
        {
            this.Nome = texto;
        }
    }
}
