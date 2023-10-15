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
    public partial class invoices : DevExpress.XtraEditors.XtraForm
    {
        public invoices()
        {
            InitializeComponent();
        }
        classes.Invoices ncls_inv = new classes.Invoices();
        classes.loan ncls_loan = new classes.loan();

        public void customization()
        {
            gridView1.Columns.Remove(gridView1.Columns["cust_id"]);
            gridView1.Columns["inv_id"].Caption = "رقم الفاتورة";
            gridView1.Columns["inv_date"].Caption = "تاريخ الفاتورة";
            gridView1.Columns["inv_time"].Caption = "وقت الفاتورة";
            gridView1.Columns["inv_total"].Caption = "إجمالي الفاتورة";
            gridView1.Columns["inv_pushType"].Caption = "نوع الدفع";
            gridView1.Columns["inv_proType"].Caption = "المنتجات";
            gridView1.Columns["cust_name"].Caption = "اسم الزبون";
        }

        private void invoices_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = classes.Invoices.inv_data.get_inv();
            customization();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = classes.Invoices.inv_data.get_inv();
            customization();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource= classes.Invoices.inv_data.get_inv_by_date(dateTimePicker1.Text);
            customization();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            classes.loan.loan_data.Delete_loan(classes.loan.loan_id);
            classes.Invoices.inv_data.Delete_inv(classes.Invoices.inv_id);
            gridControl1.DataSource = classes.Invoices.inv_data.get_inv_by_date(dateTimePicker1.Text);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            ncls_inv.data_list_by_id(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["inv_id"]).ToString());
            ncls_loan.data_list_by_id(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["inv_id"]).ToString());
        }
    }
}