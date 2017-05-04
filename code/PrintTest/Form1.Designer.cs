namespace PrintTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSendFileToPrinter = new System.Windows.Forms.Button();
            this.pdDetail = new System.Drawing.Printing.PrintDocument();
            this.ppd1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrintWithPreview = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendFileToPrinter
            // 
            this.btnSendFileToPrinter.Location = new System.Drawing.Point(23, 22);
            this.btnSendFileToPrinter.Name = "btnSendFileToPrinter";
            this.btnSendFileToPrinter.Size = new System.Drawing.Size(194, 36);
            this.btnSendFileToPrinter.TabIndex = 0;
            this.btnSendFileToPrinter.Text = "把文件发送到打印机";
            this.btnSendFileToPrinter.UseVisualStyleBackColor = true;
            this.btnSendFileToPrinter.Click += new System.EventHandler(this.btnSendFileToPrinter_Click);
            // 
            // ppd1
            // 
            this.ppd1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppd1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppd1.ClientSize = new System.Drawing.Size(400, 300);
            this.ppd1.Enabled = true;
            this.ppd1.Icon = ((System.Drawing.Icon)(resources.GetObject("ppd1.Icon")));
            this.ppd1.Name = "ppd1";
            this.ppd1.Visible = false;
            // 
            // btnPrintWithPreview
            // 
            this.btnPrintWithPreview.Location = new System.Drawing.Point(23, 91);
            this.btnPrintWithPreview.Name = "btnPrintWithPreview";
            this.btnPrintWithPreview.Size = new System.Drawing.Size(194, 36);
            this.btnPrintWithPreview.TabIndex = 1;
            this.btnPrintWithPreview.Text = "有打印预览";
            this.btnPrintWithPreview.UseVisualStyleBackColor = true;
            this.btnPrintWithPreview.Click += new System.EventHandler(this.btnPrintWithPreview_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 183);
            this.textBox1.TabIndex = 2;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(32, 201);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(317, 21);
            this.txtMsg.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "生产条形码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "生产二维码";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "解   码";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(387, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "打   印";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 143);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPrintWithPreview);
            this.Controls.Add(this.btnSendFileToPrinter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendFileToPrinter;
        private System.Drawing.Printing.PrintDocument pdDetail;
        private System.Windows.Forms.PrintPreviewDialog ppd1;
        private System.Windows.Forms.Button btnPrintWithPreview;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

