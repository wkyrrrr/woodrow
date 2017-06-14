namespace Tesseract.WinFormDemo
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.picbOriginal = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowCurBmp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtScaleX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScaleY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtOriginalScaleX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOriginalScaleY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlsprogressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnImageSelect = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbOriginal)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picbOriginal);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 527);
            this.panel1.TabIndex = 0;
            // 
            // picbOriginal
            // 
            this.picbOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbOriginal.Location = new System.Drawing.Point(0, 0);
            this.picbOriginal.Name = "picbOriginal";
            this.picbOriginal.Size = new System.Drawing.Size(673, 527);
            this.picbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbOriginal.TabIndex = 0;
            this.picbOriginal.TabStop = false;
            this.picbOriginal.Paint += new System.Windows.Forms.PaintEventHandler(this.picbOriginal_Paint);
            this.picbOriginal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picbOriginal_MouseDown);
            this.picbOriginal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbOriginal_MouseMove);
            this.picbOriginal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picbOriginal_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtResult);
            this.panel2.Location = new System.Drawing.Point(700, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 527);
            this.panel2.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(430, 527);
            this.txtResult.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShowCurBmp);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnScale);
            this.panel3.Controls.Add(this.btnTest);
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Controls.Add(this.btnImageSelect);
            this.panel3.Controls.Add(this.txtImagePath);
            this.panel3.Controls.Add(this.lblImagePath);
            this.panel3.Location = new System.Drawing.Point(12, 555);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1118, 154);
            this.panel3.TabIndex = 2;
            // 
            // btnShowCurBmp
            // 
            this.btnShowCurBmp.Location = new System.Drawing.Point(518, 61);
            this.btnShowCurBmp.Name = "btnShowCurBmp";
            this.btnShowCurBmp.Size = new System.Drawing.Size(27, 23);
            this.btnShowCurBmp.TabIndex = 14;
            this.btnShowCurBmp.Text = "@";
            this.btnShowCurBmp.UseVisualStyleBackColor = true;
            this.btnShowCurBmp.Click += new System.EventHandler(this.btnShowCurBmp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "切割信息";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtScaleX);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtScaleY);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(143, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(125, 52);
            this.panel5.TabIndex = 12;
            // 
            // txtScaleX
            // 
            this.txtScaleX.Location = new System.Drawing.Point(49, 3);
            this.txtScaleX.Name = "txtScaleX";
            this.txtScaleX.Size = new System.Drawing.Size(73, 21);
            this.txtScaleX.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "X :";
            // 
            // txtScaleY
            // 
            this.txtScaleY.Location = new System.Drawing.Point(49, 29);
            this.txtScaleY.Name = "txtScaleY";
            this.txtScaleY.Size = new System.Drawing.Size(73, 21);
            this.txtScaleY.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Y :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "原图信息";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtOriginalScaleX);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtOriginalScaleY);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(3, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 52);
            this.panel4.TabIndex = 11;
            // 
            // txtOriginalScaleX
            // 
            this.txtOriginalScaleX.Location = new System.Drawing.Point(49, 3);
            this.txtOriginalScaleX.Name = "txtOriginalScaleX";
            this.txtOriginalScaleX.ReadOnly = true;
            this.txtOriginalScaleX.Size = new System.Drawing.Size(73, 21);
            this.txtOriginalScaleX.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "X :";
            // 
            // txtOriginalScaleY
            // 
            this.txtOriginalScaleY.Location = new System.Drawing.Point(49, 29);
            this.txtOriginalScaleY.Name = "txtOriginalScaleY";
            this.txtOriginalScaleY.ReadOnly = true;
            this.txtOriginalScaleY.Size = new System.Drawing.Size(73, 21);
            this.txtOriginalScaleY.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y :";
            // 
            // btnScale
            // 
            this.btnScale.Location = new System.Drawing.Point(358, 61);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(154, 23);
            this.btnScale.TabIndex = 10;
            this.btnScale.Text = "切割";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(893, 90);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(154, 23);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "识别测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsStatus,
            this.tlsprogressbar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 132);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1118, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlsStatus
            // 
            this.tlsStatus.Name = "tlsStatus";
            this.tlsStatus.Size = new System.Drawing.Size(32, 17);
            this.tlsStatus.Text = "就绪";
            // 
            // tlsprogressbar
            // 
            this.tlsprogressbar.Name = "tlsprogressbar";
            this.tlsprogressbar.Size = new System.Drawing.Size(150, 16);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(893, 61);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "开始识别";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnImageSelect
            // 
            this.btnImageSelect.Location = new System.Drawing.Point(893, 21);
            this.btnImageSelect.Name = "btnImageSelect";
            this.btnImageSelect.Size = new System.Drawing.Size(154, 23);
            this.btnImageSelect.TabIndex = 2;
            this.btnImageSelect.Text = "选择图片";
            this.btnImageSelect.UseVisualStyleBackColor = true;
            this.btnImageSelect.Click += new System.EventHandler(this.btnImageSelect_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(98, 23);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(789, 21);
            this.txtImagePath.TabIndex = 1;
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(27, 26);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(65, 12);
            this.lblImagePath.TabIndex = 0;
            this.lblImagePath.Text = "图片路径：";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 726);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能识别Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbOriginal)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picbOriginal;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnImageSelect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlsStatus;
        private System.Windows.Forms.ToolStripProgressBar tlsprogressbar;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginalScaleY;
        private System.Windows.Forms.TextBox txtOriginalScaleX;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtScaleX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtScaleY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShowCurBmp;
    }
}

