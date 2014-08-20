using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using DAC; 


namespace BL
{
    public class TblUpd
    {

        // Bizness object for Table1 with elements form Table2
        public class T1Info
        {
            private System.Nullable<short> _nr;

            public System.Nullable<short> nr
            {
                get { return _nr; }
                set { _nr = value; }
            }
            private string _name;

            public string name
            {
                get { return _name; }
                set { _name = value; }
            }
            private string _t2name;

            public string t2name
            {
                get { return _t2name; }
                set { _t2name = value; }
            }

        }

        public static List<T1Info> GetT1Info(string NameFilter = "")
        {
            using (DataClasses1DataContext dc1 = new DataClasses1DataContext())
            {

                var res = from tt1 in dc1.Table1s
                          from tt2 in dc1.Table2s
                          where tt1.id == tt2.id && tt1.name.StartsWith (NameFilter)
                          orderby  tt1.name 
                          select new T1Info { nr = tt1.nr, name = tt1.name, t2name = tt2.name };
                return (List<T1Info>)res.ToList();
            }

        }

        public static List<Table1> GetAll()
        {
            using (DataClasses1DataContext dc1 = new DataClasses1DataContext() )
            {
            


            var res = from tt in dc1.Table1s
                      select tt;
                return (List<Table1>) res.ToList();
            }

        }
 
        public static Table1 GetElement (int Nr)
        {
            
            using (DataClasses1DataContext dc1 = new DataClasses1DataContext ())
            {
            var el =  ( from t in dc1.Table1s
                        where  t.nr == Nr
                        select t).SingleOrDefault() ;
            return (Table1)el;
            }
            return null;
        }

        public static void TableMod (Table1 t)
        {
            using (DataClasses1DataContext dc1 = new DataClasses1DataContext ())
            {
                var r = (from tt in dc1.Table1s
                         where tt.nr == t.nr
                         select tt).SingleOrDefault();
                
                r.name = t.name;
                dc1.SubmitChanges();
                
            }
        }

    }

}
