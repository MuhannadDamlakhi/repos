using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SuperMarket.added_forms
{
    public partial class accountStatment : DevExpress.XtraEditors.XtraForm
    {
        public accountStatment()
        {
            InitializeComponent();
        }

        private void accountStatment_Load(object sender, EventArgs e)
        {
            //gridControl1.DataSource = classes.salesList.sale_list_data.get_sales_by_customer(customers.cust_id);
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            gridControl1.DataSource = classes.salesList.sale_list_data.get_sales_by_customer(customers.cust_id);

            gridView1.Columns.Remove(gridView1.Columns["sales_list_id"]);
            gridView1.Columns.Remove(gridView1.Columns["pro_id"]);
            gridView1.Columns.Remove(gridView1.Columns["cust_id"]);
            gridView1.Columns.Remove(gridView1.Columns["cust_name"]);
            gridView1.Columns.Remove(gridView1.Columns["Expr1"]);

            gridView1.Columns["inv_date"].Caption = "التاريخ";
            gridView1.Columns["inv_time"].Caption = "الوقت";
            gridView1.Columns["inv_total"].Caption = "إجمالي الفاتورة";
            gridView1.Columns["inv_pushType"].Caption = "نوع الدفع";
            gridView1.Columns["pro_name"].Caption = "المنتج";


        }
    }
}