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
    public partial class QRCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btngenerate_Click(object sender, EventArgs e)
        {
            //string generatebarcode = txtqrcode.Text;
            //QRCodeGenerator code = new QRCodeGenerator();
            //QRCodeData qrcodedata = code.CreateQrCode(generatebarcode, QRCodeGenerator.ECCLevel.Q);
            //QRCode qrcode = new QRCode(qrcodedata);
            //Bitmap bitmap = qrcode.getgraphic 

            GenerateCode(txtqrcode.Text);
        }

        private void GenerateCode(string name)
        {
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            var result = writer.Write(name);
            string path = Server.MapPath("~/imagess/QRImage.jpg");
            var barcodebitmap = new Bitmap(result);
            using (MemoryStream memory = new MemoryStream())
            {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                {
                    barcodebitmap.Save(memory, ImageFormat.Jpeg);
                    byte[] bytes = memory.ToArray();
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
            imgqrcode.Visible = true;
            imgqrcode.ImageUrl = "~/imagess/QRImage.jpg";
        }

        protected void btnreadqrcode_Click(object sender, EventArgs e)
        {
            ReadQRCode();
        }

        private void ReadQRCode()
        {
            var reader = new BarcodeReader();
            string filename = Path.Combine(Request.MapPath("~/imagess"), "QRImage.jpg");
            
            var result = reader.Decode(new Bitmap(filename));
            if(result != null)
            {
                lblreadqr.Text =  result.Text;
            }
        }

       
        }
    }
