using Chain_of_responsabily.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsabily.Middlewares
{
    class CheckUserMiddeware : Middleware
    {

        private Service service;

        public CheckUserMiddeware(Service service)
        {
            this.service = service;
        }

        //Check é o metodo extendido da classe Middlewares que ta com como abstract, logo, ela será tratada aqui
        //Caso ela passe da validação, será chamado novamen te o CheckNext que está na classe Middlewares, fazendo sempre esse looping de validação
        public override bool Check(string email, string password)
        {
            if (!service.HasEmail(email) || (!service.IsValidPassword(email, password)))
            {
                Console.WriteLine("Não existe esse email ou password no sistema");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}
