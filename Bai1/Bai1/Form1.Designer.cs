namespace Bai1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewUsers = new ListView();
            Maso = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            addButton = new Button();
            saveButton = new Button();
            quitButton = new Button();
            SuspendLayout();
            // 
            // listViewUsers
            // 
            listViewUsers.Columns.AddRange(new ColumnHeader[] { Maso, columnHeader2, columnHeader3, columnHeader4 });
            listViewUsers.FullRowSelect = true;
            listViewUsers.GridLines = true;
            listViewUsers.Location = new Point(14, 330);
            listViewUsers.Margin = new Padding(4, 3, 4, 3);
            listViewUsers.Name = "listViewUsers";
            listViewUsers.Size = new Size(917, 111);
            listViewUsers.TabIndex = 0;
            listViewUsers.UseCompatibleStateImageBehavior = false;
            listViewUsers.View = View.Details;
            // 
            // Maso
            // 
            Maso.Text = "Mã số";
            Maso.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Họ Tên";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày Sinh";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 200;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 45);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(681, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 95);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(681, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 152);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(681, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(141, 209);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(681, 23);
            textBox4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Mã số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 156);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 212);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // addButton
            // 
            addButton.Location = new Point(316, 270);
            addButton.Margin = new Padding(4, 3, 4, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 27);
            addButton.TabIndex = 9;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(411, 270);
            saveButton.Margin = new Padding(4, 3, 4, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(88, 27);
            saveButton.TabIndex = 10;
            saveButton.Text = "Lưu";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // quitButton
            // 
            quitButton.Location = new Point(505, 270);
            quitButton.Margin = new Padding(4, 3, 4, 3);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(88, 27);
            quitButton.TabIndex = 11;
            quitButton.Text = "Thoát";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(quitButton);
            Controls.Add(saveButton);
            Controls.Add(addButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listViewUsers);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ColumnHeader Maso;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Button addButton;
        private Button saveButton;
        private Button quitButton;
    }
}

