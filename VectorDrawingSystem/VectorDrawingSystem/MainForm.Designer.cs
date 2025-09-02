namespace VectorDrawingSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.画笔粗细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsize1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsize2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsize3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsize4 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsize5 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Line = new System.Windows.Forms.ToolStripButton();
            this.Rectangle = new System.Windows.Forms.ToolStripButton();
            this.Ellipse = new System.Windows.Forms.ToolStripButton();
            this.BLine = new System.Windows.Forms.ToolStripButton();
            this.Polygon = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timeLabel = new System.Windows.Forms.Label();
            this.Rubber = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.颜色ToolStripMenuItem,
            this.画笔粗细ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.新建ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(69, 34);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(139, 34);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(139, 34);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(139, 34);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(139, 34);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(113, 34);
            this.颜色ToolStripMenuItem.Text = "画笔颜色";
            this.颜色ToolStripMenuItem.Click += new System.EventHandler(this.颜色ToolStripMenuItem_Click);
            // 
            // 画笔粗细ToolStripMenuItem
            // 
            this.画笔粗细ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontsize1,
            this.fontsize2,
            this.fontsize3,
            this.fontsize4,
            this.fontsize5});
            this.画笔粗细ToolStripMenuItem.Name = "画笔粗细ToolStripMenuItem";
            this.画笔粗细ToolStripMenuItem.Size = new System.Drawing.Size(113, 34);
            this.画笔粗细ToolStripMenuItem.Text = "画笔粗细";
            // 
            // fontsize1
            // 
            this.fontsize1.Name = "fontsize1";
            this.fontsize1.Size = new System.Drawing.Size(109, 34);
            this.fontsize1.Text = "1";
            this.fontsize1.Click += new System.EventHandler(this.fontsize1_Click);
            // 
            // fontsize2
            // 
            this.fontsize2.Name = "fontsize2";
            this.fontsize2.Size = new System.Drawing.Size(109, 34);
            this.fontsize2.Text = "2";
            this.fontsize2.Click += new System.EventHandler(this.fontsize2_Click);
            // 
            // fontsize3
            // 
            this.fontsize3.Name = "fontsize3";
            this.fontsize3.Size = new System.Drawing.Size(109, 34);
            this.fontsize3.Text = "3";
            this.fontsize3.Click += new System.EventHandler(this.fontsize3_Click);
            // 
            // fontsize4
            // 
            this.fontsize4.Name = "fontsize4";
            this.fontsize4.Size = new System.Drawing.Size(109, 34);
            this.fontsize4.Text = "4";
            this.fontsize4.Click += new System.EventHandler(this.fontsize4_Click);
            // 
            // fontsize5
            // 
            this.fontsize5.Name = "fontsize5";
            this.fontsize5.Size = new System.Drawing.Size(109, 34);
            this.fontsize5.Text = "5";
            this.fontsize5.Click += new System.EventHandler(this.fontsize5_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(69, 34);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Enabled = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Line,
            this.Rectangle,
            this.Ellipse,
            this.BLine,
            this.Polygon,
            this.Rubber});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(780, 30);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(48, 27);
            this.Line.Text = "直线";
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(48, 27);
            this.Rectangle.Text = "矩形";
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Ellipse.Image = ((System.Drawing.Image)(resources.GetObject("Ellipse.Image")));
            this.Ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(48, 27);
            this.Ellipse.Text = "椭圆";
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // BLine
            // 
            this.BLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BLine.Image = ((System.Drawing.Image)(resources.GetObject("BLine.Image")));
            this.BLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BLine.Name = "BLine";
            this.BLine.Size = new System.Drawing.Size(48, 27);
            this.BLine.Text = "折线";
            this.BLine.Click += new System.EventHandler(this.BLine_Click);
            // 
            // Polygon
            // 
            this.Polygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Polygon.Image = ((System.Drawing.Image)(resources.GetObject("Polygon.Image")));
            this.Polygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(65, 27);
            this.Polygon.Text = "多边形";
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("YouYuan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(751, 523);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(22, 22);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "0";
            // 
            // Rubber
            // 
            this.Rubber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Rubber.Image = ((System.Drawing.Image)(resources.GetObject("Rubber.Image")));
            this.Rubber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rubber.Name = "Rubber";
            this.Rubber.Size = new System.Drawing.Size(48, 27);
            this.Rubber.Text = "橡皮";
            this.Rubber.Click += new System.EventHandler(this.Rubber_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 549);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "简易矢量图绘制系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Line;
        private System.Windows.Forms.ToolStripButton Rectangle;
        private System.Windows.Forms.ToolStripButton Ellipse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton BLine;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ToolStripButton Polygon;
        private System.Windows.Forms.ToolStripMenuItem 画笔粗细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontsize1;
        private System.Windows.Forms.ToolStripMenuItem fontsize2;
        private System.Windows.Forms.ToolStripMenuItem fontsize3;
        private System.Windows.Forms.ToolStripMenuItem fontsize4;
        private System.Windows.Forms.ToolStripMenuItem fontsize5;
        private System.Windows.Forms.ToolStripButton Rubber;
    }
}

