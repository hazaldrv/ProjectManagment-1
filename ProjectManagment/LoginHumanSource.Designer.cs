﻿
namespace ProjectManagment
{
    partial class LoginHumanSource
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnLogin = new System.Windows.Forms.Button();
      this.btnBack = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.button4 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(57, 153);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(213, 36);
      this.label1.TabIndex = 0;
      this.label1.Text = "USERNAME: ";
      // 
      // txtUserName
      // 
      this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtUserName.Location = new System.Drawing.Point(286, 147);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(368, 41);
      this.txtUserName.TabIndex = 1;
      // 
      // txtPassword
      // 
      this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtPassword.Location = new System.Drawing.Point(286, 201);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(368, 41);
      this.txtPassword.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.Location = new System.Drawing.Point(57, 207);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(198, 36);
      this.label2.TabIndex = 2;
      this.label2.Text = "PASSWORD";
      // 
      // btnLogin
      // 
      this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnLogin.Location = new System.Drawing.Point(297, 255);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(166, 63);
      this.btnLogin.TabIndex = 4;
      this.btnLogin.Text = "LOGIN";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // btnBack
      // 
      this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnBack.Location = new System.Drawing.Point(533, 255);
      this.btnBack.Name = "btnBack";
      this.btnBack.Size = new System.Drawing.Size(121, 63);
      this.btnBack.TabIndex = 5;
      this.btnBack.Text = "BACK";
      this.btnBack.UseVisualStyleBackColor = true;
      this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.Location = new System.Drawing.Point(37, 30);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(341, 44);
      this.label3.TabIndex = 6;
      this.label3.Text = "HUMAN SOURCE";
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.checkBox1.Location = new System.Drawing.Point(660, 207);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(88, 29);
      this.checkBox1.TabIndex = 22;
      this.checkBox1.Text = "Show";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 77);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(786, 10);
      this.progressBar1.TabIndex = 23;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(757, 12);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(79, 53);
      this.button4.TabIndex = 24;
      this.button4.Text = "exit";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // LoginHumanSource
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(848, 605);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnBack);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtUserName);
      this.Controls.Add(this.label1);
      this.Name = "LoginHumanSource";
      this.Text = "LoginHumanSource";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Button button4;
  }
}