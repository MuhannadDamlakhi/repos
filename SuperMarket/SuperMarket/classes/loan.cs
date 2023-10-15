using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarket.DataSet1TableAdapters;
using System.Data;
namespace SuperMarket.classes
{
    class loan
    {
        public static int loan_id;
        public static string inv_date;
        public static string inv_time;
        public static string pro_name;
        public static int inv_id;

        public static loanTableAdapter loan_data = new loanTableAdapter();

        public DataTable data_list_by_id(string s_inv_id)
        {
            DataTable dt = new DataTable();
            dt = loan_data.get_loan_by_inv_id(Convert.ToInt32(s_inv_id));
            if (dt.Rows.Count > 0)
            {
                loan_id = Convert.ToInt32(dt.Rows[0][0]);
                inv_date = dt.Rows[0][1].ToString();
                inv_time = dt.Rows[0][2].ToString();
                pro_name = dt.Rows[0][3].ToString() ;
                inv_id = Convert.ToInt32(dt.Rows[0][4].ToString());
            }
            return dt;
        }

        
    }
}
