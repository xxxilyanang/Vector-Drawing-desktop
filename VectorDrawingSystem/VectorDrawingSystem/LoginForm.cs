using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace VectorDrawingSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            panel1.BackgroundImage = Image.FromFile("loginbk.png");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BackgroundImage = Image.FromFile("loginbk.png");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public string Username1 => usernameTextBox.Text;
        public string Password1 => passwordTextBox.Text;
        // 登录窗口点击事件
        private void okButton_Click(object sender, EventArgs e)
        {
            if (Username1 == "" || Username1 == null || Password1 == "" || Password1 == null)
            {
                // 用户名或密码为空
                MessageBox.Show("用户名或密码不允许为空，请重新输入。", "登陆提示", MessageBoxButtons.OK);
            }
            else if (Validate(Username1,Password1))
            {
                // 如果正确，打开主窗体
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // 用户名或密码错误
                MessageBox.Show("用户名或密码错误，请重新输入。", "登陆提示", MessageBoxButtons.OK);
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
        private void linkedLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        public string Username2 => usernameTextBox2.Text;
        public string Password2 => passwordTextBox2.Text;
        // 注册窗口点击事件
        private void okButton2_Click(object sender, EventArgs e)
        {
            // 检查文件是否存在，不存在则创建
            if (!File.Exists("user_info.txt"))
            {
                File.Create("user_info.txt").Close();
            }
            // 写入用户信息到文件中
            using (StreamWriter sw = new StreamWriter("user_info.txt", true))
            {
                sw.WriteLine($"{Username2}:{Password2}");
                MessageBox.Show("注册成功。", "注册提示", MessageBoxButtons.OK);
            }
        }
        private void resetButton2_Click(object sender, EventArgs e)
        {
            usernameTextBox2.Text = "";
            passwordTextBox2.Text = "";
        }
        private void linkedLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }
        //登录比对
        private bool Validate(string username, string password)
        {
            // 检查文件是否存在，不存在则说明没有注册过用户
            if (!File.Exists("user_info.txt"))
            {
                return false;
            }

            // 读取文件中的用户信息，并逐行比对
            using (StreamReader sr = new StreamReader("user_info.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] userInfo = line.Split(':');
                    if (userInfo[0] == username && userInfo[1] == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

