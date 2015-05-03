namespace KMeansNguyenVanVinh
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cbNumberClus = new System.Windows.Forms.ComboBox();
            this.btnLoadIamge = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonHSV = new System.Windows.Forms.RadioButton();
            this.radioButtonRGB = new System.Windows.Forms.RadioButton();
            this.btnStartKMeans = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblInfo = new System.Windows.Forms.Label();
            this.picProcessed = new System.Windows.Forms.PictureBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Cluster : ";
            // 
            // cbNumberClus
            // 
            this.cbNumberClus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumberClus.FormattingEnabled = true;
            this.cbNumberClus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbNumberClus.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbNumberClus.Location = new System.Drawing.Point(496, 40);
            this.cbNumberClus.Margin = new System.Windows.Forms.Padding(4);
            this.cbNumberClus.Name = "cbNumberClus";
            this.cbNumberClus.Size = new System.Drawing.Size(62, 21);
            this.cbNumberClus.TabIndex = 4;
            this.cbNumberClus.Text = "1";
            // 
            // btnLoadIamge
            // 
            this.btnLoadIamge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoadIamge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadIamge.Location = new System.Drawing.Point(408, 79);
            this.btnLoadIamge.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadIamge.Name = "btnLoadIamge";
            this.btnLoadIamge.Size = new System.Drawing.Size(167, 45);
            this.btnLoadIamge.TabIndex = 5;
            this.btnLoadIamge.Text = "Load Image";
            this.btnLoadIamge.UseVisualStyleBackColor = false;
            this.btnLoadIamge.Click += new System.EventHandler(this.btnLoadIamge_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonHSV);
            this.groupBox1.Controls.Add(this.radioButtonRGB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(408, 187);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(167, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Mode";
            // 
            // radioButtonHSV
            // 
            this.radioButtonHSV.AutoSize = true;
            this.radioButtonHSV.ForeColor = System.Drawing.Color.DarkViolet;
            this.radioButtonHSV.Location = new System.Drawing.Point(89, 23);
            this.radioButtonHSV.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonHSV.Name = "radioButtonHSV";
            this.radioButtonHSV.Size = new System.Drawing.Size(50, 17);
            this.radioButtonHSV.TabIndex = 0;
            this.radioButtonHSV.TabStop = true;
            this.radioButtonHSV.Text = "HSV";
            this.radioButtonHSV.UseVisualStyleBackColor = true;
            // 
            // radioButtonRGB
            // 
            this.radioButtonRGB.AutoSize = true;
            this.radioButtonRGB.ForeColor = System.Drawing.Color.DarkViolet;
            this.radioButtonRGB.Location = new System.Drawing.Point(7, 23);
            this.radioButtonRGB.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonRGB.Name = "radioButtonRGB";
            this.radioButtonRGB.Size = new System.Drawing.Size(51, 17);
            this.radioButtonRGB.TabIndex = 0;
            this.radioButtonRGB.TabStop = true;
            this.radioButtonRGB.Text = "RGB";
            this.radioButtonRGB.UseVisualStyleBackColor = true;
            // 
            // btnStartKMeans
            // 
            this.btnStartKMeans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStartKMeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartKMeans.Location = new System.Drawing.Point(408, 132);
            this.btnStartKMeans.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartKMeans.Name = "btnStartKMeans";
            this.btnStartKMeans.Size = new System.Drawing.Size(167, 45);
            this.btnStartKMeans.TabIndex = 7;
            this.btnStartKMeans.Text = "Start KMeans";
            this.btnStartKMeans.UseVisualStyleBackColor = false;
            this.btnStartKMeans.Click += new System.EventHandler(this.btnStartKMeans_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(412, 312);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(163, 13);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = ".......................................";
            // 
            // picProcessed
            // 
            this.picProcessed.Location = new System.Drawing.Point(583, 15);
            this.picProcessed.Margin = new System.Windows.Forms.Padding(4);
            this.picProcessed.Name = "picProcessed";
            this.picProcessed.Size = new System.Drawing.Size(387, 403);
            this.picProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProcessed.TabIndex = 13;
            this.picProcessed.TabStop = false;
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(14, 15);
            this.picPreview.Margin = new System.Windows.Forms.Padding(4);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(387, 403);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 1;
            this.picPreview.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tiến trình:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(978, 425);
            this.Controls.Add(this.picProcessed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnStartKMeans);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadIamge);
            this.Controls.Add(this.cbNumberClus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPreview);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân đoạn Ảnh màu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNumberClus;
        private System.Windows.Forms.Button btnLoadIamge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStartKMeans;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RadioButton radioButtonRGB;
        private System.Windows.Forms.RadioButton radioButtonHSV;
        private System.Windows.Forms.PictureBox picProcessed;
        private System.Windows.Forms.Label label2;
    }
}

