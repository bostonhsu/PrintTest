using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace PrintTest
{
    class BarCodeClass
    {
        /// <summary>
        /// 生成条形码
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="contents"></param>
        public void CreateBarCode(PictureBox pictureBox, string contents)
        {
            Regex regex = new Regex("^[0-9]{12}$");
            if (!regex.IsMatch(contents))
            {
                MessageBox.Show("12 numbers.");
                return;
            }
            EncodingOptions options = null;
            BarcodeWriter writer = null;
            options = new EncodingOptions
            {
                Width = pictureBox.Width,
                Height = pictureBox.Height
            };
            writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.ITF;
            writer.Options = options;
            Bitmap bitmap = writer.Write(contents);
            pictureBox.Image = bitmap;
        }

        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="contents"></param>
        public void CreateQuickMark(PictureBox pictureBox, string contents)
        {
            if (contents == string.Empty)
            {
                MessageBox.Show("Null!");
                return;
            }
            EncodingOptions options = null;
            BarcodeWriter writer = null;
            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = pictureBox.Width,
                Height = pictureBox.Height
            };
            writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
            Bitmap bitmap = writer.Write(contents);
            pictureBox.Image = bitmap;

        }

        /// <summary>
        /// 解码
        /// </summary>
        /// <param name="pictureBox"></param>
        public void Decode(PictureBox pictureBox)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap) pictureBox.Image);
        }

    }
}
