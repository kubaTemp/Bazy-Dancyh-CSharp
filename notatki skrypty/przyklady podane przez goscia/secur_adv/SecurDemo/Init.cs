using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using System.Threading;
using System.Collections;


namespace SecurDemo
{

    public interface IUserCtx
    {
        String  UName  { get ;} 
 
        bool HasRoleRight ( String OperRoleName) ;
 
        bool HasGroupRight ( String GroupName) ;

        List<String> GetAllRoles();

        }


    class UserCtx : IUserCtx
    
    {
        private String uname;

        public UserCtx(String un)
        {
            uname = un;
            OpersRoles = new List<String>();
         }




        public string UName
        {
            get { return uname; }
        }

        // lepiej hash mapa
        private List<String> OpersRoles;

        public void AddOperRole (String OperRoleName)
        {
            OpersRoles.Add(OperRoleName);
        }

        

        public bool HasRoleRight(string OperRoleName)
        {
            // throw new NotImplementedException();
            return OpersRoles.Contains(OperRoleName);
        }

        public bool HasGroupRight(string GroupName)
        {
            throw new NotImplementedException();
        }


        public List<string> GetAllRoles()
        {
            // throw new NotImplementedException();

            return  OpersRoles;
        }
    }


    
    public class Init
    {


        public static void Logout(ref IUserCtx uc)
        {
            // IPrincipal  gp ;
            //gp = Thread.CurrentPrincipal;

            uc = null;
            Thread.CurrentPrincipal = null;
            //IIdentity id = gp.Identity;
            //id = null;
            //gp = null;

        }

        public static bool Login( String uname , String pass , out IUserCtx uc)
        {
            String[] roles;
            uc = null;

            // autentykacja (tu następuje sprawdzenie z tablicą user/pass z Bazy Danych)
            if (uname == "Rafal")
            {
                // autoryzacja (tu następuje pobranie z Bazy Danych wszystkich ról do których user należy)
                roles = new String[] { BizzLogic.Operation1Role, BizzLogic.Operation2Role };

            }

            else if (uname == "Atylla")
            {
                roles = new String[] { BizzLogic.Operation2Role };
            }
            else {
                return false;
            }

            UserCtx ucl = new UserCtx(uname);
            foreach (String s in roles)
                ucl.AddOperRole(s);
            uc = ucl;

            GenericIdentity gi = new GenericIdentity(uname);

            GenericPrincipal gp = new GenericPrincipal(gi, roles);

            // przypisanie kontekstu (żeby działał mechanizm)
            Thread.CurrentPrincipal = gp;
            return true;

        }
    }
}
