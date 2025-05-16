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
using WindowsFormsApp1.Model;

namespace giua_ki
{
    public partial class Login : Form
    {
        static void CreateDatabase()
        {
            var database = new BankSystemDBContext();
            database.Database.EnsureCreated();
        }

        static void DropDatabase()
        {
            var database = new BankSystemDBContext();
            database.Database.EnsureDeleted();
        }


        static void SampleData(BankSystemDBContext db)
        {

            var account = new Bank_account("khach hang 1", "hanoi", "025684884654", 200000, "checking", "khachhang1");
            db.bank_accounts.Add(account);
            db.SaveChanges();

             account = new Bank_account("khach hang 2", "hanoi", "025684884654", 400000, "banking", "khachhang2");
            db.bank_accounts.Add(account);
            db.SaveChanges();

            account = new Bank_account("khach hang 3", "hcm", "025566524654", 400000, "banking", "khachhang3");
            db.bank_accounts.Add(account);
            db.SaveChanges();

            var tran = new Transactions(1, DateTime.Now.AddYears(-22), "nap tien", "nap tien 100000");
            db.transactions.Add(tran);
            db.SaveChanges();

            tran = new Transactions(1, DateTime.Now.AddYears(-12), "nap tien", "nap tien 100500");
            db.transactions.Add(tran);
            db.SaveChanges();
        }
        
          
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            var db = new BankSystemDBContext();
            CreateDatabase();
            SampleData(db);


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
            int un = int.Parse(textBox_Username.Text);
            string pw = textBox_Password.Text;
            if (un.ToString().Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản "); return; }
            else if (pw.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu "); return; }
         

            var db = new BankSystemDBContext();
            var acountid = from id in db.bank_accounts
                           select id.account_id;
            if (acountid.Contains(un))
            {
                var password = from id in db.bank_accounts
                               where id.account_id == un
                               select id.password;

                var type = (from ba in db.bank_accounts
                               where ba.account_id == un
                               select ba.accout_type).FirstOrDefault();
                if (password.FirstOrDefault() == pw)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    if (type == "checking")
                    {
                        var checking = new Checking();
                        checking.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tên tài khoản không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
    }
}}
