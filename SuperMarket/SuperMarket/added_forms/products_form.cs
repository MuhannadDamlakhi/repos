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
    public partial class products_form : DevExpress.XtraEditors.XtraForm
    {
        public products_form()
        {
            InitializeComponent();
        }
        classes.products ncls_products = new classes.products();
        classes.cats ncls_cats = new classes.cats();
        int cat_id;

        private void products_form_Load(object sender, EventArgs e)
        {
            starting_page();
        }
        
        public void starting_page()
        {
            combo_cat_name.DataSource = classes.cats.cat_data.GetData();
            combo_cat_name.ValueMember = "cat_name";
            gridControl1.DataSource = ncls_products.data_list(text_search.Text);
            gridView1.Columns.Remove(gridView1.Columns["pro_id"]);
            gridView1.Columns.Remove(gridView1.Columns["cat_id"]);
            gridView1.Columns["pro_name"].Caption = "اسم المنتج";
            gridView1.Columns["pro_qnty"].Caption = "الكمية";
            gridView1.Columns["pro_prc"].Caption = "السعر";
            gridView1.Columns["pro_cmp"].Caption = "الشركة المنتجة";
            gridView1.Columns["cat_name"].Caption = "الفئة";
            text_name.Text = "";
            text_price.Text = "";
            text_quantity.Text = "";
            text_company.Text = "";
            combo_cat_name.Text = "";
         }

        private void text_search_EditValueChanged(object sender, EventArgs e)
        {
            starting_page();
        }
                       
        private void gridView1_Click(object sender, EventArgs e)
        {
            ncls_products.data_list(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["pro_name"]).ToString());
            text_name.Text = classes.products.pro_name;
            text_quantity.Text =classes.products.pro_qnty.ToString();
            text_price.Text = classes.products.pro_price.ToString();
            text_company.Text = classes.products.pro_company;

            ncls_cats.data_list(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["cat_name"]).ToString());
            combo_cat_name.Text = classes.cats.cat_name;
         }
        private void combo_cat_name_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ncls_cats.data_list(combo_cat_name.Text);

            cat_id = classes.cats.cat_id;
        }
               
        private void simpleButton4_Click(object sender, EventArgs e)
        {
           
                if (text_name.Text!=""&&int.Parse(text_quantity.Text)>0&&int.Parse(text_price.Text)>0)
                {
                    classes.products.products_data.Insert_prod(text_name.Text, Convert.ToInt32(text_quantity.Text), Convert.ToInt32(text_price.Text), text_company.Text, cat_id);

                    starting_page();
                }
                else
                {
                    MessageBox.Show("ادخل بيانات الصنف لحفظه");
                }
                            
         }
               
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            classes.products.products_data.Update_pro(text_name.Text, Convert.ToInt32(text_quantity.Text), Convert.ToInt32(text_price.Text), text_company.Text, cat_id, classes.products.pro_id);
            starting_page();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            classes.products.products_data.Delete_pro(classes.products.pro_id);
            starting_page();
        }

     
       
    }
}