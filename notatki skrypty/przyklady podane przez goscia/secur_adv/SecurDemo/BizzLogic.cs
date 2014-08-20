using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using System.Security.Permissions;


namespace SecurDemo
{


    public class BizzLogic
    {

        public  const String Operation1Role = "Operation1Role";
        public const String Operation2Role = "Operation2Role";
        public const String Operation3Role = "Operation3Role";


        // Mozna "sumować" ograniczenia
        // [PrincipalPermissionAttribute(SecurityAction.Demand, Role = Operation2Role)]

        [PrincipalPermissionAttribute(SecurityAction.Demand, Name = "Rafal", Role = Operation1Role)]
        public static void BizzMet1()
        {
            MessageBox.Show("Met1");
        }

        [PrincipalPermissionAttribute(SecurityAction.Demand, Role = Operation2Role)]
        public static void BizzMet2()
        {
            MessageBox.Show("Met2");

        }

        [PrincipalPermissionAttribute(SecurityAction.Demand, Name = "Rafal", Role = Operation3Role)]
        public static void BizzMet3()
        {
            MessageBox.Show("Met3");
        }

        [PrincipalPermissionAttribute(SecurityAction.Demand,Authenticated = true)]
        public static void BizzMet4()
        {
            MessageBox.Show("Met4");
        }

    }
}
