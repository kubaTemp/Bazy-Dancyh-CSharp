using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Security.Permissions;
using System.Runtime ;
using DataLay;


namespace BizLay
{
    public static class BizService
    {
        //[PrincipalPermissionAttribute(SecurityAction.Demand, Name="Rafal")]
        // [PrincipalPermissionAttribute(SecurityAction.Demand, Role = @"BUILTIN\Administrators")]

        public static IQueryable<zespoly> GetZesp (String txtName)
        {
            DataZPWTDataContext dc = new DataZPWTDataContext() ;
            // dc.Log = Console.Out; 
            var zz = from z in dc.zespolies
                     where z.NAZWA_ZESP.StartsWith(txtName) 
                     select z ;

            return (zz);
        }

        public static void UpdateZesp(String str, int Id)
        {

            using (DataZPWTDataContext dc = new DataZPWTDataContext())
            {
                var ze = (from z in dc.zespolies
                          where z.NR_ZESP == Id
                          select z).SingleOrDefault();
                if (ze == null)
                    return;
                ze.NAZWA_ZESP = ze.NAZWA_ZESP + str;
                dc.SubmitChanges();

            }
        }

    }
}
