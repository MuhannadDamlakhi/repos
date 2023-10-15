using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SuperMarket.DataSet1TableAdapters;

namespace SuperMarket.classes
{
    class sales
    {
        public static int sales_id;
        public static string sales_state;
        public static string sales_pushState;
        public static int sales_qnty;
        public static int sales_total;
        public static string sales_date;
        public static string sales_time;
        public static int pro_id;

        public static salesTableAdapter sale_data = new salesTableAdapter();

        public DataTable data_list(string s_pro_name)
        {
            DataTable dt = new DataTable();
            dt = sale_data.GetData(s_pro_name);
            if (dt.Rows.Count > 0)
            {
                sales_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                sales_state = dt.Rows[0][1].ToString();
                sales_pushState = dt.Rows[0][2].ToString();
                sales_qnty = Convert.ToInt32(dt.Rows[0][3].ToString());
                sales_total = Convert.ToInt32(dt.Rows[0][4].ToString());
                sales_date = dt.Rows[0][5].ToString();
                sales_time = dt.Rows[0][6].ToString();
                pro_id = Convert.ToInt32(dt.Rows[0][7].ToString());

            }
            return dt;

        }




    }
}
