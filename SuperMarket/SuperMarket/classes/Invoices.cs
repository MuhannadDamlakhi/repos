using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarket.DataSet1TableAdapters;
using System.Data;
	
		 
	

namespace SuperMarket.classes
{
    class Invoices
    {
        public static int inv_id;
        public static string inv_date;
        public static string inv_time;
        public static int inv_total;
        public static string inv_pushType;
        public static string inv_proType;
        public static int cust_id;

        public static InvoicesTableAdapter inv_data = new InvoicesTableAdapter();

        public DataTable data_list()
        {
            DataTable dt = new DataTable();
            dt= inv_data.GetData();
            if (dt.Rows.Count>0)
            {
                inv_id=Convert.ToInt32( dt.Rows[dt.Rows.Count-1][0]);
                inv_date=dt.Rows[dt.Rows.Count-1][1].ToString();
                inv_time=dt.Rows[dt.Rows.Count-1][2].ToString();
                inv_total=Convert.ToInt32(dt.Rows[dt.Rows.Count-1][3]);
                inv_pushType=dt.Rows[dt.Rows.Count-1][4].ToString();
                inv_proType=dt.Rows[dt.Rows.Count-1][6].ToString();
                cust_id=Convert.ToInt32( dt.Rows[dt.Rows.Count-1][5]);
            }
            return dt;
          }

        public DataTable data_list_by_id(string s_inv_id)
        {
            DataTable dt = new DataTable();
            dt = inv_data.get_inv_by_id(Convert.ToInt32(s_inv_id));
            if (dt.Rows.Count > 0)
            {
                inv_id = Convert.ToInt32(dt.Rows[0][0]);
                inv_date = dt.Rows[0][1].ToString();
                inv_time = dt.Rows[0][2].ToString();
                inv_total = Convert.ToInt32(dt.Rows[0][3]);
                inv_pushType = dt.Rows[0][4].ToString();
                inv_proType = dt.Rows[0][6].ToString();
                cust_id = Convert.ToInt32(dt.Rows[0][5]);
            }
            return dt;
        }


        

    }

}
