namespace HTCSplashConverter
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Splash2BMP = new System.Windows.Forms.Button();
            this.btn_BMP2Splash = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Splash2BMP
            // 
            this.btn_Splash2BMP.AllowDrop = true;
            this.btn_Splash2BMP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Splash2BMP.Location = new System.Drawing.Point(78, 100);
            this.btn_Splash2BMP.Name = "btn_Splash2BMP";
            this.btn_Splash2BMP.Size = new System.Drawing.Size(186, 44);
            this.btn_Splash2BMP.TabIndex = 0;
            this.btn_Splash2BMP.Text = "Splash -> BMP";
            this.btn_Splash2BMP.UseVisualStyleBackColor = true;
            this.btn_Splash2BMP.Click += new System.EventHandler(this.btn_Splash2BMP_Click);
            this.btn_Splash2BMP.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn_Splash2BMP_DragDrop);
            this.btn_Splash2BMP.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn_Splash2BMP_DragEnter);
            // 
            // btn_BMP2Splash
            // 
            this.btn_BMP2Splash.AllowDrop = true;
            this.btn_BMP2Splash.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BMP2Splash.Location = new System.Drawing.Point(78, 155);
            this.btn_BMP2Splash.Name = "btn_BMP2Splash";
            this.btn_BMP2Splash.Size = new System.Drawing.Size(186, 44);
            this.btn_BMP2Splash.TabIndex = 1;
            this.btn_BMP2Splash.Text = "BMP -> Splash";
            this.btn_BMP2Splash.UseVisualStyleBackColor = true;
            this.btn_BMP2Splash.Click += new System.EventHandler(this.btn_BMP2Splash_Click);
            this.btn_BMP2Splash.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn_BMP2Splash_DragDrop);
            this.btn_BMP2Splash.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn_BMP2Splash_DragEnter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            // 
            // txt_Height
            // 
            this.txt_Height.Location = new System.Drawing.Point(76, 27);
            this.txt_Height.MaxLength = 6;
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(38, 22);
            this.txt_Height.TabIndex = 3;
            // 
            // txt_Width
            // 
            this.txt_Width.Location = new System.Drawing.Point(191, 27);
            this.txt_Width.MaxLength = 6;
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(38, 22);
            this.txt_Width.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Width);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Height);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom Resolution";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.WindowFrame;
            this.linkLabel1.Location = new System.Drawing.Point(217, 211);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 16);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Made by Mars3712";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 238);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_BMP2Splash);
            this.Controls.Add(this.btn_Splash2BMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTC Splash Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Splash2BMP;
        private System.Windows.Forms.Button btn_BMP2Splash;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

