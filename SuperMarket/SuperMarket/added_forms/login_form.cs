using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }
        classes.users ncls = new classes.users();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1_users_name.DataSource = classes.users.users_data.GetData();
            comboBox1_users_name.ValueMember = "usr_name";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ncls.user_list(comboBox1_users_name.Text, textEdit1_users_pw.Text);
            if (classes.users.user_id == 0)
            {
                MessageBox.Show("تأكد من اسم المستخدم وكلمة المرور");
            }
            else 
            {
                this.Hide();
                main_form_UserControl form = new main_form_UserControl();
                form.Show();
                MessageBox.Show("أهلاً وسهلاً بك "+classes.users.userName);
            }
        }
    }
}
