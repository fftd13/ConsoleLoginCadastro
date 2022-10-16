using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    interface ILogIn
    {
        public bool Verificar(string email, string password);
        public void Cadastrar(string email, string username, string password);
    }
}
