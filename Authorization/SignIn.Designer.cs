
namespace Authorization
{
    partial class SignIn
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
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.l_Name = new System.Windows.Forms.Label();
            this.btn_Main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(180, 45);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(100, 20);
            this.tb_Login.TabIndex = 0;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(180, 86);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(100, 20);
            this.tb_Password.TabIndex = 1;
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Location = new System.Drawing.Point(180, 86);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(100, 23);
            this.btn_SignIn.TabIndex = 2;
            this.btn_SignIn.Text = "button1";
            this.btn_SignIn.UseVisualStyleBackColor = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(221, 13);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(35, 13);
            this.l_Name.TabIndex = 3;
            this.l_Name.Text = "label1";
            // 
            // btn_Main
            // 
            this.btn_Main.Location = new System.Drawing.Point(13, 86);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(75, 23);
            this.btn_Main.TabIndex = 4;
            this.btn_Main.Text = "button1";
            this.btn_Main.UseVisualStyleBackColor = true;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 129);
            this.Controls.Add(this.btn_Main);
            this.Controls.Add(this.l_Name);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Login);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Button btn_Main;
    }
}