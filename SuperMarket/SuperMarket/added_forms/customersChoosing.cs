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
    public partial class customersChoosing : DevExpress.XtraEditors.XtraForm
    {
        public customersChoosing()
        {
            InitializeComponent();
        }
        classes.customers ncls_customers = new classes.customers();

        private void customersChoosing_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ncls_customers.data_list_search(textName.Text, textphone.Text, textaddress.Text);
        }

        private void customersChoosing_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("اختر أحد الزبائن أو أدخل زبوناً جديداً");
        }

        private void textName_EditValueChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = ncls_customers.data_list_search(textName.Text, textphone.Text, textaddress.Text);
        }

        private void textphone_EditValueChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = ncls_customers.data_list_search(textName.Text, textphone.Text, textaddress.Text);
        }

        private void textaddress_EditValueChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = ncls_customers.data_list_search(textName.Text, textphone.Text, textaddress.Text);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            ncls_customers.data_list_choose(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["cust_name"]).ToString(),
                                            gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["cust_phone"]).ToString(),
                                            gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["cust_address"]).ToString());
            //added_forms.sales_form m = new sales_form();
            //m.text_cust.Text = classes.customers.cust_name;
            //added_forms.sales_form.text_cust.Text = classes.customers.cust_name;

            this.Close();
        }
        // تخزين قيم مربعات النص بمتغيرات من اجل ارسالها الى فورم المبيعات
        
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (textName.Text!="")
            {
                sales_form.isNewCustomer = true;
                //ncls_customers.data_list_choose(textName.Text, textphone.Text, textaddress.Text);
                classes.customers.cust_name = textName.Text;
                classes.customers.cust_phone = textphone.Text;
                classes.customers.cust_address = textaddress.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("أدخل بيانات الزبون الجديد أولاً");
            }
            
        }
    }
}