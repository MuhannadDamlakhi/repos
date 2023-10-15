using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarket.DataSet1TableAdapters;
using System.Data;
	
namespace SuperMarket.classes
{
    class users
    {
        public static int user_id;
        public static string userName;
        public static string userPw;

        public static UsersTableAdapter users_data = new UsersTableAdapter();

        public DataTable user_list(string s_user_name,string s_user_password)
        {
            DataTable dt = new DataTable();
            dt = users_data.GetUsersByNamePassword(s_user_name,s_user_password);
            if (dt.Rows.Count > 0) 
            {
                user_id=Convert.ToInt32(dt.Rows[0][0].ToString());
                userName=dt.Rows[0][1].ToString();
                userPw=dt.Rows[0][2].ToString();
                  
            }
            return dt;


        }


    }
}

