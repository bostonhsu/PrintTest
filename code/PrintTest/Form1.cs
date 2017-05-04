using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using ZXing;

namespace PrintTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BarCodeClass bcc = new BarCodeClass();
        private DocumentBase _document;

        private static string GetFilePath()
        {
            string filepath = AppDomain.CurrentDomain.BaseDirectory;
            int binPos = filepath.IndexOf("bin");
            string binPath = filepath.Remove(binPos);
            return binPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text += "Aloha\r\n";
            textBox1.Text += "Hello";

            txtMsg.Text = System.DateTime.Now.ToString("yyyyMMddhhmmss").Substring(0, 12);
        }

        private void btnSendFileToPrinter_Click(object sender, EventArgs e)
        {
            string strBinPath = GetFilePath();
            Process pr = new Process();
            pr.StartInfo.FileName = "1.txt";
            pr.StartInfo.CreateNoWindow = true;
            pr.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            pr.StartInfo.Verb = "Print";
            pr.Start();
        }

        private void btnPrintWithPreview_Click(object sender, EventArgs e)
        {
            pdDetail.DefaultPageSettings.PaperSize = new PaperSize("Custom", 236, 472);
            pdDetail.PrintPage += new PrintPageEventHandler(MyPrintDocumet_PrintPage);
            ppd1.Document = pdDetail;
            DialogResult result = ppd1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pdDetail.Print();
            }
        }

        private void MyPrintDocumet_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, new Font(new FontFamily("黑体"), 11), System.Drawing.Brushes.Black, 50, 35);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bcc.CreateBarCode(pictureBox1, txtMsg.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bcc.CreateQuickMark(pictureBox1, txtMsg.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please input the image.");
                return;
            }
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap) pictureBox1.Image);
            MessageBox.Show(result.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("You must load an image first.");
                return;
            }
            else
            {
                _document = new imageDocument(pictureBox1.Image);
            }
            _document.showPrintPreviewDialog();
        }
    }
}
