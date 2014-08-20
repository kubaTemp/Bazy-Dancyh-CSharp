using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using System.Threading;

namespace SecurDemo
{
    public class Init
    {
        public static void Login()
        {
            // autentykacja (tu następuje sprawdzenie z tablicą user/pass z Bazy Danych)
            GenericIdentity gi = new GenericIdentity("Rafal");

            // autoryzacja (tu następuje pobranie z Bazy Danych wszystkich ról do których user należy)
            String[] roles = new String[] { "kierownik", "prowadzacy" };
            GenericPrincipal gp = new GenericPrincipal(gi, roles);

            // przypisanie kontekstu (żeby działał mechanizm)
            Thread.CurrentPrincipal = gp;

        }
    }
}
