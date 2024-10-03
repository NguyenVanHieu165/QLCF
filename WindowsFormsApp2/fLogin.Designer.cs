namespace WindowsFormsApp2
{
    partial class fLogin
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
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.labelmk = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbUseName = new System.Windows.Forms.TextBox();
            this.labeldn = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(305, 97);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbPassWord);
            this.panel1.Controls.Add(this.labelmk);
            this.panel1.Location = new System.Drawing.Point(7, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 41);
            this.panel1.TabIndex = 0;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(142, 10);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(255, 20);
            this.txbPassWord.TabIndex = 2;
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // labelmk
            // 
            this.labelmk.AutoSize = true;
            this.labelmk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmk.Location = new System.Drawing.Point(3, 9);
            this.labelmk.Name = "labelmk";
            this.labelmk.Size = new System.Drawing.Size(78, 19);
            this.labelmk.TabIndex = 0;
            this.labelmk.Text = "Mật khẩu\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbUseName);
            this.panel2.Controls.Add(this.labeldn);
            this.panel2.Location = new System.Drawing.Point(7, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 41);
            this.panel2.TabIndex = 1;
            // 
            // txbUseName
            // 
            this.txbUseName.Location = new System.Drawing.Point(142, 8);
            this.txbUseName.Name = "txbUseName";
            this.txbUseName.Size = new System.Drawing.Size(255, 20);
            this.txbUseName.TabIndex = 1;
            // 
            // labeldn
            // 
            this.labeldn.AutoSize = true;
            this.labeldn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldn.Location = new System.Drawing.Point(3, 9);
            this.labeldn.Name = "labeldn";
            this.labeldn.Size = new System.Drawing.Size(124, 19);
            this.labeldn.TabIndex = 0;
            this.labeldn.Text = "Tên đăng nhập";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 128);
            this.panel3.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(187, 97);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(99, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // fLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogin;
            this.ClientSize = new System.Drawing.Size(470, 145);
            this.Controls.Add(this.panel3);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbPassWord;
        protected internal System.Windows.Forms.Label labelmk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbUseName;
        protected internal System.Windows.Forms.Label labeldn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogin;
    }
}

