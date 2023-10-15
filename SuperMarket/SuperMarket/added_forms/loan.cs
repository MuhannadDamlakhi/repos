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
    public partial class loan : DevExpress.XtraEditors.XtraForm
    {
        public loan()
        {
            InitializeComponent();
        }
        classes.Invoices ncls_inv = new classes.Invoices();
        classes.loan ncls_loan = new classes.loan();
        public void starting_page() 
        {
            gridControl1.DataSource = classes.loan.loan_data.GetData();
            gridView1.Columns["loan_id"].Caption = "المعرف";
            gridView1.Columns["loan_date"].Caption = "التاريخ";
            gridView1.Columns["loan_time"].Caption = "الوقت";
            gridView1.Columns["loan_pro_name"].Caption = "المنتج";
            gridView1.Columns["inv_id"].Caption = "رقم الفاتورة";
            gridView1.Columns["inv_total"].Caption = "قيمة الدين";
            gridView1.Columns["cust_name"].Caption = "اسم الزبون";

        }


        private void loan_Load_1(object sender, EventArgs e)
        {
            starting_page();
        }

        private void text_search_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            ncls_inv.data_list_by_id(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["inv_id"]).ToString());
            ncls_loan.data_list_by_id(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["inv_id"]).ToString());
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            classes.loan.loan_data.Delete_loan(classes.loan.loan_id);
            classes.Invoices.inv_data.Delete_inv(classes.Invoices.inv_id);
            starting_page();
        }
    }
}