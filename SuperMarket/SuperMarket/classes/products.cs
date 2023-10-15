using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarket.DataSet1TableAdapters;
using System.Data;



namespace SuperMarket.classes
{
    class products
    {
        public static int pro_id;
        public static string pro_name;
        public static int pro_qnty;
        public static int pro_price;
        public static string pro_company;
        public static int cat_id;

        public static ProductsTableAdapter products_data = new ProductsTableAdapter();

        public DataTable data_list(string s_pro_name)
        {
            DataTable dt = new DataTable();
            dt = products_data.GetProByName(s_pro_name);
            if(dt.Rows.Count>0)
            {
                pro_id=Convert.ToInt32(dt.Rows[0][0].ToString());
                pro_name = dt.Rows[0][1].ToString();
                pro_qnty = Convert.ToInt32(dt.Rows[0][2].ToString());
                pro_price = Convert.ToInt32(dt.Rows[0][3].ToString());
                pro_company = dt.Rows[0][4].ToString();
                cat_id = Convert.ToInt32(dt.Rows[0][5].ToString());
                
            }
                return dt;
            

        }
    }
}
