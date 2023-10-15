using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarket.DataSet1TableAdapters;
using System.Data;


namespace SuperMarket.classes
{
    class cats
    {
        public static int cat_id;
        public static string cat_name;
        public static string cat_notes;

        public static CatsTableAdapter cat_data = new CatsTableAdapter();

        public DataTable data_list(string s_cat_name)
        {
            DataTable dt = new DataTable();
            dt = cat_data.GetCatsByName(s_cat_name);
            if(dt.Rows.Count>0)
            {
                cat_id=Convert.ToInt32(dt.Rows[0][0].ToString());
                cat_name = dt.Rows[0][1].ToString();
                cat_notes = dt.Rows[0][2].ToString();
            }
            return dt;

        }


    }
}
