using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarket.DataSet1TableAdapters;
using System.Data;

namespace SuperMarket.classes
{
    class customers
    {
        public static int cust_id;
        public static string cust_name;
        public static string cust_phone;
        public static string cust_address;

        public static customersTableAdapter cust_data = new customersTableAdapter();

        public DataTable data_list()
        {
            DataTable dt = new DataTable();
            dt = cust_data.GetData();
            if(dt.Rows.Count>0)
            {   
                cust_id = Convert.ToInt32(dt.Rows[dt.Rows.Count-1][0].ToString());
                cust_name = dt.Rows[dt.Rows.Count - 1][1].ToString();
                cust_phone = dt.Rows[dt.Rows.Count - 1][2].ToString();
                cust_address = dt.Rows[dt.Rows.Count - 1][3].ToString();
            }
            return dt;
        }

        public DataTable data_list_choose(string s_cust_name,string s_cust_phone,string s_cust_address)
        {
            DataTable dt = new DataTable();
            dt = cust_data.get_cust_by_choose(s_cust_name, s_cust_phone, s_cust_address);
            if (dt.Rows.Count > 0)
            {
                cust_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                cust_name = dt.Rows[0][1].ToString();
                cust_phone = dt.Rows[0][2].ToString();
                cust_address = dt.Rows[0][3].ToString();
            }
            return dt;
        }

        public DataTable data_list_search(string s_cust_name, string s_cust_phone, string s_cust_address)
        {
            DataTable dt = new DataTable();
            dt = cust_data.get_cust_by_searchh(s_cust_name, s_cust_phone, s_cust_address);
            if (dt.Rows.Count > 0)
            {
                cust_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                cust_name = dt.Rows[0][1].ToString();
                cust_phone = dt.Rows[0][2].ToString();
                cust_address = dt.Rows[0][3].ToString();
            }
            return dt;
        }






    }
}
