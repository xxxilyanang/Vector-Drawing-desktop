using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace VectorDrawingSystem
{
    public partial class SplashScreenForm : Form
    {
        private readonly System.Windows.Forms.Timer timer;
        private readonly Image backgroundImage;
        private readonly int interval;
        private ProgressBar progressBar;
        private int currentProgress = 0; // 当前进度
        private Label label;
        public SplashScreenForm(Image backgroundImage, int interval)
        {
            InitializeComponent();
            // 添加进度条
            progressBar = new ProgressBar();
            progressBar.Size = new Size(760, 30);
            progressBar.Location = new Point(10, 410);
            progressBar.Maximum = 100;
            Controls.Add(progressBar);

            // 添加提示文本
            label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Arial", 12, FontStyle.Bold);
            label.Location = new Point(240, 380);
            Controls.Add(label);

            this.backgroundImage = backgroundImage;
            this.interval = interval;
            BackgroundImage = backgroundImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            StartPosition = FormStartPosition.CenterScreen;

            timer = new System.Windows.Forms.Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = interval;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs args)
        {
            // 更新进度条
            currentProgress++;
            progressBar.Value = currentProgress;
            label.Text = $"欢迎使用“易矢绘”！正在加载程序... {currentProgress}%";

            // 检查是否达到100%
            if (currentProgress >= 100)
            {
                timer.Stop();
                Close();
            }
        }
    }
}

