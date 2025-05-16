namespace Bai1
{
    public partial class Form1 : Form
    {
        private bool isAdding = false;

        public Form1()
        {
            InitializeComponent();
            LoadUsersToListView();
            this.listViewUsers.SelectedIndexChanged += listViewUsers_SelectedIndexChanged;

        }

        private void LoadUsersToListView()
        {
            listViewUsers.Items.Clear();
            List<User> users = User.LoadUsers();
            foreach (var user in users)
            {
                var item = new ListViewItem(user.Id);
                item.SubItems.Add(user.Name);
                item.SubItems.Add(user.birthDay);
                item.SubItems.Add(user.Email);
                listViewUsers.Items.Add(item);
            }
        }
        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count > 0)
            {
                var item = listViewUsers.SelectedItems[0];
                textBox1.Text = item.SubItems[0].Text; // Mã số
                textBox2.Text = item.SubItems[1].Text; // Họ tên
                textBox3.Text = item.SubItems[2].Text; // Ngày sinh
                textBox4.Text = item.SubItems[3].Text; // Email
            }
        }
    
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!isAdding)
            {
                isAdding = true;
                addButton.Text = "Hủy";
                saveButton.Enabled = true;
                // Clear textboxes for new input
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
            }
            else
            {
                isAdding = false;
                addButton.Text = "Thêm";
                saveButton.Enabled = false;
                // Clear textboxes
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Validate input if needed
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add new user
            var user = new User(
                textBox1.Text.Trim(),
                textBox2.Text.Trim(),
                textBox3.Text.Trim(),
                textBox4.Text.Trim()
            );
            User.AddUser(user);

            // Reload ListView
            LoadUsersToListView();

            // Reset state
            isAdding = false;
            addButton.Text = "Thêm";
            saveButton.Enabled = false;

            // Clear textboxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
