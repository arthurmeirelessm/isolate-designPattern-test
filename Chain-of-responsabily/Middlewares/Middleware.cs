using System;

namespace Chain_of_responsabily.Middlewares
{
    abstract class Middleware
    {
        //Usando injeçãop de dependencia na propria classe para usar o check lá em baixo no CheckNext
        private Middleware next;

        public Middleware LinkWith(Middleware next)
        {
            this.next = next;

            return next;
        }


        public abstract Boolean Check(string email, string password);

        //CheckNext: Chequa se Check retorna true ou false
        //Se retornar TRUE: Quer dizer que virá um outro middleware a ser validado
        //Se retornar FALSE; Quer dizer que a validação do middleware deu algum tipo de erro
        protected Boolean CheckNext(string email, string password)
        {
            if (next == null)
            {
                return true;
            }

            return next.Check(email, password);
        }
    }
}
