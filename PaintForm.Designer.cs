namespace Tesseract.WinFormDemo
{
    partial class PaintForm
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
            this.picbMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // picbMain
            // 
            this.picbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbMain.Location = new System.Drawing.Point(0, 0);
            this.picbMain.Name = "picbMain";
            this.picbMain.Size = new System.Drawing.Size(800, 491);
            this.picbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbMain.TabIndex = 0;
            this.picbMain.TabStop = false;
            this.picbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.picbMain_Paint);
            this.picbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picbMain_MouseDown);
            this.picbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbMain_MouseMove);
            this.picbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picbMain_MouseUp);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.picbMain);
            this.Name = "PaintForm";
            this.Text = "PaintForm";
            this.Load += new System.EventHandler(this.PaintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbMain;
    }
}