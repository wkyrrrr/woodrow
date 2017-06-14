namespace Tesseract.WinFormDemo.OCR
{
    partial class RecognitionTemplateUC
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picbMain = new System.Windows.Forms.PictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.txtImageSize = new System.Windows.Forms.TextBox();
            this.txtMousePoint = new System.Windows.Forms.TextBox();
            this.grpBoxPaneInfo = new System.Windows.Forms.GroupBox();
            this.txtEP = new System.Windows.Forms.TextBox();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaneType = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpBoxPaneType = new System.Windows.Forms.GroupBox();
            this.rdbtnContent = new System.Windows.Forms.RadioButton();
            this.rdbtnTitle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picbMain)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.grpBoxPaneInfo.SuspendLayout();
            this.grpBoxPaneType.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbMain
            // 
            this.picbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbMain.Location = new System.Drawing.Point(0, 0);
            this.picbMain.Name = "picbMain";
            this.picbMain.Size = new System.Drawing.Size(949, 534);
            this.picbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbMain.TabIndex = 0;
            this.picbMain.TabStop = false;
            this.picbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.picbMain_Paint);
            this.picbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picbMain_MouseDown);
            this.picbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbMain_MouseMove);
            this.picbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picbMain_MouseUp);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfo.Controls.Add(this.txtImageSize);
            this.pnlInfo.Controls.Add(this.txtMousePoint);
            this.pnlInfo.Controls.Add(this.grpBoxPaneInfo);
            this.pnlInfo.Controls.Add(this.grpBoxPaneType);
            this.pnlInfo.Location = new System.Drawing.Point(3, 540);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(943, 144);
            this.pnlInfo.TabIndex = 1;
            // 
            // txtImageSize
            // 
            this.txtImageSize.Location = new System.Drawing.Point(5, 72);
            this.txtImageSize.Name = "txtImageSize";
            this.txtImageSize.ReadOnly = true;
            this.txtImageSize.Size = new System.Drawing.Size(88, 21);
            this.txtImageSize.TabIndex = 11;
            // 
            // txtMousePoint
            // 
            this.txtMousePoint.Location = new System.Drawing.Point(5, 120);
            this.txtMousePoint.Name = "txtMousePoint";
            this.txtMousePoint.ReadOnly = true;
            this.txtMousePoint.Size = new System.Drawing.Size(88, 21);
            this.txtMousePoint.TabIndex = 10;
            // 
            // grpBoxPaneInfo
            // 
            this.grpBoxPaneInfo.Controls.Add(this.txtEP);
            this.grpBoxPaneInfo.Controls.Add(this.txtSP);
            this.grpBoxPaneInfo.Controls.Add(this.label1);
            this.grpBoxPaneInfo.Controls.Add(this.label2);
            this.grpBoxPaneInfo.Controls.Add(this.txtPaneType);
            this.grpBoxPaneInfo.Controls.Add(this.txtCode);
            this.grpBoxPaneInfo.Controls.Add(this.txtName);
            this.grpBoxPaneInfo.Controls.Add(this.lblType);
            this.grpBoxPaneInfo.Controls.Add(this.lblCode);
            this.grpBoxPaneInfo.Controls.Add(this.lblName);
            this.grpBoxPaneInfo.Location = new System.Drawing.Point(135, 19);
            this.grpBoxPaneInfo.Name = "grpBoxPaneInfo";
            this.grpBoxPaneInfo.Size = new System.Drawing.Size(256, 122);
            this.grpBoxPaneInfo.TabIndex = 2;
            this.grpBoxPaneInfo.TabStop = false;
            this.grpBoxPaneInfo.Text = "框体信息";
            // 
            // txtEP
            // 
            this.txtEP.Location = new System.Drawing.Point(174, 49);
            this.txtEP.Name = "txtEP";
            this.txtEP.ReadOnly = true;
            this.txtEP.Size = new System.Drawing.Size(68, 21);
            this.txtEP.TabIndex = 9;
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(174, 22);
            this.txtSP.Name = "txtSP";
            this.txtSP.ReadOnly = true;
            this.txtSP.Size = new System.Drawing.Size(68, 21);
            this.txtSP.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "EP：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "SP：";
            // 
            // txtPaneType
            // 
            this.txtPaneType.Location = new System.Drawing.Point(53, 76);
            this.txtPaneType.Name = "txtPaneType";
            this.txtPaneType.ReadOnly = true;
            this.txtPaneType.Size = new System.Drawing.Size(68, 21);
            this.txtPaneType.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(53, 49);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(68, 21);
            this.txtCode.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(53, 22);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(68, 21);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 79);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 12);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "类型 ：";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(6, 52);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(47, 12);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "编码 ：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "名称 ：";
            // 
            // grpBoxPaneType
            // 
            this.grpBoxPaneType.Controls.Add(this.rdbtnContent);
            this.grpBoxPaneType.Controls.Add(this.rdbtnTitle);
            this.grpBoxPaneType.Location = new System.Drawing.Point(5, 19);
            this.grpBoxPaneType.Name = "grpBoxPaneType";
            this.grpBoxPaneType.Size = new System.Drawing.Size(124, 47);
            this.grpBoxPaneType.TabIndex = 1;
            this.grpBoxPaneType.TabStop = false;
            this.grpBoxPaneType.Text = "框体类型";
            // 
            // rdbtnContent
            // 
            this.rdbtnContent.AutoSize = true;
            this.rdbtnContent.Location = new System.Drawing.Point(68, 22);
            this.rdbtnContent.Name = "rdbtnContent";
            this.rdbtnContent.Size = new System.Drawing.Size(47, 16);
            this.rdbtnContent.TabIndex = 1;
            this.rdbtnContent.Text = "内容";
            this.rdbtnContent.UseVisualStyleBackColor = true;
            this.rdbtnContent.CheckedChanged += new System.EventHandler(this.rdbtnContent_CheckedChanged);
            // 
            // rdbtnTitle
            // 
            this.rdbtnTitle.AutoSize = true;
            this.rdbtnTitle.Checked = true;
            this.rdbtnTitle.Location = new System.Drawing.Point(6, 22);
            this.rdbtnTitle.Name = "rdbtnTitle";
            this.rdbtnTitle.Size = new System.Drawing.Size(47, 16);
            this.rdbtnTitle.TabIndex = 0;
            this.rdbtnTitle.TabStop = true;
            this.rdbtnTitle.Text = "名称";
            this.rdbtnTitle.UseVisualStyleBackColor = true;
            // 
            // RecognitionTemplateUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.picbMain);
            this.Name = "RecognitionTemplateUC";
            this.Size = new System.Drawing.Size(949, 687);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RecognitionTemplateUC_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picbMain)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.grpBoxPaneInfo.ResumeLayout(false);
            this.grpBoxPaneInfo.PerformLayout();
            this.grpBoxPaneType.ResumeLayout(false);
            this.grpBoxPaneType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbMain;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.GroupBox grpBoxPaneInfo;
        private System.Windows.Forms.TextBox txtPaneType;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpBoxPaneType;
        private System.Windows.Forms.RadioButton rdbtnContent;
        private System.Windows.Forms.RadioButton rdbtnTitle;
        private System.Windows.Forms.TextBox txtEP;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMousePoint;
        private System.Windows.Forms.TextBox txtImageSize;
    }
}
