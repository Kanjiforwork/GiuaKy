using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace giua_ki
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Register register = new Register();
             register.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string un = textBox_Username.Text;
            string pw = textBox_Password.Text;
            if (un.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản "); return; }
            else if (pw.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu "); return; }
            //else
            //{
            //    string query = "Select * FROM bank_account where account_id = '" + un + "' and password = '" + pw + "'";
            //    if (modify.Accounts(query).Count != 0)
            //    {
            //        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Hide();
            //        Home home = new Home();
            //        home.ShowDialog();
            //    }
           //    if( un != account_id)
            //    {
            //        MessageBox.Show("Tên tài khoản  không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
             //   if (pw != password)
            //{
            //    MessageBox.Show("Tên mat khau  không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //}
            if (account_type = "Checking")
            {
                Checking checking = new Checking();
                checking.ShowDialog();
            }
            if (account_type = "Banking")
            {
                Banking banking = new Banking();
                banking.ShowDialog();
            }

        }
    }
}
