namespace Tesseract.WinFormDemo
{
    partial class RecgonitionMain
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnImageSelect = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rcgTmpUC = new Tesseract.WinFormDemo.OCR.RecognitionTemplateUC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rcgTmpUC);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 702);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnTest);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Controls.Add(this.btnImageSelect);
            this.panel3.Controls.Add(this.txtImagePath);
            this.panel3.Controls.Add(this.lblImagePath);
            this.panel3.Location = new System.Drawing.Point(804, 545);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 154);
            this.panel3.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(159, 124);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(154, 23);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "识别测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(159, 95);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "开始识别";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnImageSelect
            // 
            this.btnImageSelect.Location = new System.Drawing.Point(159, 55);
            this.btnImageSelect.Name = "btnImageSelect";
            this.btnImageSelect.Size = new System.Drawing.Size(154, 23);
            this.btnImageSelect.TabIndex = 2;
            this.btnImageSelect.Text = "选择图片";
            this.btnImageSelect.UseVisualStyleBackColor = true;
            this.btnImageSelect.Click += new System.EventHandler(this.btnImageSelect_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(78, 12);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(232, 21);
            this.txtImagePath.TabIndex = 1;
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(7, 15);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(65, 12);
            this.lblImagePath.TabIndex = 0;
            this.lblImagePath.Text = "图片路径：";
            // 
            // rcgTmpUC
            // 
            this.rcgTmpUC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rcgTmpUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rcgTmpUC.Location = new System.Drawing.Point(0, 0);
            this.rcgTmpUC.Name = "rcgTmpUC";
            this.rcgTmpUC.Size = new System.Drawing.Size(673, 702);
            this.rcgTmpUC.TabIndex = 0;
            // 
            // RecgonitionMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 726);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RecgonitionMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能识别Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnImageSelect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTest;
        private OCR.RecognitionTemplateUC rcgTmpUC;
    }
}

