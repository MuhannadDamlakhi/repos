﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace SuperMarket.added_forms
{
    public partial class sales_form : DevExpress.XtraEditors.XtraForm
    {

        public sales_form()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            //productsTableAdapter2.Fill(dataSet13.Products);
        }
        int tot_qunatity;
        int tot_total;
        int canIAddCust;
        public static bool isNewCustomer;

        public void sum_data()
        {
            DataTable dt = new DataTable();
            dt = classes.sales.sale_data.totals();
            if ((int.TryParse(dt.Rows[0]["sum_quantity"].ToString(), out tot_qunatity)) && (int.TryParse(dt.Rows[0]["sum_total"].ToString(), out tot_total)))
            {
                labelControl12.Text = tot_qunatity.ToString();
                labelControl11.Text = tot_total.ToString();
            }
            else
            {
                labelControl12.Text = "0";
                labelControl11.Text = "0";
            }

        }

        classes.products ncls_pro = new classes.products();
        classes.sales ncls_sale = new classes.sales();
        classes.customers ncls_cust = new classes.customers();
        classes.Invoices ncls_inv = new classes.Invoices();
        classes.loan ncls_loan = new classes.loan();
        classes.salesList ncls_salelist = new classes.salesList();
        int id_x;
        int price_x;
        int quan_x;
        int id_xx;
        int quan_xx;
        int id_xx_sale;
        int id_xx_salelist;

        public void starting_page()
        {
            gridControl1.DataSource = ncls_pro.data_list(text_search.Text);
            gridControl2.DataSource = ncls_sale.data_list("");
            sale_type.Enabled = true;
            sale_type.Text = "";
            push_type.Enabled = false;
            text_quantity.Enabled = false;
            text_cust.Enabled = false;
            text_cust_number.Enabled = false;
            text_cust_address.Enabled = false;
            labelControl10.Text = "اختر منتجاً من فضلك";
            GridView gridv = gridControl2.MainView as GridView;
            if (gridv != null && gridv.RowCount > 0)
            {
                sale_type.Enabled = false;
            }
            else
            {
                sale_type.Enabled = true;
                sale_type.Text = "";
                canIAddCust = 0;
                isNewCustomer = false;
            }

        }

        private void sales_from_Load(object sender, EventArgs e)
        {
            starting_page();
            sum_data();
        }

        private void sale_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sale_type.Text == "طلبية")
            {
                push_type.Text = "آجل";
                text_quantity.Enabled = true;
                text_cust.Enabled = true;
                text_cust_number.Enabled = true;
                text_cust_address.Enabled = true;
                classes.customers.cust_name = null;
                classes.customers.cust_phone = null;
                classes.customers.cust_address = null;
                text_cust.Text = "";
                text_cust_number.Text = "";
                text_cust_address.Text = "";
                text_quantity.Text = "";
            }
            else if (sale_type.Text == "مبيع فوري")
            {
                push_type.Text = "نقداً";
                text_quantity.Enabled = true;
                text_cust.Enabled = false;
                text_cust_number.Enabled = false;
                text_cust_address.Enabled = false;
                text_cust.Text = "نقداً";
                text_cust_number.Text = "نقداً";
                text_cust_address.Text = "نقداً";
                text_quantity.Text = "";
            }
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sale_type.Text == "مبيع فوري") || (sale_type.Text == "طلبية"))
                {
                    if (sale_type.Text == "طلبية")
                    {
                        if (text_cust.Text != "" || text_cust_number.Text != "" || text_cust_address.Text != "" && text_quantity.Text != "")
                        {
                            if (Convert.ToInt32(text_quantity.Text) > 0)
                            {
                                if (Convert.ToInt32(text_quantity.Text) <= classes.products.pro_qnty && classes.products.pro_qnty > 0)
                                {
                                    int total = price_x * Convert.ToInt32(text_quantity.Text);
                                    classes.sales.sale_data.Insert_sal(sale_type.Text,
                                    push_type.Text,
                                    Convert.ToInt32(text_quantity.Text),
                                    total, Convert.ToDateTime(string.Format(DateTime.Now.ToShortDateString(), "yyyy/mm/dd").ToString()),
                                    DateTime.Now.TimeOfDay,
                                    id_x);
                                    int quan_result = quan_x - Convert.ToInt32(text_quantity.Text);
                                    classes.products.products_data.Update_quantity(quan_result, classes.products.pro_id);

                                    if (isNewCustomer==true)
                                    {
                                        canIAddCust++;
                                       
                                        if (canIAddCust == 1)
                                        {

                                            classes.customers.cust_data.Insert_cust(text_cust.Text, text_cust_number.Text, text_cust_address.Text);
                                            ncls_cust.data_list_choose(text_cust.Text, text_cust_number.Text, text_cust_address.Text);
                                        }
                                    }

                                    classes.salesList.sale_list_data.Insert_sale_list(id_x, classes.customers.cust_id);

                                    gridControl1.DataSource = ncls_pro.data_list(text_search.Text);
                                    gridControl2.DataSource = ncls_sale.data_list("");
                                    sale_type.Enabled = false;
                                    push_type.Enabled = false;
                                    text_quantity.Enabled = true;
                                    text_cust.Enabled = false;
                                    text_cust_number.Enabled = false;
                                    text_cust_address.Enabled = false;
                                    text_quantity.Text = "";
                                    sum_data();

                                    ncls_pro.data_list(gridView12.GetRowCellValue(gridView12.FocusedRowHandle, gridView12.Columns["pro_name"]).ToString());
                                    id_x = classes.products.pro_id;
                                    price_x = classes.products.pro_price;
                                    quan_x = classes.products.pro_qnty;
                                    labelControl10.Text = classes.products.pro_name;

                                }
                                else
                                {
                                    MessageBox.Show("إما أنك لم تختر منتجاً من القائمة أو \nأنه لا توجد لديك الكمية الكافية من البضاعة المطلوبة لإتمام عملية البيع");
                                }
                            }
                            else
                            {
                                MessageBox.Show("لا يسمح بإدخال كمية بهكذا شكل");
                            }

                        }
                        else
                        {
                            MessageBox.Show("تأكد من إدخال بيانات الكمية و بيانات الزبون");
                        }

                    }


                    else if (sale_type.Text == "مبيع فوري")
                    {
                        if (text_quantity.Text != "")
                        {
                            if (Convert.ToInt32(text_quantity.Text) > 0)
                            {
                                if (Convert.ToInt32(text_quantity.Text) <= classes.products.pro_qnty && classes.products.pro_qnty > 0)
                                {
                                    canIAddCust++;
                                    if (canIAddCust == 1)
                                    {
                                    classes.customers.cust_data.Insert_cust("نقداً", "نقداً", "نقداً");
                                    }

                                    ncls_cust.data_list();
                                    classes.salesList.sale_list_data.Insert_sale_list(id_x, classes.customers.cust_id);


                                    int total = price_x * Convert.ToInt32(text_quantity.Text);
                                    classes.sales.sale_data.Insert_sal(sale_type.Text,
                                    push_type.Text,
                                    Convert.ToInt32(text_quantity.Text),
                                    total, Convert.ToDateTime(string.Format(DateTime.Now.ToShortDateString(), "yyyy/mm/dd").ToString()),
                                    DateTime.Now.TimeOfDay,
                                    id_x);
                                    int quan_result = quan_x - Convert.ToInt32(text_quantity.Text);
                                    classes.products.products_data.Update_quantity(quan_result, classes.products.pro_id);

                                    gridControl1.DataSource = ncls_pro.data_list(text_search.Text);
                                    gridControl2.DataSource = ncls_sale.data_list("");
                                    sale_type.Enabled = false;
                                    push_type.Enabled = false;
                                    text_quantity.Enabled = true;
                                    text_cust.Enabled = false;
                                    text_cust_number.Enabled = false;
                                    text_cust_address.Enabled = false;
                                    text_quantity.Text = "";
                                    sum_data();

                                    ///////الكود اللي تحت مشان يحدث قيم الكميات الاساسية مشان يجمع ويطرح مزبوط بالنتيجة
                                    ncls_pro.data_list(gridView12.GetRowCellValue(gridView12.FocusedRowHandle, gridView12.Columns["pro_name"]).ToString());
                                    id_x = classes.products.pro_id;
                                    price_x = classes.products.pro_price;
                                    quan_x = classes.products.pro_qnty;
                                    labelControl10.Text = classes.products.pro_name;

                                }
                                else
                                {
                                    MessageBox.Show("إما أنك لم تختر منتجاً من القائمة أو \nأنه لا توجد لديك الكمية الكافية من البضاعة المطلوبة لإتمام عملية البيع");
                                }
                            }
                            else
                            {
                                MessageBox.Show("لا يسمح بإدخال كمية بهكذا شكل");
                            }

                        }
                        else
                        {
                            MessageBox.Show("تأكد من إدخال بيانات الكمية");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("اختر نوع البيع من فضلك");
                    starting_page();
                }
            }
            catch (Exception m)
            {

                MessageBox.Show(m.ToString());
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GridView gridvi = gridControl2.MainView as GridView;
            if (gridvi != null && gridvi.RowCount > 0)
            {
                MessageBox.Show("لا يمكن ترك المبيعات بهذا الشكل, امسح المبيعات ,أو أنشئ فاتورة بها");
            }
            else
            {
                this.Close();
            }

        }

        private void text_search_EditValueChanged(object sender, EventArgs e)
        {
            ncls_pro.data_list(text_search.Text);
            starting_page();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

            ncls_pro.data_list(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["pro_name"]).ToString());
            ncls_sale.data_list(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["pro_name"]).ToString());
            //ncls_cust.data_list();
            ncls_salelist.data_list(classes.products.pro_id,
                                    classes.customers.cust_id);
            id_xx_salelist = classes.salesList.salesList_id;
            id_xx_sale = classes.sales.sales_id;
            id_xx = classes.products.pro_id;
            quan_xx = classes.products.pro_qnty;
            labelControl10.Text = classes.products.pro_name;

            text_quantity.Text = classes.sales.sales_qnty.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                GridView gridvie = gridControl2.MainView as GridView;

                classes.sales.sale_data.Delete_sale(id_xx_sale);
                classes.salesList.sale_list_data.Delete_salelist(id_xx_salelist);

                int qun_result = quan_xx + Convert.ToInt32(text_quantity.Text);

                classes.products.products_data.Update_quantity(qun_result, id_xx);

                gridControl1.DataSource = ncls_pro.data_list(text_search.Text);
                gridControl2.DataSource = ncls_sale.data_list("");
                if (gridvie != null && gridvie.RowCount > 0)
                {
                    sale_type.Enabled = false;
                }
                else
                {
                    sale_type.Enabled = true;
                    sale_type.Text = "";

                    canIAddCust = 0;
                    isNewCustomer = false;


                }

                push_type.Enabled = false;
                text_quantity.Enabled = true;
                text_cust.Enabled = false;
                text_cust_number.Enabled = false;
                text_cust_address.Enabled = false;
                text_cust.Text = "";
                text_cust_number.Text = "";
                text_cust_address.Text = "";
                text_quantity.Text = "";
                sum_data();
            }
            catch (Exception)
            {

                MessageBox.Show("اختر إحدى المبيعات للحذف من فضلك");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            StringBuilder valueBuilder = new StringBuilder();
            GridView gridview = gridControl2.MainView as GridView;
            if (gridview != null && gridview.RowCount > 0)
            {
                for (int rowindex = 0; rowindex < gridview.RowCount; rowindex++)
                {
                    DataRow row = gridview.GetDataRow(rowindex);
                    object cellValue = row["pro_name"];
                    valueBuilder.Append(cellValue.ToString());
                    valueBuilder.Append(",");
                }
                string columnValuesString = valueBuilder.ToString().TrimEnd(',');
                classes.Invoices.inv_data.Insert_inv(string.Format(DateTime.Now.ToShortDateString(), "yyyy/mm/dd").ToString(),
                                                     DateTime.Now.TimeOfDay.ToString(),
                                                     tot_total,
                                                     sale_type.Text,
                                                     columnValuesString,
                                                     classes.customers.cust_id);

                MessageBox.Show("تم توليد الفاتورة وحفظها بقائمة الفواتير");

                DialogResult result = MessageBox.Show("هل تريد طباعة هذه الفاتورة؟", "الفاتورة جاهزة", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    printPreviewDialog1.ShowDialog();
                    printDocument1.Print();
                }

                classes.sales.sale_data.Delete_sale_after_inv_creation();

                starting_page();

                ncls_inv.data_list();
                classes.loan.loan_data.Insert_loan(string.Format(DateTime.Now.ToShortDateString(), "yyyy/mm/dd").ToString(), DateTime.Now.TimeOfDay.ToString(), columnValuesString, classes.Invoices.inv_id);
                MessageBox.Show("تمت الإضافة إلى قائمة الديون");
            }
            else
            {
                MessageBox.Show("لا توجد مبيعات بعد لإنشاء الفاتورة");
            }
        }

        private void gridView12_DoubleClick(object sender, EventArgs e)
        {
            ncls_pro.data_list(gridView12.GetRowCellValue(gridView12.FocusedRowHandle, gridView12.Columns["pro_name"]).ToString());
            id_x = classes.products.pro_id;
            price_x = classes.products.pro_price;
            quan_x = classes.products.pro_qnty;
            labelControl10.Text = classes.products.pro_name;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int margin = 30;
            Font f = new Font("Times New Roman", 18, FontStyle.Bold);
            e.Graphics.DrawImage(Properties.Resources._384999, 30, 30, 200, 200);

            string str_user = ": تم تحرير الفاتورة من قبل" + classes.users.userName;
            string str_Date = "التاريخ :" + DateTime.Now.ToShortDateString();
            string str_Time = "الوقت :" + DateTime.Now.ToShortTimeString();
            string str_CustName = "المطلوب من السيد " + text_cust.Text + " المحترم";
            string str_Total = tot_total + "الإجمالي";

            SizeF str_user_Size = e.Graphics.MeasureString(str_user, f);
            SizeF str_Data_Size = e.Graphics.MeasureString(str_Date, f);
            SizeF str_Time_Size = e.Graphics.MeasureString(str_Time, f);
            SizeF str_CustName_Size = e.Graphics.MeasureString(str_CustName, f);
            SizeF str_Total_Size = e.Graphics.MeasureString(str_Total, f);

            ////رسم العناوين
            e.Graphics.DrawString(str_user, f, Brushes.Black, (e.PageBounds.Width - str_user_Size.Width) / 2, margin);
            e.Graphics.DrawString(str_Date, f, Brushes.Black, (e.PageBounds.Width - str_Data_Size.Width - margin), margin + str_user_Size.Height);
            e.Graphics.DrawString(str_Time, f, Brushes.Black, (e.PageBounds.Width - str_Time_Size.Width - margin), margin + str_user_Size.Height + str_Data_Size.Height);
            e.Graphics.DrawString(str_CustName, f, Brushes.Black, (e.PageBounds.Width - str_CustName_Size.Width - margin), margin + str_user_Size.Height + str_Data_Size.Height + 70);

            float preHeights = margin + str_user_Size.Height + str_Data_Size.Height + str_Time_Size.Height + str_CustName_Size.Height + 70;
            ////رسم مستطيل الفاتورة
            e.Graphics.DrawRectangle(Pens.Black, margin, preHeights, e.PageBounds.Width - margin * 2, e.PageBounds.Height - preHeights - margin);

            int rowheight = 50;


            /////رسم الخطوط الطولية
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width / 4, preHeights, e.PageBounds.Width / 4, e.PageBounds.Height - margin);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width / 2, preHeights, e.PageBounds.Width / 2, e.PageBounds.Height - margin);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width * 3 / 4, preHeights, e.PageBounds.Width * 3 / 4, e.PageBounds.Height - margin);
            ///رسم الاسماء
            e.Graphics.DrawString("اسم المنتج", f, Brushes.Black, e.PageBounds.Width - 155, 240);
            e.Graphics.DrawString("الكمية", f, Brushes.Black, e.PageBounds.Width - 330, 240);
            e.Graphics.DrawString("القيمة", f, Brushes.Black, e.PageBounds.Width - 575, 240);
            e.Graphics.DrawString("نوع الدفع", f, Brushes.Black, e.PageBounds.Width - 780, 240);
            ////رسم الخط العرضي للعناوين
            e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowheight, e.PageBounds.Width - margin, preHeights + rowheight);

            GridView gridview2 = gridControl2.MainView as GridView;

            int rowCount = gridview2.RowCount;

            for (int i = 0; i < rowCount; i++)
            {
                e.Graphics.DrawString(gridview2.GetRowCellValue(i, gridview2.Columns[4]).ToString(), f, Brushes.Black, e.PageBounds.Width - 155, 240 + rowheight);
                e.Graphics.DrawString(gridview2.GetRowCellValue(i, gridview2.Columns[2]).ToString(), f, Brushes.Black, e.PageBounds.Width - 330, 240 + rowheight);
                e.Graphics.DrawString(gridview2.GetRowCellValue(i, gridview2.Columns[3]).ToString(), f, Brushes.Black, e.PageBounds.Width - 575, 240 + rowheight);
                e.Graphics.DrawString(gridview2.GetRowCellValue(i, gridview2.Columns[0]).ToString(), f, Brushes.Black, e.PageBounds.Width - 780, 240 + rowheight);

                rowheight += 50;

                e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowheight, e.PageBounds.Width - margin, preHeights + rowheight);

            }
            /////رسم آخر الفاتورة
            e.Graphics.DrawLine(Pens.Red, margin, e.PageBounds.Height - margin - 50, e.PageBounds.Width - margin, e.PageBounds.Height - margin - 50);
            e.Graphics.DrawString("الإجمالي الكلي", f, Brushes.Red, e.PageBounds.Width - 190, e.PageBounds.Height - margin - 40);
            e.Graphics.DrawString(tot_total.ToString(), f, Brushes.DarkRed, e.PageBounds.Width - 575, e.PageBounds.Height - margin - 40);
            e.Graphics.DrawString(tot_qunatity.ToString(), f, Brushes.Red, e.PageBounds.Width - 330, e.PageBounds.Height - margin - 40);




        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            GridView gridvw = gridControl2.MainView as GridView;
            if (gridvw != null)
            {


                ///////تحديث الكميات بعد حذف المبيعات
                for (int i = 0; i < gridvw.RowCount; i++)
                {///////احضار الكميات وفق الاسم من جدول المبيعات وتخزين الكميات في مربع نص الكمية ثم ارجاعه الى كميته الاساسية
                    ncls_pro.data_list(gridvw.GetRowCellValue(i, gridvw.Columns["pro_name"]).ToString());
                    ncls_sale.data_list(gridvw.GetRowCellValue(i, gridvw.Columns["pro_name"]).ToString());
                    text_quantity.Text = classes.sales.sales_qnty.ToString();
                    int quan_xyx = classes.products.pro_qnty;
                    id_xx = classes.products.pro_id;

                    int qunn_result = quan_xyx + Convert.ToInt32(text_quantity.Text);

                    classes.products.products_data.Update_quantity(qunn_result, id_xx);
                }

                ncls_cust.data_list();
                classes.customers.cust_data.Delete_cust(classes.customers.cust_id);
                classes.sales.sale_data.Delete_sale_after_inv_creation();

                gridControl1.DataSource = ncls_pro.data_list(text_search.Text);
                gridControl2.DataSource = ncls_sale.data_list("");
                sale_type.Enabled = true;
                text_cust.Text="";
                text_cust_number.Text = "";
                text_cust_address.Text = "";
                text_cust.Enabled = false;
                text_cust_number.Enabled = false;
                text_cust_address.Enabled = false;
                sale_type.Text = "";                
                text_quantity.Text = "";
                canIAddCust = 0;
                isNewCustomer = false;

            }
            else
            {
                MessageBox.Show("لا يوجد مبيعات لحذفها");
            }
        }

        private void text_cust_Click(object sender, EventArgs e)
        {
            added_forms.customersChoosing form = new customersChoosing();
            form.Show();
        }

        private void text_cust_number_Click(object sender, EventArgs e)
        {
            added_forms.customersChoosing form = new customersChoosing();
            form.Show();
        }

        private void text_cust_address_Click(object sender, EventArgs e)
        {
            added_forms.customersChoosing form = new customersChoosing();
            form.Show();
        }

        private void sales_form_MouseMove(object sender, MouseEventArgs e)
        {
            if (sale_type.Text == "طلبية")
            {
                text_cust.Text = classes.customers.cust_name;
                text_cust_number.Text = classes.customers.cust_phone;
                text_cust_address.Text = classes.customers.cust_address;
            }
        }

        private void groupControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sale_type.Text == "طلبية")
            {
                text_cust.Text = classes.customers.cust_name;
                text_cust_number.Text = classes.customers.cust_phone;
                text_cust_address.Text = classes.customers.cust_address;
            }
        }

        private void groupControl3_MouseMove(object sender, MouseEventArgs e)
        {
            if (sale_type.Text == "طلبية")
            {
                text_cust.Text = classes.customers.cust_name;
                text_cust_number.Text = classes.customers.cust_phone;
                text_cust_address.Text = classes.customers.cust_address;
            }
        }

        private void gridControl2_MouseMove(object sender, MouseEventArgs e)
        {
            if (sale_type.Text == "طلبية")
            {
                text_cust.Text = classes.customers.cust_name;
                text_cust_number.Text = classes.customers.cust_phone;
                text_cust_address.Text = classes.customers.cust_address;
            }
        }


        private void gridControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sale_type.Text == "طلبية")
            {
                text_cust.Text = classes.customers.cust_name;
                text_cust_number.Text = classes.customers.cust_phone;
                text_cust_address.Text = classes.customers.cust_address;
            }
        }
    }
}