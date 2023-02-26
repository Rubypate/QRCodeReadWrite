using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;
using ZXing;
using System.IO;

namespace QRCodeReadWrite
{
    public partial class BarCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnbarcode_Click(object sender, EventArgs e)
        {
            string barcode = txtbarcode.Text;
            //System.Web.UI.WebControls.Image imgbarcode = new System.Web.UI.WebControls.Image();
            System.Web.UI.WebControls.Image imgbarcode = new System.Web.UI.WebControls.Image();
            using (Bitmap bitmap = new Bitmap(barcode.Length * 40, 80))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    Font oFont = new Font("IDAutomationHC39M", 36);
                    PointF point = new PointF(2f, 2f);
                    SolidBrush blackbrush = new SolidBrush(Color.Black);
                    SolidBrush whitebruch = new SolidBrush(Color.White);
                    graphics.FillRectangle(whitebruch, 0, 0, bitmap.Width, bitmap.Height);
                    graphics.DrawString(barcode , oFont, blackbrush, point);
                }
                using (MemoryStream memory = new MemoryStream())
                {
                    bitmap.Save(memory, ImageFormat.Png);
                    byte[] byteImage = memory.ToArray();
                    Convert.ToBase64String(byteImage);
                    imgbarcode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
                }
                plbarcode.Controls.Add(imgbarcode);
            }
        }
    }
}