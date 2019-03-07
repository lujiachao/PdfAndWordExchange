namespace WordAndPDF
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOpenWord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textWordPath = new System.Windows.Forms.TextBox();
            this.btnWordToPDF = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPdfPath = new System.Windows.Forms.TextBox();
            this.BtnOpenPdf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioDoc = new System.Windows.Forms.RadioButton();
            this.radioDocx = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(389, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 460);
            this.label1.TabIndex = 0;
            // 
            // BtnOpenWord
            // 
            this.BtnOpenWord.Location = new System.Drawing.Point(275, 96);
            this.BtnOpenWord.Name = "BtnOpenWord";
            this.BtnOpenWord.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenWord.TabIndex = 1;
            this.BtnOpenWord.Text = "打开Word";
            this.BtnOpenWord.UseVisualStyleBackColor = true;
            this.BtnOpenWord.Click += new System.EventHandler(this.BtnOpenWord_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(107, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Word转化为PDF";
            // 
            // textWordPath
            // 
            this.textWordPath.Location = new System.Drawing.Point(12, 98);
            this.textWordPath.Name = "textWordPath";
            this.textWordPath.Size = new System.Drawing.Size(240, 21);
            this.textWordPath.TabIndex = 3;
            // 
            // btnWordToPDF
            // 
            this.btnWordToPDF.Location = new System.Drawing.Point(110, 171);
            this.btnWordToPDF.Name = "btnWordToPDF";
            this.btnWordToPDF.Size = new System.Drawing.Size(75, 23);
            this.btnWordToPDF.TabIndex = 1;
            this.btnWordToPDF.Text = "转化为PDF";
            this.btnWordToPDF.UseVisualStyleBackColor = true;
            this.btnWordToPDF.Click += new System.EventHandler(this.btnWordToPDF_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(13, 67);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 21);
            this.txtFileName.TabIndex = 4;
            this.txtFileName.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(528, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "PDF转化为Word";
            // 
            // txtPdfPath
            // 
            this.txtPdfPath.Location = new System.Drawing.Point(441, 96);
            this.txtPdfPath.Name = "txtPdfPath";
            this.txtPdfPath.Size = new System.Drawing.Size(209, 21);
            this.txtPdfPath.TabIndex = 5;
            // 
            // BtnOpenPdf
            // 
            this.BtnOpenPdf.Location = new System.Drawing.Point(684, 94);
            this.BtnOpenPdf.Name = "BtnOpenPdf";
            this.BtnOpenPdf.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenPdf.TabIndex = 1;
            this.BtnOpenPdf.Text = "打开Pdf";
            this.BtnOpenPdf.UseVisualStyleBackColor = true;
            this.BtnOpenPdf.Click += new System.EventHandler(this.BtnOpenPdf_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "转化为Word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioDoc
            // 
            this.radioDoc.AutoSize = true;
            this.radioDoc.Checked = true;
            this.radioDoc.Location = new System.Drawing.Point(485, 139);
            this.radioDoc.Name = "radioDoc";
            this.radioDoc.Size = new System.Drawing.Size(41, 16);
            this.radioDoc.TabIndex = 6;
            this.radioDoc.TabStop = true;
            this.radioDoc.Text = "doc";
            this.radioDoc.UseVisualStyleBackColor = true;
            this.radioDoc.Click += new System.EventHandler(this.radioDoc_Click);
            // 
            // radioDocx
            // 
            this.radioDocx.AutoSize = true;
            this.radioDocx.Location = new System.Drawing.Point(623, 139);
            this.radioDocx.Name = "radioDocx";
            this.radioDocx.Size = new System.Drawing.Size(47, 16);
            this.radioDocx.TabIndex = 7;
            this.radioDocx.TabStop = true;
            this.radioDocx.Text = "Docx";
            this.radioDocx.UseVisualStyleBackColor = true;
            this.radioDocx.CheckedChanged += new System.EventHandler(this.radioDocx_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioDocx);
            this.Controls.Add(this.radioDoc);
            this.Controls.Add(this.txtPdfPath);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.textWordPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWordToPDF);
            this.Controls.Add(this.BtnOpenPdf);
            this.Controls.Add(this.BtnOpenWord);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WordAndPDF转换工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOpenWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textWordPath;
        private System.Windows.Forms.Button btnWordToPDF;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPdfPath;
        private System.Windows.Forms.Button BtnOpenPdf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioDoc;
        private System.Windows.Forms.RadioButton radioDocx;
    }
}

