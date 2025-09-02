namespace VectorDrawingSystem
{
    partial class LoginForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkedLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usernameLabel2 = new System.Windows.Forms.Label();
            this.passwordLabel2 = new System.Windows.Forms.Label();
            this.usernameTextBox2 = new System.Windows.Forms.TextBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.okButton2 = new System.Windows.Forms.Button();
            this.resetButton2 = new System.Windows.Forms.Button();
            this.linkedLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.usernameLabel.Location = new System.Drawing.Point(95, 43);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(79, 22);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "用户名";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.passwordLabel.Location = new System.Drawing.Point(95, 87);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 22);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "密码";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(178, 40);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(190, 27);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.Text = "lcy";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(178, 84);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(190, 27);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "123456";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(126, 135);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 37);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "确定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(265, 135);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(78, 37);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "重置";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkedLabel1);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 249);
            this.panel1.TabIndex = 6;
            // 
            // linkedLabel1
            // 
            this.linkedLabel1.AutoSize = true;
            this.linkedLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkedLabel1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkedLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkedLabel1.Location = new System.Drawing.Point(123, 195);
            this.linkedLabel1.Name = "linkedLabel1";
            this.linkedLabel1.Size = new System.Drawing.Size(240, 22);
            this.linkedLabel1.TabIndex = 6;
            this.linkedLabel1.TabStop = true;
            this.linkedLabel1.Text = "没有账号？点击去注册";
            this.linkedLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkedLabel1_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkedLabel2);
            this.panel2.Controls.Add(this.resetButton2);
            this.panel2.Controls.Add(this.okButton2);
            this.panel2.Controls.Add(this.passwordTextBox2);
            this.panel2.Controls.Add(this.usernameTextBox2);
            this.panel2.Controls.Add(this.passwordLabel2);
            this.panel2.Controls.Add(this.usernameLabel2);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 249);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // usernameLabel2
            // 
            this.usernameLabel2.AutoSize = true;
            this.usernameLabel2.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.usernameLabel2.ForeColor = System.Drawing.SystemColors.Window;
            this.usernameLabel2.Location = new System.Drawing.Point(95, 43);
            this.usernameLabel2.Name = "usernameLabel2";
            this.usernameLabel2.Size = new System.Drawing.Size(79, 22);
            this.usernameLabel2.TabIndex = 0;
            this.usernameLabel2.Text = "用户名";
            // 
            // passwordLabel2
            // 
            this.passwordLabel2.AutoSize = true;
            this.passwordLabel2.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordLabel2.ForeColor = System.Drawing.SystemColors.Window;
            this.passwordLabel2.Location = new System.Drawing.Point(95, 87);
            this.passwordLabel2.Name = "passwordLabel2";
            this.passwordLabel2.Size = new System.Drawing.Size(56, 22);
            this.passwordLabel2.TabIndex = 1;
            this.passwordLabel2.Text = "密码";
            // 
            // usernameTextBox2
            // 
            this.usernameTextBox2.Location = new System.Drawing.Point(178, 40);
            this.usernameTextBox2.Name = "usernameTextBox2";
            this.usernameTextBox2.Size = new System.Drawing.Size(190, 27);
            this.usernameTextBox2.TabIndex = 7;
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Location = new System.Drawing.Point(178, 84);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.Size = new System.Drawing.Size(190, 27);
            this.passwordTextBox2.TabIndex = 8;
            // 
            // okButton2
            // 
            this.okButton2.Location = new System.Drawing.Point(126, 135);
            this.okButton2.Name = "okButton2";
            this.okButton2.Size = new System.Drawing.Size(75, 36);
            this.okButton2.TabIndex = 10;
            this.okButton2.Text = "确定";
            this.okButton2.UseVisualStyleBackColor = true;
            this.okButton2.Click += new System.EventHandler(this.okButton2_Click);
            // 
            // resetButton2
            // 
            this.resetButton2.Location = new System.Drawing.Point(265, 135);
            this.resetButton2.Name = "resetButton2";
            this.resetButton2.Size = new System.Drawing.Size(78, 36);
            this.resetButton2.TabIndex = 11;
            this.resetButton2.Text = "重置";
            this.resetButton2.UseVisualStyleBackColor = true;
            this.resetButton2.Click += new System.EventHandler(this.resetButton2_Click);
            // 
            // linkedLabel2
            // 
            this.linkedLabel2.AutoSize = true;
            this.linkedLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkedLabel2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkedLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkedLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkedLabel2.Location = new System.Drawing.Point(123, 195);
            this.linkedLabel2.Name = "linkedLabel2";
            this.linkedLabel2.Size = new System.Drawing.Size(240, 22);
            this.linkedLabel2.TabIndex = 12;
            this.linkedLabel2.TabStop = true;
            this.linkedLabel2.Text = "已有账号？点击去登录";
            this.linkedLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkedLabel2_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 251);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "欢迎登陆简易矢量图绘制系统！";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkedLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkedLabel2;
        private System.Windows.Forms.Button resetButton2;
        private System.Windows.Forms.Button okButton2;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.TextBox usernameTextBox2;
        private System.Windows.Forms.Label passwordLabel2;
        private System.Windows.Forms.Label usernameLabel2;
    }
}