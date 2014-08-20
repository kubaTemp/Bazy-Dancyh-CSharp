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

        [PrincipalPermissionAttribute(SecurityAction.Demand, Name = "Rafal", Role = "kierownik")]
        public static void BizzMet1()
        {
            MessageBox.Show("Met1");
        }

        [PrincipalPermissionAttribute(SecurityAction.Demand, Name = "Rafal", Role = "prowadzacy")]
        public static void BizzMet2()
        {
            MessageBox.Show("Met2");

        }

        [PrincipalPermissionAttribute(SecurityAction.Demand, Name = "Rafal", Role = "administrator")]
        public static void BizzMet3()
        {
            MessageBox.Show("Met3");
        }


    }
}
