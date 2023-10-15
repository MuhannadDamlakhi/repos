using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class main_form_UserControl : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public main_form_UserControl()
        {
            InitializeComponent();
        }

        
        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            added_forms.products_form products_from = new added_forms.products_form();
            products_from.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(products_from);
            products_from.FormBorderStyle = FormBorderStyle.None;
            products_from.Dock = DockStyle.Fill;
            products_from.Show();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            added_forms.cat_form cats_from = new added_forms.cat_form();
            cats_from.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(cats_from);
            cats_from.FormBorderStyle = FormBorderStyle.None;
            cats_from.Dock = DockStyle.Fill;
            cats_from.Show();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            added_forms.sales_form sales_form = new added_forms.sales_form();
            sales_form.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(sales_form);
            sales_form.FormBorderStyle = FormBorderStyle.None;
            sales_form.Dock = DockStyle.Fill;
            sales_form.Show();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            added_forms.invoices inv_form = new added_forms.invoices();
            inv_form.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(inv_form);
            inv_form.FormBorderStyle = FormBorderStyle.None;
            inv_form.Dock = DockStyle.Fill;
            inv_form.Show();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            added_forms.customers cust_form = new added_forms.customers();
            cust_form.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(cust_form);
            cust_form.FormBorderStyle = FormBorderStyle.None;
            cust_form.Dock = DockStyle.Fill;
            cust_form.Show();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            added_forms.loan loan_form = new added_forms.loan();
            loan_form.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(loan_form);
            loan_form.FormBorderStyle = FormBorderStyle.None;
            loan_form.Dock = DockStyle.Fill;
            loan_form.Show();
        }

        private void main_form_UserControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            added_forms.products_form products_from = new added_forms.products_form();
            products_from.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(products_from);
            products_from.FormBorderStyle = FormBorderStyle.None;
            products_from.Dock = DockStyle.Fill;
            products_from.Show();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            added_forms.sales_form sales_form = new added_forms.sales_form();
            sales_form.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(sales_form);
            sales_form.FormBorderStyle = FormBorderStyle.None;
            sales_form.Dock = DockStyle.Fill;
            sales_form.Show();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

            fluentDesignFormContainer1.Controls.Clear();
            added_forms.customers cust_form = new added_forms.customers();
            cust_form.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(cust_form);
            cust_form.FormBorderStyle = FormBorderStyle.None;
            cust_form.Dock = DockStyle.Fill;
            cust_form.Show();
        }
  
    }
}
