﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.added_forms
{
    public partial class cat_form : DevExpress.XtraEditors.XtraForm
    {
        public cat_form()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            catsTableAdapter3.Fill(dataSet13.Cats);
        }


        classes.cats ncls_cat = new classes.cats();
        public void starting_page()
        {
            gridControl1.DataSource = ncls_cat.data_list(text_search.Text);
            gridView1.Columns.Remove(gridView1.Columns["cat_id"]);
            gridView1.Columns["cat_name"].Caption = "اسم الفئة";
            gridView1.Columns["cat_notes"].Caption = "ملاحظات الفئة";

            text_name.Text = "";
            text_note.Text = "";

        }

       
        private void cat_form_Load(object sender, EventArgs e)
        {
            starting_page();
        }

        private void text_search_EditValueChanged(object sender, EventArgs e)
        {
            starting_page();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (text_name.Text != "" )
            {
                classes.cats.cat_data.InsertCatagory(text_name.Text, text_note.Text);

                starting_page();
            }

            
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            ncls_cat.data_list(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["cat_name"]).ToString());

            text_name.Text = classes.cats.cat_name;
            text_note.Text = classes.cats.cat_notes;
            

       }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            classes.cats.cat_data.Update_cats(text_name.Text, text_note.Text, classes.cats.cat_id, classes.cats.cat_id);
            starting_page();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                classes.cats.cat_data.Delete_cats(classes.cats.cat_id);
                starting_page();

            }
            catch (Exception )
            {
                MessageBox.Show("لاي يمكنك مسح الفئة لوجود أصناف متعلقة بها");
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

       
        

       
       

       
        }
}