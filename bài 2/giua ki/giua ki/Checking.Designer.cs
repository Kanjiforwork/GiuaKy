namespace giua_ki
{
    partial class Checking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_deposit = new System.Windows.Forms.Button();
            this.button_displaytransaction = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(184, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "owner_name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "owner_address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "owner_phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "balance";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(211, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 18);
            this.panel2.TabIndex = 5;
            // 
            // button_deposit
            // 
            this.button_deposit.Location = new System.Drawing.Point(110, 256);
            this.button_deposit.Name = "button_deposit";
            this.button_deposit.Size = new System.Drawing.Size(78, 41);
            this.button_deposit.TabIndex = 6;
            this.button_deposit.Text = "Deposit";
            this.button_deposit.UseVisualStyleBackColor = true;
            this.button_deposit.Click += new System.EventHandler(this.button_deposit_Click);
            // 
            // button_displaytransaction
            // 
            this.button_displaytransaction.Location = new System.Drawing.Point(271, 256);
            this.button_displaytransaction.Name = "button_displaytransaction";
            this.button_displaytransaction.Size = new System.Drawing.Size(78, 41);
            this.button_displaytransaction.TabIndex = 7;
            this.button_displaytransaction.Text = "Display Transaction";
            this.button_displaytransaction.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 315);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 105);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(211, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(87, 18);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(211, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(87, 18);
            this.panel4.TabIndex = 10;
            // 
            // Checking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_displaytransaction);
            this.Controls.Add(this.button_deposit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Checking";
            this.Text = "Checking";
            this.Load += new System.EventHandler(this.Checking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_deposit;
        private System.Windows.Forms.Button button_displaytransaction;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}