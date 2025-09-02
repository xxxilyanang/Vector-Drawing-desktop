using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace VectorDrawingSystem
{
    public partial class MainForm : Form
    {
        private string editFileName; 
        private Image theImage; //“打开”选项产生的的图像
        private Graphics ig; 
        private Color forecolor = Color.Black;
        private Color backcolor = Color.White;
        private int fontsize = 1;

        private bool isDrawing = false;
        private bool isBline = false;
        private bool isPolygon = false;
        private Point startPoint, oldPoint;
        private List<Point> points = new List<Point>();

        private Thread clockThread; // 时钟线程

        private enum drawTools
        {
            Line = 0, Rectangle, Ellipse, BLine, Polygon, Rubber, None
        };
        private drawTools drawTool = drawTools.None;

        public MainForm()
        {
            InitializeComponent();
            Size = new Size(800, 600);
            StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;
            timeLabel.Location = new Point(ClientSize.Width - 180, ClientSize.Height - 20);
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "bmp|*bmp|wmf|*wmf|ico|*ico|cur|*cur|jpg|*jpg";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Text = "MyDraw\t" + openFileDialog1.FileName;//打开的窗体名字
                editFileName = openFileDialog1.FileName;
                theImage = Image.FromFile(openFileDialog1.FileName);
                Graphics g = this.CreateGraphics();
                g.DrawImage(theImage, this.ClientRectangle);
                ig = Graphics.FromImage(theImage);
                toolStrip1.Enabled = true;
            }
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                forecolor = colorDialog1.Color;
            }
        }

        private void fontsize1_Click(object sender, EventArgs e)
        {
            fontsize = 1;
        }
        private void fontsize2_Click(object sender, EventArgs e)
        {
            fontsize = 2;
        }
        private void fontsize3_Click(object sender, EventArgs e)
        {
            fontsize = 3;
        }
        private void fontsize4_Click(object sender, EventArgs e)
        {
            fontsize = 4;
        }
        private void fontsize5_Click(object sender, EventArgs e)
        {
            fontsize = 5;
        }
        private void Line_Click(object sender, EventArgs e)
        {
            SelectToolStripButton(Line);
            drawTool = drawTools.Line;
        }
        private void Rectangle_Click(object sender, EventArgs e)
        {
            SelectToolStripButton(Rectangle);
            drawTool = drawTools.Rectangle;
        }
        private void Ellipse_Click(object sender, EventArgs e)
        {
            SelectToolStripButton(Ellipse);
            drawTool = drawTools.Ellipse;
        }
        private void BLine_Click(object sender, EventArgs e)
        {
            SelectToolStripButton(BLine);
            drawTool = drawTools.BLine;
            isBline = true;
        }
        private void Polygon_Click(object sender, EventArgs e)
        {
            SelectToolStripButton(Polygon);
            drawTool = drawTools.Polygon;
            isPolygon = true;
        }
        private void Rubber_Click(object sender, EventArgs e)
        {
            SelectToolStripButton(Rubber);
            drawTool = drawTools.Rubber;
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
            editFileName = "新建绘图";
            this.Text = "MyDraw\t" + editFileName;
            ig = Graphics.FromImage(theImage);
            ig.Clear(backcolor);
            toolStrip1.Enabled = true;
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "图像(*.bmp)|*.bmp";
            saveFileDialog1.FileName = editFileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                theImage.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                this.Text = "MyDraw\t" + saveFileDialog1.FileName;
                editFileName = saveFileDialog1.FileName;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 指定要打开的 URL
            string url = "https://docs.microsoft.com/en-us/visualstudio/?view=vs-2022";

            try
            {
                // 启动浏览器进程，并打开指定的 URL
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectToolStripButton(ToolStripButton selectedButton)//按钮选中时变化
        {
            selectedButton.BackColor = Color.Yellow;

            foreach (ToolStripButton button in toolStrip1.Items)
            {
                if (button != selectedButton)
                {
                    button.BackColor = SystemColors.Control;
                }
                if(selectedButton != BLine)
                {
                    isBline = false;
                    points.Clear();
                }
                else if(selectedButton != Polygon)
                {
                    isPolygon = false;
                    points.Clear();
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            if (isDrawing)
            {
                switch (drawTool)
                {
                    case drawTools.None:
                        break;
                    case drawTools.Line:
                        this.Form1_Paint(this, new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
                        g.DrawLine(new Pen(forecolor, fontsize), startPoint, new Point(e.X, e.Y));
                        break;
                    case drawTools.Rectangle:
                        this.Form1_Paint(this, new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
                        g.DrawRectangle(new Pen(forecolor, fontsize), startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y);
                        break;
                    case drawTools.Ellipse:
                        this.Form1_Paint(this, new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
                        g.DrawEllipse(new Pen(forecolor, fontsize), startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y);
                        break;
                    case drawTools.BLine:
                        this.Form1_Paint(this, new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
                        if (points.Count > 1)
                        {
                            Point point1 = points[points.Count - 2];
                            Point point2 = points[points.Count - 1];
                            g.DrawLine(new Pen(forecolor, fontsize), point1, point2);
                            //for (int i = 0; i < points.Count - 1; i++)
                            //{
                            //    ig.DrawLine(new Pen(forecolor, fontsize), points[i], points[i + 1]);
                            //}
                        }
                        break;
                    case drawTools.Polygon:
                        this.Form1_Paint(this, new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
                        if (points.Count > 1)
                        {
                            for (int i = 0; i < points.Count - 1; i++)
                            {
                                g.DrawLine(new Pen(forecolor, fontsize), points[i], points[i + 1]);
                            }
                            g.DrawLine(new Pen(forecolor, fontsize), points[points.Count - 1], points[0]);//画首尾连接线           
                        }
                        break;
                    case drawTools.Rubber:
                        this.Form1_Paint(this, new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
                        g.DrawLine(new Pen(backcolor, 30), startPoint, new Point(e.X, e.Y));
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            // 启动时钟线程
            clockThread = new Thread(new ThreadStart(UpdateClock));
            clockThread.IsBackground = true; // 设置为后台线程
            clockThread.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)//画出theImage
        {
            Graphics g = this.CreateGraphics();          
            if (theImage != null)
            {
                g.Clear(backcolor);
                g.DrawImage(theImage, this.ClientRectangle);
            }
            //points.Clear();//放到折线按钮下吗？
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = new Point(e.X, e.Y);
                oldPoint = new Point(e.X, e.Y);
                if (isBline||isPolygon)
                {
                    points.Add(new Point(e.X, e.Y));
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 关闭登录窗体
            Application.OpenForms["LoginForm"].Close();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            Graphics g = this.CreateGraphics();
            switch (drawTool)
            {
                case drawTools.Line:
                    ig.DrawLine(new Pen(forecolor, fontsize), startPoint, new Point(e.X, e.Y));
                    break;
                case drawTools.Rectangle:
                    ig.DrawRectangle(new Pen(forecolor, fontsize), startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y);
                    break;
                case drawTools.Ellipse:
                    ig.DrawEllipse(new Pen(forecolor, fontsize), startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y);
                    break;
                case drawTools.BLine:
                    if (points.Count > 1)
                    {
                        Point point1 = points[points.Count - 2];
                        Point point2 = points[points.Count - 1];
                        ig.DrawLine(new Pen(forecolor, fontsize), point1, point2);
                        //for (int i = 0; i < points.Count - 1; i++)
                        //{
                        //    ig.DrawLine(new Pen(forecolor, fontsize), points[i], points[i + 1]);
                        //}
                    }
                    break;
                case drawTools.Polygon:
                    if (points.Count > 1)
                    {
                        for (int i = 0; i < points.Count - 1; i++)
                        {
                            ig.DrawLine(new Pen(forecolor, fontsize), points[i], points[i + 1]);
                        }
                        ig.DrawLine(new Pen(forecolor, fontsize), points[points.Count - 1], points[0]);//画首尾连接线           
                    }                               
                    break;
                case drawTools.Rubber:
                    ig.DrawLine(new Pen(backcolor, 30), startPoint, new Point(e.X, e.Y));
                    break;
            }
        }

        // 更新系统时间的方法
        private void UpdateClock()
        {
            while (true)
            {
                // 获取当前系统时间
                DateTime now = DateTime.Now;

                // 更新UI
                this.Invoke((MethodInvoker)delegate
                {
                    // 在label中显示系统时间
                    timeLabel.Text = now.ToString("yyyy-MM-dd HH:mm:ss");
                });

                Thread.Sleep(1000); // 休眠1秒
            }
        }
    }
}
