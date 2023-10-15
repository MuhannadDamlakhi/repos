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
    public partial class customers : DevExpress.XtraEditors.XtraForm
    {
        public customers()
        {
            InitializeComponent();
        }

        private void customers_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = classes.customers.cust_data.get_cust_not_cash();
            simpleButton1.Visible = false;
            simpleButton2.Visible = false;

            gridView1.Columns["cust_id"].Caption = "المعرف";
            gridView1.Columns["cust_name"].Caption = "الاسم";
            gridView1.Columns["cust_phone"].Caption = "رقم الهاتف";
            gridView1.Columns["cust_address"].Caption = "العنوان";
        }
        public static int cust_id;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           classes.customers ncls_cust = new classes.customers();
           ncls_cust.data_list_choose(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gridView1.Columns["cust_name"]).ToString(),
                                      gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gridView1.Columns["cust_phone"]).ToString(),
                                      gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gridView1.Columns["cust_address"]).ToString());
           simpleButton1.Visible = true;
           simpleButton2.Visible = true;

           cust_id = classes.customers.cust_id;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            added_forms.accountStatment form = new accountStatment();
            form.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            classes.customers.cust_data.Delete_cust(classes.customers.cust_id);
            gridControl1.DataSource = classes.customers.cust_data.get_cust_not_cash();
            simpleButton1.Visible = false;
            simpleButton2.Visible = false;
        }
    }
}