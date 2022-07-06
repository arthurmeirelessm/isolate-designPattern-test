using System;

namespace Chain_of_responsabily.Middlewares
{
    abstract class Middleware
    {
        private Middleware _next;

        public Middleware LinkWith(Middleware next)
        {
            this._next = next;

            return _next;
        }


        public abstract Boolean Check(string email, string password);

        //CheckNext: Chequa se Check retorna true ou false
        //Se retornar TRUE: Quer dizer que virá um outro middleware a ser validado
        //Se retornar FALSE; Quer dizer que a validação do middleware deu algum tipo de erro
        protected Boolean CheckNext(string email, string password)
        {
            if (_next == null)
            {
                return true;
            }

            return _next.Check(email, password);
        }
    }
}
