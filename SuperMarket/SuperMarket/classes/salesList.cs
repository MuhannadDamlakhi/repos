using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarket.DataSet1TableAdapters;
using System.Data;

namespace SuperMarket.classes
{
    class salesList
    {
        public static int salesList_id;
        public static int pro_id;
        public static int cust_id;

        public static sales_listTableAdapter sale_list_data = new sales_listTableAdapter();

        public DataTable data_list(int s_pro_id,int s_cust_id)
        {
            DataTable dt = new DataTable();
            dt = sale_list_data.get_salelist_by_proid_custid(s_pro_id, s_cust_id);
            if (dt.Rows.Count > 0)
            {
                salesList_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                pro_id = Convert.ToInt32(dt.Rows[0][1].ToString());
                cust_id = Convert.ToInt32(dt.Rows[0][2].ToString());
            }
            return dt;

        }

    }
}
