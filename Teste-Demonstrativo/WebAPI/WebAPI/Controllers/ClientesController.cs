using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {   
            private static List<Clientes> clientes = new List<Clientes>();

            [HttpGet]
            public List<Clientes> Get()
            {
                return clientes;
            }

            [HttpPost]
            public void Post(string nome)
            {
                if (!string.IsNullOrEmpty(nome))
                {
                    clientes.Add(new Clientes(nome));
                }
            }

            [HttpDelete]
            public void Delete(string nome)
            {
                clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
            }
        }
}
